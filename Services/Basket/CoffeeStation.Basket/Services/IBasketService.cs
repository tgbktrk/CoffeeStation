using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeStation.Basket.Dtos;

namespace CoffeeStation.Basket.Services
{
    public interface IBasketService
    {
        Task<BasketTotalDto> GetBasket(string userId);

        Task SaveBasket(BasketTotalDto basketTotalDto);

        Task DeleteBasket(string userId);
    }
}
