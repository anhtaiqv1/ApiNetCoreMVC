
using eShopSolulation.Utilities.Exceptions;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using eShopSolution.ViewModel.Catalog.Products;
using eShopSolution.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.IO;
using eShopSolution.Application.Common;
using Microsoft.Data.SqlClient;
using eShopSolution.ViewModel.Catalog.ProductImages;

namespace eShopSolulation.Application.Catalog.Products.Dtos
{
    public class ProductService : IProductService
    {
        private readonly EShopDbContext _context;
        private readonly IstorageServicecs _storageService;

        public ProductService(EShopDbContext context, IstorageServicecs storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<int> AddImage(int productId, ProductImageCreateRequest request)
        {
            var productImage = new ProductImage()
            {
                Caption = request.Caption,
                DateCreated = DateTime.Now,
                IsDefault = request.IsDefault,
                ProductId = productId,
                SortOrder = request.SortOrder,
            };
            if (request.ImageFile !=null )
            {
                productImage.ImagePath = await this.SaveFile(request.ImageFile);
                productImage.FileSize = request.ImageFile.Length;
            }
            _context.ProductImages.Add( productImage );
             await _context .SaveChangesAsync();
            return productImage.Id;

        }

        public async Task AddViewCount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.ViewCout += 1;
            await _context.SaveChangesAsync();
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            try
            {
                var product = new Product()
                {
                    Price = request.Price,
                    DateCreated = DateTime.Now,
                    OriginalPrice = request.OriginalPrice,
                    Stock = request.Stock,
                    ViewCout = 0,

                    ProductTranslations = new List<ProductTranslation>()
                {
                    new ProductTranslation()
                    {
                        Name = request.Name,
                        Description = request.Description,
                        Details = request.Details,
                        SeoAlias = request.SeoAlias,
                        SeoDescription = request.SeoDescription,
                        SeoTitle = request.SeoTitle,
                        LanguageId = request.LanguageId,
                    }
                }
                };

                //saveFile
                if (request.ThumbanilImage != null)
                {
                    product.ProductImages = new List<ProductImage>()
                {
                    new ProductImage()
                    {
                        Caption ="Thumban Image",
                        DateCreated= DateTime.Now,
                        FileSize = request.ThumbanilImage.Length,
                        ImagePath = await this.SaveFile(request.ThumbanilImage),
                        IsDefault = true,
                        SortOrder = 1
                    }
                };
                }

                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return product.Id;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
            
        }

        public async Task<int> Delete(int producId)
        {
            var product = await _context.Products.FindAsync(producId);
            if (product == null) throw new EShopException($"Cant find a product :{producId} ");

            var images = _context.ProductImages.Where(x => x.ProductId == producId);
            foreach ( var image in images)
            {
                await _storageService.DeleteFileAsync(image.ImagePath);
            }

            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<ProductViewModel>> GetAll( GetManageProductPagingRequest request)
        {
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        select new { p, pic, pt };

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
               .Take(request.PageSize)
               .Select(x => new ProductViewModel()
               {
                   Id = x.p.Id,
                   Name = x.pt.Name,
                   Description = x.pt.Description,
                   Details = x.pt.Details,
                   SeoDescription = x.pt.SeoDescription,
                   SeoAlias = x.pt.SeoAlias,
                   SeoTitle = x.pt.SeoTitle,
                   Price = x.p.Price,
                   LanguageId = x.pt.LanguageId,
                   OriginalPrice = x.p.OriginalPrice,
                   Stock = x.p.Stock,
                   ViewCout = x.p.ViewCout,
                   DateCreated = x.p.DateCreated,

               }).ToListAsync();
               return data;
        }

        public async Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request)
        {
            //1. Select join
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        where pt.LanguageId == languageId
                        select new { p, pt, pic };
            //2. filter
            if (request.CategoryId.HasValue && request.CategoryId.Value > 0)
            {
                query = query.Where(p => p.pic.CategoryId == request.CategoryId);
            }
            //3. Paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    DateCreated = x.p.DateCreated,
                    Description = x.pt.Description,
                    Details = x.pt.Details,
                    LanguageId = x.pt.LanguageId,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    SeoAlias = x.pt.SeoAlias,
                    SeoDescription = x.pt.SeoDescription,
                    SeoTitle = x.pt.SeoTitle,
                    Stock = x.p.Stock,
                    ViewCout = x.p.ViewCout,

                }).ToListAsync();
            var pageResault = new PagedResult<ProductViewModel>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pageResault;
        }

