using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CoffeeStation.Catalog.Dtos.CategoryDtos;
using CoffeeStation.Catalog.Dtos.ProductDetailDtos;
using CoffeeStation.Catalog.Dtos.ProductDtos;
using CoffeeStation.Catalog.Dtos.ProductImageDtos;
using CoffeeStation.Catalog.Entities;

namespace CoffeeStation.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        //Map'leme işlemi ctor içinde gerçekleşir
        public GeneralMapping()
        {
            //Category ile ResultCategoryDto eşleştirelecek reversemap ile tam tersi eşleme de olabilir
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDto>().ReverseMap();

            CreateMap<ProductDetail, ResultProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, CreateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, UpdateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, GetByIdProductDetailDto>().ReverseMap();

            CreateMap<ProductImage, ResultProductImageDto>().ReverseMap();
            CreateMap<ProductImage, CreateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, UpdateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, GetByIdProductImageDto>().ReverseMap();
        }
    }
}