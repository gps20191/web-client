using LookAtMe.Web.API.Data.Context;
using LookAtMe.Web.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Web.API.Domain.Repository
{
    public class AlertaRepository : BaseRepository<Alerta>, IAlertaRepository
    {
        public AlertaRepository(AppDbContext context) : base(context)
        {

        }              

        public Task<ICollection<Alerta>> GetAlertasAbertoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Alerta>> GetAlertasEmAndamentoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Alerta>> GetAlertasFechadoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Alerta>> GetAlertasSuspeitoCapturadoAsync()
        {
            throw new NotImplementedException();
        }
    }
}
