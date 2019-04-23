using LookAtMe.Web.API.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Web.API.Domain.Repository
{
    public class AlertaRepository : BaseRepository<AlertaViewModel>, IAlertaRepository
    {
        public override Task<AlertaViewModel> AddAsync(AlertaViewModel obj)
        {
            throw new NotImplementedException();
        }

        public override Task<AlertaViewModel> EditAsync(AlertaViewModel obj)
        {
            throw new NotImplementedException();
        }

        public override Task<AlertaViewModel> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<AlertaViewModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AlertaViewModel> GetResolvidosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
