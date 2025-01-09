using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeStation.Discount.Dtos;

namespace CoffeeStation.Discount.Services
{
    public interface IDiscountService
    {
        Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponAsync();

        Task CreateDiscountCouponAsync(CreateDiscountCouponDto createCouponDto);

        Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateCouponDto);

        Task DeleteDiscountCouponAsync(int id);

        Task<GetByIdDiscountCouponDto> GetByIdDiscountCouponAsync(int id);
    }
}