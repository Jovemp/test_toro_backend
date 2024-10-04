using System;
using Microsoft.AspNetCore.Mvc;
using Toro.API.Controllers.Base;
using Toro.Application.Interfaces;
using Toro.Application.Models.Request;

namespace Toro.API.Controllers
{
    [Route("api/orders")]
    public class OrderController : MainController
    {
        private readonly IMessageSenderService _messageSender;
        private readonly IOrderService _orderService;

        public OrderController(IMessageSenderService messageSender, IOrderService orderService)
		{
            _messageSender = messageSender;
            _orderService = orderService;
		}

        /// <summary>
        ///  Metodo responsavel para criar uma order  
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> CreateOrder([FromBody] OrderRequestCreate body)
        {
            return CustomResponse(await _messageSender.CreateOrder(body));
        }

        /// <summary>
        ///  Metodo por obter a order do accountId 
        /// </summary>
        /// <returns></returns>
        [HttpGet("account/{accountId}")]
        public async Task<ActionResult> GetAllOrder(int accountId, [FromQuery] OrderRequestGetAll filter, CancellationToken cancellationToken)
        {
            return CustomResponse(await _orderService.GetAll(accountId, filter, cancellationToken));
        }


    }
}

