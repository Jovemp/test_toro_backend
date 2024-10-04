using System;
using MassTransit;
using Newtonsoft.Json;
using Toro.Application.Interfaces;
using Toro.Application.Models.Request;
using Toro.Application.Models.Response;
using static MassTransit.Monitoring.Performance.BuiltInCounters;

namespace Toro.Application.RabbitMQ.Services
{
    public class MessageSenderService : IMessageSenderService
    {
        private readonly ISendEndpointProvider _sendEndpointProvider;

        public MessageSenderService(ISendEndpointProvider sendEndpointProvider)
        {
            _sendEndpointProvider = sendEndpointProvider;
        }

        public async Task<OperationResponse> CreateOrder(OrderRequestCreate orderRequestCreate)
        {
            try
            {

                var endpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri("queue:create_order"));

                // Enviar a mensagem para a fila
                await endpoint.Send(orderRequestCreate);

                // Retorna uma confirmação de sucesso
                return new OperationResponse
                {
                    Success = true,
                    Message = "Order successfully sent to queue."
                };
            }
            catch (Exception ex)
            {

                // Retorna uma confirmação de falha
                return new OperationResponse
                {
                    Success = false,
                    Message = $"Error while creating order: {ex.Message}"
                };
            }
        }

        public async Task<OperationResponse> ProcessOrder(ProcessOrderRequest processOrder)
        {
            try
            {

                var endpoint = await _sendEndpointProvider.GetSendEndpoint(new Uri("queue:process_order"));

                // Enviar a mensagem para a fila
                await endpoint.Send(processOrder);

                // Retorna uma confirmação de sucesso
                return new OperationResponse
                {
                    Success = true,
                    Message = "Order successfully sent to the processing queue."
                };
            }
            catch (Exception ex)
            {

                // Retorna uma confirmação de falha
                return new OperationResponse
                {
                    Success = false,
                    Message = $"Error while processing order: {ex.Message}"
                };
            }
        }
    }
}

