using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeStation.Order.Application.Features.CQRS.Results.AddressResults;
using CoffeeStation.Order.Application.Interfaces;
using CoffeeStation.Order.Domain.Entities;

namespace CoffeeStation.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressQueryHandler
    {
        private readonly IRepository<Address> _repository;

        public GetAddressQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAddressQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values
                .Select(x => new GetAddressQueryResult
                {
                    AddressId = x.AddressId,
                    City = x.City,
                    Detail = x.Detail,
                    District = x.District,
                    UserId = x.UserId,
                })
                .ToList();
        }
    }
}
