using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeStation.Discount.Dtos;
using CoffeeStation.Discount.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeStation.Discount.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet]
        public async Task<IActionResult> DiscountCouponList()
        {
            var values = await _discountService.GetAllDiscountCouponAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscountCouponById(int id)
        {
            var values = await _discountService.GetByIdDiscountCouponAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscountCoupon(
            CreateDiscountCouponDto createCouponDto
        )
        {
            await _discountService.CreateDiscountCouponAsync(createCouponDto);
            return Ok("Kupon basariyla olusturuldu");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDiscountCoupon(int id)
        {
            await _discountService.DeleteDiscountCouponAsync(id);
            return Ok("Kupon basariyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCoupon(
            UpdateDiscountCouponDto updateCouponDto
        )
        {
            await _discountService.UpdateDiscountCouponAsync(updateCouponDto);
            return Ok("Kupon basariyla guncellendi");
        }
    }
}
