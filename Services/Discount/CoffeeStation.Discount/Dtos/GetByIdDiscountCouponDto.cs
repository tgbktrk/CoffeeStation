using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeStation.Discount.Dtos
{
    public class GetByIdDiscountCouponDto
    {
        public int CouponId { get; set; }

        public string? Code { get; set; }

        public int Rate { get; set; }

        public bool IsActive { get; set; }

        public DateTime ValidDate { get; set; }
    }
}