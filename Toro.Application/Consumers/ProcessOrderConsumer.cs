using System;
using AutoMapper;
using MassTransit;
using Toro.Application.Interfaces;
using Toro.Application.Models.Request;
using Toro.Domain.Repositories;

namespace Toro.Application.Consumers
{
    public class ProcessOrderConsumer: IConsumer<ProcessOrderRequest>
	{
        private readonly IUow _uow;

        public ProcessOrderConsumer(IUow uow)
        {
            _uow = uow;
        }

        public async Task Consume(ConsumeContext<ProcessOrderRequest> context)
        {
            var order = await _uow.OrderRepository.GetAsync(o => o.Id == context.Message.OrderId);

            var bond = await _uow.BondRepository.GetAsync(b => b.Id == order.BondId);

            if (order.Type == Domain.Enums.TypeOrder.BUY)
            {
                if (bond.Stock - order.Quantity < 0)
                {
                    order.Status = Domain.Enums.StatusOrder.CANCELED;
                    _uow.OrderRepository.Update(order);
                    await _uow.CommitAsync();
                    return;
                }
            }

            var account = await _uow.AccountRepository.GetAsync(a => a.Id == order.AccountId);
            if (order.Type == Domain.Enums.TypeOrder.BUY)
            {
                if (account.Balance - (order.Quantity * bond.UnitPrice) < 0)
                {
                    order.Status = Domain.Enums.StatusOrder.CANCELED;
                    _uow.OrderRepository.Update(order);
                    await _uow.CommitAsync();
                    return;
                }
            }

            if (order.Type == Domain.Enums.TypeOrder.BUY)
            {
                bond.Stock = bond.Stock - order.Quantity;
                account.Balance = account.Balance - (order.Quantity * bond.UnitPrice);
            } else
            {
                bond.Stock = bond.Stock + order.Quantity;
                account.Balance = account.Balance + (order.Quantity * bond.UnitPrice);
            }

            order.Status = Domain.Enums.StatusOrder.COMPLETED;
            _uow.BondRepository.Update(bond); 
            _uow.AccountRepository.Update(account);
            _uow.OrderRepository.Update(order);
            await _uow.CommitAsync();
        }
    }
}

