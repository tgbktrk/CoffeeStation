using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeStation.Catalog.Dtos.ProductDetailDtos
{
    public class UpdateProductDetailDto
    {
        public string? ProductDetailId { get; set; }

        public string? ProductDescription { get; set; }

        public string? ProductInfo { get; set; }

        public string? ProductId { get; set; }
    }
}