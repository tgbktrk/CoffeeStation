using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeStation.Catalog.Dtos.ProductDetailDtos;
using CoffeeStation.Catalog.Services.ProductDetailServices;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeStation.Catalog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductDetailsController : ControllerBase
    {
        private readonly IProductDetailService _productDetailService;

        public ProductDetailsController(IProductDetailService productDetailService)
        {
            _productDetailService = productDetailService;
        }

        [HttpGet]
        public async Task<IActionResult> ProductDetailList()
        {
            var values = await _productDetailService.GetAllProductDetailAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductDetailById(string id)
        {
            var values = await _productDetailService.GetByIdProductDetailAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductDetail(
            CreateProductDetailDto createProductDetailDto
        )
        {
            await _productDetailService.CreateProductDetailAsync(createProductDetailDto);
            return Ok("Urun detayi basariyla eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProductDetail(string id)
        {
            await _productDetailService.DeleteProductDetailAsync(id);
            return Ok("Urun detayi basariyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductDetail(
            UpdateProductDetailDto updateProductDetailDto
        )
        {
            await _productDetailService.UpdateProductDetailAsync(updateProductDetailDto);
            return Ok("Urun detayi basariyla guncellendi");
        }
    }
}
