using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeStation.Catalog.Dtos.ProductImageDtos
{
    public class ResultProductImageDto
    {
         public string? ProductImageID { get; set; }

        public string? Image1 { get; set; }

        public string? Image2 { get; set; }

        public string? Image3 { get; set; }

        public string? ProductId { get; set; }
    }
}