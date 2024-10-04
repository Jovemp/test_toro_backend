using System;
using System.Linq.Expressions;
using AutoMapper;
using Toro.Application.Interfaces;
using Toro.Application.Models.Request;
using Toro.Application.Models.Response;
using Toro.Application.Service.Base;
using Toro.Domain.Entities;
using Toro.Domain.Repositories;

namespace Toro.Application.Account.Services
{
	public class AccountService : ServiceBase<AccountEntity>, IAccountService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;

        public AccountService(IUow uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<AccountResponse>> GetAll(AccountRequestGetAll filters, CancellationToken cancellationToken)
        {
            Expression<Func<AccountEntity, bool>>? filter = null;
            if (!string.IsNullOrEmpty(filters.FilterField) && !string.IsNullOrEmpty(filters.FilterValue))
            {
                filter = this.CreateFilterExpression(filters.FilterField, filters.FilterValue);
            }


            Func<IQueryable<AccountEntity>, IOrderedQueryable<AccountEntity>>? orderBy = null;
            if (!string.IsNullOrEmpty(filters.SortField))
            {
                orderBy = this.CreateOrderByExpression(filters.SortField, filters.SortDescending);
            }


            var list = await this._uow.AccountRepository.GetFilteredAsync(
                filter: filter,
                orderBy: orderBy,
                pageNumber: filters.PageNumber,
                pageSize: filters.PageSize,
                cancellationToken: cancellationToken);

            return _mapper.Map<IEnumerable<AccountResponse>>(list);
        }

        public async Task<AccountResponse> GetId(int id, CancellationToken cancellationToken)
        {
            var item = await this._uow.AccountRepository.GetAsync(
                a => a.Id == id,
                cancellationToken: cancellationToken);

            return _mapper.Map<AccountResponse>(item);
        }
    }
}

