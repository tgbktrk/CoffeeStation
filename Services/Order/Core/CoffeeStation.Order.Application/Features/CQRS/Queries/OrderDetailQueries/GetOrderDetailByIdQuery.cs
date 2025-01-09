using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeStation.Order.Application.Features.CQRS.Queries.OrderDetailQueries
{
    public class GetOrderDetailByIdQuery
    {
        public int Id { get; set; }

        public GetOrderDetailByIdQuery(int id)
        {
            Id = id;
        }
    }
}
