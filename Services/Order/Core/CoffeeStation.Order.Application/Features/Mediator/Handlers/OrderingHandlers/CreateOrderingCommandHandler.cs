using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeStation.Order.Application.Features.Mediator.Commands.OrderingCommands;
using CoffeeStation.Order.Application.Interfaces;
using CoffeeStation.Order.Domain.Entities;
using MediatR;

namespace CoffeeStation.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
    public class CreateOrderingCommandHandler : IRequestHandler<CreateOrderingCommand>
    {
        private readonly IRepository<Ordering> _repository;

        public CreateOrderingCommandHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(
            CreateOrderingCommand request,
            CancellationToken cancellationToken
        )
        {
            await _repository.CreateAsync(
                new Ordering
                {
                    OrderDate = request.OrderDate,
                    TotalPrice = request.TotalPrice,
                    UserId = request.UserId,
                }
            );
            return Unit.Value;
        }
    }
}
