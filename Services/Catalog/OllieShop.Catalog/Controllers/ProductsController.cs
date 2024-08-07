﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OllieShop.Catalog.Dtos.ProductDtos;
using OllieShop.Catalog.Services.ProductServices;

namespace OllieShop.Catalog.Controllers
{
    [AllowAnonymous]

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productService.GetAllProductAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(string id)
        {
            var value = await _productService.GetByIdProductAsync(id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productService.CreateProductAsync(createProductDto);
            return Ok("Product Added Successfully.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return Ok("Product Deleted Successfully.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _productService.UpdateProductAsync(updateProductDto);
            return Ok("Product Updated Successfully.");
        }

        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var value = await _productService.GetProductsWithCategoryAsync();
            return Ok(value);
        }

        [HttpGet("ProductListByCategory")]
        public async Task<IActionResult> ProductListByCategory(string id)
        {
            var value = await _productService.GetProductsByCategoryIdAsync(id);
            return Ok(value);
        }

        [HttpGet("GetAllProductDetails")]
        public async Task<IActionResult> GetAllProductDetails(string id)
        {
            var value = await _productService.GetAllProductDetailsAsync(id);
            return Ok(value);
        }
        
        [HttpGet("GetAvailableColorsForSize")]
        public async Task<IActionResult> GetAvailableColorsForSize(string sizeId, string productId)
        {
            var values = await _productService.GetColorsForSize(sizeId,productId);
            return Ok(values);
        }
    }
}
