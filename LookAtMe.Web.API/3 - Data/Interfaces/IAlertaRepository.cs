using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LookAtMe.Web.API.Domain.Model;

namespace LookAtMe.Web.API.Data.Interfaces
{
    public interface IAlertaRepository : IBaseRepository<Alerta>
    {
        Task<List<Alerta>> GetAlertasFechadoAsync();
        Task<List<Alerta>> GetAlertasEmAndamentoAsync();
        Task<List<Alerta>> GetAlertasAbertoAsync();
        Task<List<Alerta>> GetAlertasSuspeitoCapturadoAsync();
        Task<List<Alerta>> GetAlertasCanceladosAsync();
    }
}
