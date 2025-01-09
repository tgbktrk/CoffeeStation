using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CoffeeStation.Order.Application.Features.Mediator.Commands.OrderingCommands
{
    public class CreateOrderingCommand : IRequest
    {
        public string UserId { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
