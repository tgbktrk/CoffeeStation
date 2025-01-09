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
    public class GetOrderingByIdQueryHandler
        : IRequestHandler<GetOrderingByIdQuery, GetOrderingByIdQueryResult>
    {
        private readonly IRepository<Ordering> _repository;

        public GetOrderingByIdQueryHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task<GetOrderingByIdQueryResult> Handle(
            GetOrderingByIdQuery request,
            CancellationToken cancellationToken
        )
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetOrderingByIdQueryResult
            {
                OrderDate = values.OrderDate,
                OrderingId = values.OrderingId,
                TotalPrice = values.TotalPrice,
                UserId = values.UserId,
            };
        }
    }
}
