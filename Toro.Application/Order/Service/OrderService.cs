using System;
using System.Linq.Expressions;
using AutoMapper;
using Toro.Application.Interfaces;
using Toro.Application.Models.Request;
using Toro.Application.Models.Response;
using Toro.Application.Service.Base;
using Toro.Domain.Entities;
using Toro.Domain.Entities.Base;
using Toro.Domain.Repositories;

namespace Toro.Application.Order.Service
{
	public class OrderService : ServiceBase<OrderEntity>, IOrderService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;

        public OrderService(IUow uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public async Task<PagedResult<OrderResponse>> GetAll(int AccountId, OrderRequestGetAll filters, CancellationToken cancellationToken)
        {
            Expression<Func<OrderEntity, bool>>? filter = null;
            if (!string.IsNullOrEmpty(filters.FilterField) && !string.IsNullOrEmpty(filters.FilterValue))
            {
                filter = this.CreateFilterExpression(filters.FilterField, filters.FilterValue, AccountId);
            } else
            {
                filter = this.CreateFilterExpression("AccountId", AccountId.ToString());
            }

            Func<IQueryable<OrderEntity>, IOrderedQueryable<OrderEntity>>? orderBy = null;
            if (!string.IsNullOrEmpty(filters.SortField))
            {
                orderBy = this.CreateOrderByExpression(filters.SortField, filters.SortDescending);
            }


            var list = await this._uow.OrderRepository.GetFilteredAsync(
                filter: filter,
                orderBy: orderBy,
                includes: new Expression<Func<OrderEntity, object>>[]
                {
                    x => x.Account,
                    x => x.Bond
                },
                pageNumber: filters.PageNumber,
                pageSize: filters.PageSize,
                cancellationToken: cancellationToken);

            return _mapper.Map<PagedResult<OrderResponse>>(list);
        }

        protected Expression<Func<OrderEntity, bool>> CreateFilterExpression(string field, string value, int accountId)
        {
            var parameter = Expression.Parameter(typeof(OrderEntity), "x");

            // Filtro dinâmico baseado no campo e valor recebidos
            var member = Expression.Property(parameter, field);

            // Se o campo for AccountId ou outro tipo numérico, converta o valor

            object convertedValue;
            if (member.Type.IsEnum)
            {
                convertedValue = Enum.Parse(member.Type, value); // Converte a string para o enum
            }
            else if (member.Type == typeof(int) || member.Type == typeof(int?))
            {
                convertedValue = int.Parse(value);
            }
            else if (member.Type == typeof(decimal) || member.Type == typeof(decimal?))
            {
                convertedValue = decimal.Parse(value);
            }
            else if (member.Type == typeof(bool) || member.Type == typeof(bool?))
            {
                convertedValue = bool.Parse(value);
            }
            else if (member.Type == typeof(DateTime) || member.Type == typeof(DateTime?))
            {
                convertedValue = DateTime.Parse(value);
            }
            else
            {
                convertedValue = value; // Se for string, não precisa converter
            }
            Expression fieldFilter;
            var constant = Expression.Constant(convertedValue, member.Type);
            fieldFilter = Expression.Equal(member, constant);

            // Filtro fixo de AccountId == accountId (AccountId é um int? ou int)
            var accountMember = Expression.Property(parameter, "AccountId");
            var accountConstant = Expression.Constant(accountId, accountMember.Type);
            var accountFilter = Expression.Equal(accountMember, accountConstant);

            // Combinar ambos os filtros (filtro de campo e filtro de AccountId)
            var combinedFilter = Expression.AndAlso(fieldFilter, accountFilter);

            return Expression.Lambda<Func<OrderEntity, bool>>(combinedFilter, parameter);
        }

    }
}

