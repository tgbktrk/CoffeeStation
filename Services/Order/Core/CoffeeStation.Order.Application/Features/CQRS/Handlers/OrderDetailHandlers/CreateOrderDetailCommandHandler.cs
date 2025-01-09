using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeStation.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using CoffeeStation.Order.Application.Interfaces;
using CoffeeStation.Order.Domain.Entities;

namespace CoffeeStation.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class CreateOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateOrderDetailCommand command)
        {
            await _repository.CreateAsync(
                new OrderDetail
                {
                    ProductAmount = command.ProductAmount,
                    OrderingId = command.OrderingId,
                    ProductId = command.ProductId,
                    ProductName = command.ProductName,
                    ProductTotalPrice = command.ProductTotalPrice,
                }
            );
        }
    }
}
