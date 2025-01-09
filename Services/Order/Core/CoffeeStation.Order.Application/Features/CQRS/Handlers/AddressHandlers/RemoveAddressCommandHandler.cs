using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeStation.Order.Application.Features.CQRS.Commands.AddressCommands;
using CoffeeStation.Order.Application.Interfaces;
using CoffeeStation.Order.Domain.Entities;
using static CoffeeStation.Order.Application.Features.CQRS.Commands.AddressCommands.RemoveAddressCommand;

namespace CoffeeStation.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class RemoveAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;

        public RemoveAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAddressCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
