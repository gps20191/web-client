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
            alerta.Estado = "Fechado";
            AlertRepository.Edit(alerta);
            AlertRepository.Save();
        }

        public void CriarAlerta(Alerta alerta)
        {
            Suspeito s = alerta.Suspeito;

            var ultimoAlerta = AlertRepository.GetBy(a => a.Suspeito == s && a.Estado != "Fechado").FirstOrDefault();

            if(ultimoAlerta == null)
            {
                AlertRepository.Add(alerta);
            }
            else
            {
                ultimoAlerta.Estado = "Fechado";
                AlertRepository.Edit(ultimoAlerta);
            }

            AlertRepository.Save();            
        }

        public void DeletarAlerta(Alerta alerta)
        {
            AlertRepository.Delete(alerta);
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
            else
            {
                throw new ArgumentException("Argumento Inválido");
            }
        }

        public List<Alerta> GetAlertasBySuspeito(Suspeito suspeito)
        {
            var alerta = AlertRepository.GetBy(a => a.Suspeito == suspeito).ToList();
            return alerta;
        }        
    }
}
