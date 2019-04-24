using LookAtMe.Web.API.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Web.API.Domain.Repository
{
    public class AlertaRepository : BaseRepository<Alerta>, IAlertaRepository
    {
        public override Task<Alerta> AddAsync(Alerta obj)
        {
            throw new NotImplementedException();
        }

        public override Task<Alerta> EditAsync(Alerta obj)
        {
            throw new NotImplementedException();
        }

        public override Task<Alerta> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<Alerta> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Alerta> GetResolvidosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
