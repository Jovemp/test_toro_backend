using System;
using System.Linq.Expressions;
using Toro.Domain.Entities;

namespace Toro.Application.Service.Base
{
	public abstract class ServiceBase<T>
	{

        protected Expression<Func<T, bool>> CreateFilterExpression(string field, string value)
        {
            var parameter = Expression.Parameter(typeof(T), "x");
            var member = Expression.Property(parameter, field);

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
                convertedValue = value; 
            }

            var constant = Expression.Constant(convertedValue, member.Type);

            var body = Expression.Equal(member, constant);

            return Expression.Lambda<Func<T, bool>>(body, parameter);
        }


        protected Func<IQueryable<T>, IOrderedQueryable<T>> CreateOrderByExpression(string field, bool descending)
        {
            var parameter = Expression.Parameter(typeof(T), "x");
            var member = Expression.Property(parameter, field);
            var keySelector = Expression.Lambda<Func<T, object>>(Expression.Convert(member, typeof(object)), parameter);

            if (descending)
            {
                return query => query.OrderByDescending(keySelector);
            }
            return query => query.OrderBy(keySelector);
        }
    }
}