            public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request)
        {
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        select new { p, pic, pt };

            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.pt.Name.Contains(request.Keyword));
            if (request.CategoryIds.Count > 0)
            {
                query = query.Where(p => request.CategoryIds.Contains(p.pic.CategoryId));
            }

            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    Description = x.pt.Description,
                    Details = x.pt.Details,
                    SeoDescription = x.pt.SeoDescription,
                    SeoAlias = x.pt.SeoAlias,
                    SeoTitle = x.pt.SeoTitle,
                    Price = x.p.Price,
                    LanguageId = x.pt.LanguageId,
                    OriginalPrice = x.p.OriginalPrice,
                    Stock = x.p.Stock,
                    ViewCout = x.p.ViewCout,
                    DateCreated = x.p.DateCreated,

                }).ToListAsync();
            var pageResault = new PagedResult<ProductViewModel>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pageResault;

        }

        public async Task<ProductViewModel> GetById(int producId, string languageId)
        {
            var product = await _context.Products.FindAsync(producId);
            var productTranslation = await _context.ProductTranslations.FirstOrDefaultAsync(x=>x.ProductId==producId && x.LanguageId==languageId);

            var productViewModel = new ProductViewModel()
            {
                Id = producId,
                Description = productTranslation != null ? productTranslation.Description : null,
                LanguageId = productTranslation.LanguageId,
                Details = productTranslation != null ? productTranslation.Details : null,
                Name = productTranslation != null ? productTranslation.Name : null,
                OriginalPrice = product.OriginalPrice,
                Price = product.Price,
                SeoAlias = productTranslation != null ? productTranslation.SeoAlias : null,
                SeoDescription = productTranslation != null ? productTranslation.SeoDescription : null,
                SeoTitle = productTranslation != null ? productTranslation.SeoTitle : null,
                Stock = product.Stock,
                ViewCout = product.ViewCout

            };
            return productViewModel;
        }

        public async Task<ProductImageViewModel> GetImageById(int imageId)
        {
            var image = await _context.ProductImages.FindAsync(imageId);

            if (image != null)
                throw new EShopException($"Cannot find an image with id {imageId}");
                var viewModel = new ProductImageViewModel()
                {
                    Caption = image.Caption,
                    DateCreated = image.DateCreated,
                    FileSize = image.FileSize,
                    Id = image.Id,
                    ImagePath = image.ImagePath,
                    IsDefault = image.IsDefault,
                    ProductId = image.ProductId,
                    SortOrder = image.SortOrder,
                };
            return viewModel;
        }

        public async Task<List<ProductImageViewModel>> GetListImage(int productId)
        {
            return await _context.ProductImages.Where(x => x.ProductId == productId)
                .Select(i => new ProductImageViewModel()
            {
                Caption = i.Caption,
                DateCreated = i.DateCreated,
                FileSize = i.FileSize,
                Id = i.Id,
                ImagePath = i.ImagePath,
                IsDefault = i.IsDefault,
                ProductId = i.ProductId,
                SortOrder = i.SortOrder,
            }).ToListAsync();
        }

        public async Task<int> RemoveImage( int imageId)
        {
            var productImage = await _context.ProductImages.FindAsync(imageId);
            if (productImage != null)
                throw new EShopException($"Cannot find an image with id {imageId}");
            _context.ProductImages.Remove(productImage);
            return await _context.SaveChangesAsync();

           
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            var productTranslation = await _context.ProductTranslations.FirstOrDefaultAsync(x => x.ProductId == request.Id
            && x.LanguageId == request.LanguageId);
            if (product == null || productTranslation == null) throw new EShopException($"Cannot find a product with id :{request.Id}");

            productTranslation.Name = request.Name;
            productTranslation.Description = request.Description;
            productTranslation.SeoDescription = request.SeoDescription;
            productTranslation.SeoTitle = request.SeoTitle;
            productTranslation.SeoAlias = request.SeoAlias;
            productTranslation.Details = request.Details;


            if (request.ThumbanilImage != null)
            {
                var thumbanilImage = await _context.ProductImages.FirstOrDefaultAsync(i=>i.IsDefault==true && i.ProductId == request.Id);
                if (thumbanilImage != null)
                {
                    thumbanilImage.FileSize = request.ThumbanilImage.Length;
                    thumbanilImage.ImagePath = await this.SaveFile(request.ThumbanilImage);
                    _context.ProductImages.Update(thumbanilImage);
                }

            }
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateImage( int imageId, ProductImageUpdateRequest request)
        {
            var productImage =await _context.ProductImages.FindAsync(imageId);
            if (productImage == null)
                throw new EShopException($"Cant not find an image with id {imageId}");


            if (request.ImageFile != null)
            {
                productImage.ImagePath = await this.SaveFile(request.ImageFile);
                productImage.FileSize = request.ImageFile.Length;
            }
            _context.ProductImages.Update(productImage);
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePrice(int ProductId, int newPrice)
        {
            var propduct = await _context.Products.FindAsync(ProductId);
            if (propduct == null) throw new EShopException($"cannot find a product with id :{ProductId}");

            propduct.Price = newPrice;
            return  await  _context.SaveChangesAsync() >0 ;    
        }

        public async Task<bool> UpdateStock(int productId, int addedQuantity)
        {
            var propduct = await _context.Products.FindAsync(productId);
            if (propduct == null) throw new EShopException($"cannot find a product with id :{productId}");

            propduct.Stock += addedQuantity;
            return await _context.SaveChangesAsync() > 0;
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var orginalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(orginalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;


        }
       


    }
}
