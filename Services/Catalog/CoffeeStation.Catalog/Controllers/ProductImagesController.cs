using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeStation.Catalog.Dtos.ProductImageDtos;
using CoffeeStation.Catalog.Services.ProductImageServices;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeStation.Catalog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductImagesController : ControllerBase
    {
        private readonly IProductImageService _productImageService;

        public ProductImagesController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productImageService.GetAllProductImageAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductImageById(string id)
        {
            var values = await _productImageService.GetByIdProductImageAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductImage(
            CreateProductImageDto createProductImageDto
        )
        {
            await _productImageService.CreateProductImageAsync(createProductImageDto);
            return Ok("Urun gorselleri basariyla eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProductImage(string id)
        {
            await _productImageService.DeleteProductImageAsync(id);
            return Ok("Urun gorselleri basariyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductImage(
            UpdateProductImageDto updateProductImageDto
        )
        {
            await _productImageService.UpdateProductImageAsync(updateProductImageDto);
            return Ok("Urun gorselleri basariyla guncellendi");
        }
    }
}
