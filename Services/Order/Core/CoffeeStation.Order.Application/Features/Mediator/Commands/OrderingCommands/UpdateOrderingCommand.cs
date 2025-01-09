using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CoffeeStation.Order.Application.Features.Mediator.Commands.OrderingCommands
{
    public class UpdateOrderingCommand : IRequest
    {
        public int OrderingId { get; set; }

        public string UserId { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
