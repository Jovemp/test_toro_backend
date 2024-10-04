using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using Toro.API.Controllers.Base;
using Toro.Application.Interfaces;
using Toro.Application.Models.Request;

namespace Toro.API.Controllers
{
    [Route("api/bonds")]
    public class BondController : MainController
    {
        private readonly IBondService _bondService;

        public BondController(IBondService bondService)
        {
            _bondService = bondService;
        }

        /// <summary>
        ///  Metodo responsavel para retornar os produtos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetAll([FromQuery] BondRequestGetAll filterParams, CancellationToken cancellationToken)
        {
            return CustomResponse(await _bondService.GetAllBond(filterParams, cancellationToken));
        }

        /// <summary>
        ///  Metodo responsavel para retornar o produto com o id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            return CustomResponse(await _bondService.GetById(id, cancellationToken));
        }
    }
}

