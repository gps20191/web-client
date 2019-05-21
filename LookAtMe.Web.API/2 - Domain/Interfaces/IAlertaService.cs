using LookAtMe.Web.API.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Web.API.Domain.Interfaces
{
    public interface IAlertaService
    {
        void CriarAlerta(Alerta alerta);

        void CancelarAlerta(Alerta alerta);

        void MudarEstado(Alerta novoAlerta);

        void DeletarAlerta(Alerta alerta);

        Task<ICollection<Alerta>> GetAlertas();
    }
}
