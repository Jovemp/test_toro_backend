using System;
using Toro.Application.Models.Request;
using Toro.Application.Models.Response;

namespace Toro.Application.Interfaces
{
	public interface IMessageSenderService
	{
        Task<OperationResponse> CreateOrder(OrderRequestCreate orderRequestCreate);
        Task<OperationResponse> ProcessOrder(ProcessOrderRequest processOrder);
    }
}

