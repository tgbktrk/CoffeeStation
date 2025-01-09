using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeStation.Catalog.Dtos.ProductDetailDtos;

namespace CoffeeStation.Catalog.Services.ProductDetailServices
{
    public interface IProductDetailService
    {
        Task<List<ResultProductDetailDto>> GetAllProductDetailAsync();

        Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto);

        Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto);

        //id'yi int değil string yazmalıyız
        Task DeleteProductDetailAsync(string id);

        Task<GetByIdProductDetailDto> GetByIdProductDetailAsync(string id);
    }
}