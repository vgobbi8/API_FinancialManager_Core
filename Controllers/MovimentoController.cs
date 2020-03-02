using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_FinancialManager_Core.Models;

namespace API_FinancialManager_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class MovimentoController : ControllerBase
    {
        [HttpGet]
        [ActionName("Receber")]
        [AcceptVerbs("Get")]
        public MovimentoModel Get()
        {
            MovimentoModel m = new MovimentoModel();
            m.Codigo = 1;
            m.Descricao = "AAA";
            m.Valor = 10;

            return m;
        }

        [HttpPost]
     //   [ActionName("EnvioRetorno")]
        public MovimentoModel Post([FromBody] MovimentoModel value)
        {
            MovimentoModel movimento = new MovimentoModel();
            value.teste();
            return value;
        }

        // PUT: api/Movimento/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
