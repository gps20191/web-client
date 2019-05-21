using LookAtMe.Web.API.Domain.Model;
using LookAtMe.Web.API.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LookAtMe.Web.API.Data.Interfaces;

namespace LookAtMe.Web.API.Services
{
    public class AlertaService : IAlertaService
    {
        public readonly IAlertaRepository AlertRepository;

        public AlertaService(IAlertaRepository alertRepository)
        {
            this.AlertRepository = alertRepository;
        }

        public Task<int> CriarAlertaAsync(Alerta alerta)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeletarAlertaAsync(int id)
        {
            throw new NotImplementedException();
        }

        //public async Task<int> CriarAlertaAsync(Alerta alerta)
        //{
        //    //Verificar se o alerta pro suspeito já existe, caso exista, então deve alterar apenas a localização e a linha do ônibus
        //    Alerta obj = await AlertRepository.GetAlertaBySuspeitoAsync(alerta.Suspeito);

        //    int id = 0;

        //    if (obj != null && !string.Equals(obj.Estado,"Fechado")) id = await AlertRepository.EditAsync(alerta);
        //    else
        //    {
        //        id = await AlertRepository.AddAsync(alerta);                
        //    }

        //    return id;
        //}

        public async Task<ICollection<Alerta>> GetAlertas()
        {
            var x = await AlertRepository.GetAllAsync();
            return x;
        }

        //public async Task<int> DeletarAlertaAsync(int id)
        //{
        //    var x = await AlertRepository.DeleteAsync(id);
        //    return x;
        //}

        //public async Task<Alerta> ConcluirAlertaAsync(int id)
        //{
        //    Alerta obj = await AlertRepository.GetByIdAsync(id);

        //    obj.

        //    return null;
        //}
    }
}
