using System;
using Toro.Application.Models.Request;
using Toro.Application.Models.Response;

namespace Toro.Application.Interfaces
{
	public interface IAccountService
	{
        Task<IEnumerable<AccountResponse>> GetAll(AccountRequestGetAll filters, CancellationToken cancellationToken);
        Task<AccountResponse> GetId(int id, CancellationToken cancellationToken);
    }
}

