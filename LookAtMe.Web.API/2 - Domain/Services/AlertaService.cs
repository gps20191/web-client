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

        public void AtualizarAlerta(Alerta novoAlerta)
        {
            AlertRepository.Edit(novoAlerta);
            AlertRepository.Save();
        }

        public void CancelarAlerta(Alerta alerta)
        {
            alerta.Estado = "Cancelado";
            AlertRepository.Edit(alerta);
            AlertRepository.Save();
        }

        public void CriarAlerta(Alerta alerta)
        {
            int s = alerta.SuspeitoId;

            var ultimoAlerta = AlertRepository.GetBy(a => a.SuspeitoId == s && a.Estado != "Fechado").FirstOrDefault();

            if(ultimoAlerta == null)
            {
                AlertRepository.Add(alerta);
            }
            else
            {
                ultimoAlerta.Estado = "Cancelado";                
                AlertRepository.Edit(ultimoAlerta);
                AlertRepository.Add(alerta);
            }

            AlertRepository.Save();
        }

        public void DeletarAlerta(int id)
        {
            AlertRepository.Delete(id);
            AlertRepository.Save();
        }

        public Alerta GetAlertaById(int id)
        {
            var alerta = AlertRepository.GetBy(a => a.Id == id).FirstOrDefault();
            return alerta;
        }

        public List<Alerta> GetAlertas()
        {
            return AlertRepository.GetAll().ToList();
        }

        public async Task<ICollection<Alerta>> GetAlertasAsync()
        {
            var alertas = await AlertRepository.GetAllAsync();
            return alertas;
        }

        public Task<List<Alerta>> GetAlertasByEstadoAsync(string estado)
        {
            if(estado == "Aberto")
            {
                return AlertRepository.GetAlertasAbertoAsync();
            }
            else if(estado == "Em Andamento")
            {
                return AlertRepository.GetAlertasEmAndamentoAsync();
            }
            else if(estado == "Fechado")
            {
                return AlertRepository.GetAlertasFechadoAsync();
            }
            else if(estado == "Cancelado")
            {
                return AlertRepository.GetAlertasCanceladosAsync();
            }
            else
            {
                throw new ArgumentException("Argumento Inválido");
            }
        }

        public List<Alerta> GetAlertasByIdSuspeito(int idSuspeito)
        {
            var alerta = AlertRepository.GetBy(a => a.SuspeitoId == idSuspeito).ToList();
            return alerta;
        }        
    }
}
