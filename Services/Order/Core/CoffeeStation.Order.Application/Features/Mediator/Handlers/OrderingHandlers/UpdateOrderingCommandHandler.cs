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
    public class UpdateOrderingCommandHandler : IRequestHandler<UpdateOrderingCommand>
    {
        private readonly IRepository<Ordering> _repository;

        public UpdateOrderingCommandHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(
            UpdateOrderingCommand request,
            CancellationToken cancellationToken
        )
        {
            var values = await _repository.GetByIdAsync(request.OrderingId);
            values.OrderDate = request.OrderDate;
            values.UserId = request.UserId;
            values.TotalPrice = request.TotalPrice;
            await _repository.UpdateAsync(values);
            return Unit.Value;
        }
    }
}
