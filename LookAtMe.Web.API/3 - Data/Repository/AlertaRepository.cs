using LookAtMe.Web.API.Data.Context;
using LookAtMe.Web.API.Data.Interfaces;
using LookAtMe.Web.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Web.API.Data.Repository
{
    public class AlertaRepository : BaseRepository<Alerta>, IAlertaRepository
    {
        public AlertaRepository(AppDbContext context) : base(context)
        {

        }              

        public Task<List<Alerta>> GetAlertasAbertoAsync()
        {
            var alertas = _context.Alertas.AsQueryable().Where(a => a.Estado == "Aberto").ToListAsync();
            return alertas;
        }

        public Task<List<Alerta>> GetAlertasEmAndamentoAsync()
        {
            var alertas = _context.Alertas.AsQueryable().Where(a => a.Estado == "Em Andamento").ToListAsync();
            return alertas;
        }

        public Task<List<Alerta>> GetAlertasFechadoAsync()
        {
            var alertas = _context.Alertas.AsQueryable().Where(a => a.Estado == "Fechado").ToListAsync();
            return alertas;
        }

        public Task<List<Alerta>> GetAlertasSuspeitoCapturadoAsync()
        {
            var alertas = _context.Alertas.AsQueryable().Where(a => a.Capturado == true).ToListAsync();
            return alertas;
        }
    }
}
