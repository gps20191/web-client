using LookAtMe.Web.API.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Web.API.Domain.Services
{
    public interface IAlertaService
    {
        Task<int> CriarAlertaAsync(Alerta alerta);

        Task<ICollection<Alerta>> GetAlertas();

        Task<int> DeletarAlertaAsync(int id);
    }
}
