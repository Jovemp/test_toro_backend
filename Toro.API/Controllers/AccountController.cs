using System;
using Microsoft.AspNetCore.Mvc;
using Toro.API.Controllers.Base;
using Toro.Application.Interfaces;
using Toro.Application.Models.Request;

namespace Toro.API.Controllers
{
    [Route("api/accounts")]
    public class AccountController : MainController
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
		{
            _accountService = accountService;
		}

        /// <summary>
        ///  Metodo responsavel para retornar os accounts
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetAll([FromQuery] AccountRequestGetAll filterParams, CancellationToken cancellationToken)
        {
            return CustomResponse(await _accountService.GetAll(filterParams, cancellationToken));
        }

        /// <summary>
        ///  Metodo responsavel para retornar account do id 
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult> GetId(int id, CancellationToken cancellationToken)
        {
            return CustomResponse(await _accountService.GetId(id, cancellationToken));
        }
    }
}

