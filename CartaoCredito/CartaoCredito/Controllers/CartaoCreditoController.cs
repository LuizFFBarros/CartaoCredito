using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CartaoCredito.Extension;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CartaoCredito.Controllers
{
    [Route("api/CartaoCredito")]
    [ApiController]
    public class CartaoCreditoController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();
        public CartaoCreditoController()
        {
            client.BaseAddress = new System.Uri(@"https://localhost:5001/");
        }
        [Route("cartao/compra")]
        [HttpPost]
        public ActionResult<IEnumerable<string>> RealizarTransacao([FromQuery] Cartao cartao)
        {
            ValidarCartao(cartao);
            //Transacao efetuada...
            return Ok("Transação efetuada com sucesso.");
        }

        

        private void ValidarCartao(Cartao cartao)
        {
            if (cartao.CodigoVerificador == default(int) || cartao.Numerocartao == default(int))
                throw new ArgumentException("Preencha os dados do Cartao!");
        }
    }

    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
    }
    public class Cartao {
        public int Numerocartao { get; set; }
        public int CodigoVerificador { get; set; }
    }
}