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
    public class RemoveOrderingCommandHandler : IRequestHandler<RemoveOrderingCommand>
    {
        private readonly IRepository<Ordering> _repository;

        public RemoveOrderingCommandHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(
            RemoveOrderingCommand request,
            CancellationToken cancellationToken
        )
        {
            var values = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(values);
            return Unit.Value;
        }
    }
}
