﻿using LookAtMe.Web.API.Domain.Model;
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

        void AtualizarAlerta(Alerta novoAlerta);

        void DeletarAlerta(int alerta);

        Alerta GetAlertaById(int id);

        List<Alerta> GetAlertas();

        List<Alerta> GetAlertasByIdSuspeito(int idSuspeito);

        Task<List<Alerta>> GetAlertasByEstadoAsync(string estado);

        Task<ICollection<Alerta>> GetAlertasAsync();
    }
}
