using System;
using Toro.Application.Models.Request;
using Toro.Application.Models.Response;
using Toro.Domain.Entities.Base;

namespace Toro.Application.Interfaces
{
	public interface IOrderService
	{
        Task<PagedResult<OrderResponse>> GetAll(int AccountId, OrderRequestGetAll filters, CancellationToken cancellationToken);
    }
}

