using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeStation.Basket.LoginServices
{
    public interface ILoginService
    {
        public string GetUserId { get; }
    }
}
