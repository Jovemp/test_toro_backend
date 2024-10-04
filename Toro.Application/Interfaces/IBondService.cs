using System;
using System.Threading;
using Toro.Application.Models.Request;
using Toro.Application.Models.Response;
using Toro.Domain.Entities.Base;

namespace Toro.Application.Interfaces
{
	public interface IBondService
	{
        Task<PagedResult<BondResponse>> GetAllBond(BondRequestGetAll filters, CancellationToken cancellationToken);
        Task<BondResponse> GetById(int id, CancellationToken cancellationToken);
    }
}

