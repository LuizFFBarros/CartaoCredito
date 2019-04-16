using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CartaoCredito.Controllers
{
    [Route("api/CartaoCredito")]
    [ApiController]
    public class CartaoCreditoController : ControllerBase
    {

        [Route("cartao")]
        [HttpGet]
        public ActionResult<IEnumerable<string>> ValidarCartao([FromQuery] string dadosCartao)
        {
            return Ok();
        }

        [Route("cartao/compra")]
        [HttpPost]
        public ActionResult<IEnumerable<string>> RealizarTransacao([FromQuery] string dadosCartao)
        {
            return Ok();
        }

    }
}