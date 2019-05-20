using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LookAtMe.Web.API.Data.Context;
using LookAtMe.Web.API.Domain.Model;
using LookAtMe.Web.API.Domain.Services;
using LookAtMe.Web.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace LookAtMe.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertaController : ControllerBase
    {
        public readonly IAlertaService alertaService;

        public AlertaController(IAlertaService alertaService)
        {
            this.alertaService = alertaService;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Alerta>> GetAsync()
        {           
            return await alertaService.GetAlertas();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<int> PostAsync([FromBody] Alerta value)
        {
            return await alertaService.CriarAlertaAsync(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Alerta value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<int> DeleteAsync(int id)
        {
            return await alertaService.DeletarAlertaAsync(id);
        }
    }
}
