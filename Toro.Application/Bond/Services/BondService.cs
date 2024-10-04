using System;
using System.Linq.Expressions;
using System.Threading;
using AutoMapper;
using Toro.Application.Interfaces;
using Toro.Application.Models.Request;
using Toro.Application.Models.Response;
using Toro.Application.Service.Base;
using Toro.Domain.Entities;
using Toro.Domain.Entities.Base;
using Toro.Domain.Repositories;

namespace Toro.Application.Bond.Services
{
	public class BondService: ServiceBase<BondEntity>, IBondService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;

		public BondService(IUow uow, IMapper mapper)
		{
            this._uow = uow;
            this._mapper = mapper;
		}

        public async Task<PagedResult<BondResponse>> GetAllBond(BondRequestGetAll filters, CancellationToken cancellationToken)
        {

            Expression<Func<BondEntity, bool>>? filter = null;
            if (!string.IsNullOrEmpty(filters.FilterField) && !string.IsNullOrEmpty(filters.FilterValue))
            {
                filter = this.CreateFilterExpression(filters.FilterField, filters.FilterValue);
            }


            Func<IQueryable<BondEntity>, IOrderedQueryable<BondEntity>>? orderBy = null;
            if (!string.IsNullOrEmpty(filters.SortField))
            {
                orderBy = this.CreateOrderByExpression(filters.SortField, filters.SortDescending);
            }


            var list =  await this._uow.BondRepository.GetFilteredAsync(
                filter: filter,
                orderBy: orderBy,
                pageNumber: filters.PageNumber,
                pageSize: filters.PageSize,
                cancellationToken: cancellationToken);

            return _mapper.Map<PagedResult<BondResponse>>(list);
        }

        public async Task<BondResponse> GetById(int id, CancellationToken cancellationToken)
        {
            var bond = await _uow.BondRepository.GetAsync(a => a.Id == id);
            return _mapper.Map<BondResponse>(bond);
        }
    }
}

