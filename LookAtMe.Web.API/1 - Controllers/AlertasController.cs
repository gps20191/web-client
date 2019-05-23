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
    public class AlertasController : ControllerBase
    {
        public readonly IAlertaService alertaService;

        public AlertasController(IAlertaService alertaService)
        {
            this.alertaService = alertaService;
        }

        [HttpGet("suspeito/{id}")]
        public ActionResult<ICollection<Alerta>> GetBySuspeitoId(int id)
        {
            return alertaService.GetAlertasByIdSuspeito(id);
        }

        [Route("Aberto")]
        [HttpGet]
        public async Task<IEnumerable<Alerta>> GetAlertasAbertoAsync()
        {
            string estado = "Aberto";
            return await alertaService.GetAlertasByEstadoAsync(estado);
        }

        [Route("Andamento")]
        [HttpGet]
        public async Task<IEnumerable<Alerta>> GetAlertasEmAndamentoAsync()
        {
            string estado = "Em Andamento";
            return await alertaService.GetAlertasByEstadoAsync(estado);
        }

        [Route("Fechado")]
        [HttpGet]
        public async Task<IEnumerable<Alerta>> GetAlertasFechadoAsync()
        {
            string estado = "Fechado";
            return await alertaService.GetAlertasByEstadoAsync(estado);
        }

        [Route("Cancelado")]
        [HttpGet]
        public async Task<IEnumerable<Alerta>> GetAlertasCanceladoAsync()
        {
            string estado = "Cancelado";
            return await alertaService.GetAlertasByEstadoAsync(estado);
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
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            alertaService.DeletarAlerta(id);
        }
    }
}
