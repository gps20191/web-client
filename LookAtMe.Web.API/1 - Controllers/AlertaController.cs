using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LookAtMe.Web.API.Data.Context;
using LookAtMe.Web.API.Domain.Model;
using LookAtMe.Web.API.Domain.Interfaces;
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
            return await alertaService.GetAlertasAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Alerta> Get(int id)
        {
            return alertaService.GetAlertaById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Alerta value)
        {
            alertaService.CriarAlerta(value);
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody] Alerta value)
        {
            alertaService.AtualizarAlerta(value);
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete([FromBody] Alerta value)
        {
            alertaService.DeletarAlerta(value);
        }
    }
}
