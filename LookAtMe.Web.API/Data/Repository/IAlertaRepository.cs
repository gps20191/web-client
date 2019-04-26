using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LookAtMe.Web.API.Domain.Model;

namespace LookAtMe.Web.API.Domain.Repository
{
    public interface IAlertaRepository : IBaseRepository<Alerta>
    {
        Task<Alerta> GetAlertaBySuspeitoAsync(Suspeito s);
        Task<ICollection<Alerta>> GetAlertasFechadoAsync();
        Task<ICollection<Alerta>> GetAlertasEmAndamentoAsync();
        Task<ICollection<Alerta>> GetAlertasAbertoAsync();
        Task<ICollection<Alerta>> GetAlertasSuspeitoCapturadoAsync();
    }
}
