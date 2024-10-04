using System;
using AutoMapper;
using MassTransit;
using Microsoft.Extensions.Logging;
using Toro.Application.Interfaces;
using Toro.Application.Models.Request;
using Toro.Domain.Entities;
using Toro.Domain.Repositories;

namespace Toro.Application.Consumers
{
	public class OrderCreateConsumer : IConsumer<OrderRequestCreate>
	{
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        private readonly IMessageSenderService _messageSender;

        public OrderCreateConsumer(IUow uow, IMapper mapper, IMessageSenderService messageSender)
		{
            _uow = uow;
            _mapper = mapper;
            _messageSender = messageSender;
        }

        public async Task Consume(ConsumeContext<OrderRequestCreate> context)
        {
            try
            {
                Console.WriteLine("Create Order");

                var orderEntity = _mapper.Map<OrderEntity>(context.Message);

                orderEntity.Date = DateTime.Now;
                orderEntity.Status = Domain.Enums.StatusOrder.WAITING;

                await _uow.OrderRepository.AddAsync(orderEntity);

                await _uow.CommitAsync();

                await _messageSender.ProcessOrder(new ProcessOrderRequest
                {
                    OrderId = orderEntity.Id
                });

                Console.WriteLine("Successfully created!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error processing order creation: {MessageId}", context.MessageId);
            }
        }
    }
}

