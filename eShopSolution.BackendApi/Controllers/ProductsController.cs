using eShopSolulation.Application.Catalog.Products;
using eShopSolution.Data.Entities;
using eShopSolution.ViewModel.Catalog.ProductImages;
using eShopSolution.ViewModel.Catalog.Products;
using eShopSolution.ViewModel.System.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class ProductsController : ControllerBase
    {


        private readonly IProductService _productService;

        public ProductsController( IProductService productService)
        {
         _productService = productService;
        

        }
        //[HttpGet("{languageId}")]
        //public async Task<IActionResult> GetAllPaging(string languageId, [FromQuery] GetPublicProductPagingRequest request)
        //{
        //    var products = await _productService.GetAllByCategoryId(languageId, request);
        //    return Ok(products);
        //}

        [HttpGet("{paging}")]
        public async Task<IActionResult> GetAllPaging( [FromQuery] GetManageProductPagingRequest request)
        {
            var products = await _productService.GetAllPaging( request);
            return Ok(products);
        }


        [HttpGet("Value")]
        public async Task<IActionResult> Get([FromQuery] GetManageProductPagingRequest request)
        {
            var products = await _productService.GetAll(request);
            return Ok(products);

        }


      

        [HttpGet("{productId}/{languageId}")]
        public async Task<IActionResult> GetById(int productId, string languageId)
        {
            var products = await _productService.GetById(productId, languageId);
            if (products == null)
                return BadRequest("Canot find product");
            return Ok(products);
        }


        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var producId = await _productService.Create(request);
            if (producId == 0)
                return BadRequest();
            var product = await _productService.GetById(producId, request.LanguageId) ;

            return CreatedAtAction(nameof(GetById), new { id = producId }, producId);
        }


        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var affectedResault = await _productService.Update(request);
            if (affectedResault == 0)
                return BadRequest();    
            return Ok();
        }


        [HttpDelete("{ProductId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affectedResault = await _productService.Delete(productId);
            if (affectedResault == 0)
                return BadRequest();
            return Ok();
        }

        [HttpPut("{ProductId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice( int id, int newPrice)
        {
            var isSuccessful = await _productService.UpdatePrice(id, newPrice);
            if (isSuccessful)
                return Ok();
            return BadRequest();
        }

        //image 
        [HttpPost("{productId}/images")]
        public async Task<IActionResult> CreateImage([FromForm] int productId ,ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var imageId = await _productService.AddImage(productId,request);
            if (imageId == 0)
                return BadRequest();
            var image = await _productService.GetImageById( imageId);

            return CreatedAtAction(nameof(GetImageById), new { id = imageId }, image);
        }

        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(int productId, int imageId)
        {
            var image = await _productService.GetImageById(imageId);
            if (image == null)
                return BadRequest("Canot find product");
            return Ok(image);
        }


        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage([FromForm] int imageId, ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _productService.UpdateImage (imageId, request);
            if (result == 0)
                return BadRequest();
                return Ok();
        }

        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> RemoveImage( int imageId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _productService.RemoveImage(imageId);
            if (result == 0)
                return BadRequest();
            return Ok();
        }
        [HttpPut("{id}/categories")]
        public async Task<IActionResult> CategoryAssign(int id, [FromBody] CategoryAssignRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _productService.CategoryAssign(id, request);
            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}

