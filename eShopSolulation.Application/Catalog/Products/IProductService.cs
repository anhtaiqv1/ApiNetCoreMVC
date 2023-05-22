
using eShopSolution.Data.Entities;
using eShopSolution.ViewModel.Catalog.ProductImages;
using eShopSolution.ViewModel.Catalog.Products;
using eShopSolution.ViewModel.Common;
using eShopSolution.ViewModel.System.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace eShopSolulation.Application.Catalog.Products
{
    public interface IProductService
    {
        Task <int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int producId);

        Task<ProductVm>GetById (int producId ,string languageId);

        Task<bool> UpdatePrice(int ProductId, int newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewCount(int productId);

        Task <PagedResult<ProductVm>> GetAllPaging(GetManageProductPagingRequest request);


       Task<int> AddImage(int productId,ProductImageCreateRequest request);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage( int imageId, ProductImageUpdateRequest request);
        Task<ProductImageViewModel> GetImageById(int imageId);

        Task<List<ProductImageViewModel>> GetListImage(int productId);


        Task<PagedResult<ProductVm>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);

        Task<List<ProductVm>> GetAll(GetManageProductPagingRequest request);
        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);
    }
}

