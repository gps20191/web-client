using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LookAtMe.Web.API.Domain.Model;

namespace LookAtMe.Web.API.Domain.Repository
{
    interface IAlertaRepository
    {
        Task<AlertaViewModel> GetResolvidosAsync();
    }
}
