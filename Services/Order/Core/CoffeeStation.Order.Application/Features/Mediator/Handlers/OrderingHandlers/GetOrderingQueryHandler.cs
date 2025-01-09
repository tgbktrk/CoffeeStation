using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeStation.Order.Application.Features.Mediator.Queries.OrderingQueries;
using CoffeeStation.Order.Application.Features.Mediator.Results.OrderingResults;
using CoffeeStation.Order.Application.Interfaces;
using CoffeeStation.Order.Domain.Entities;
using MediatR;

namespace CoffeeStation.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
    public class GetOrderingQueryHandler
        : IRequestHandler<GetOrderingQuery, List<GetOrderingQueryResult>>
    {
        private readonly IRepository<Ordering> _repository;

        public GetOrderingQueryHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetOrderingQueryResult>> Handle(
            GetOrderingQuery request,
            CancellationToken cancellationToken
        )
        {
            var values = await _repository.GetAllAsync();
            return values
                .Select(x => new GetOrderingQueryResult
                {
                    OrderingId = x.OrderingId,
                    OrderDate = x.OrderDate,
                    TotalPrice = x.TotalPrice,
                    UserId = x.UserId,
                })
                .ToList();
        }
    }
}
