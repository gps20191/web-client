using LookAtMe.Web.API.Data.Context;
using LookAtMe.Web.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Web.API.Domain.Repository
{
    public class AlertaRepository : BaseRepository<Alerta>, IAlertaRepository
    {
        public AlertaRepository(AppDbContext context) : base(context)
        {
        }

        public override async Task<int> AddAsync(Alerta obj)
        {
            var susp = _context.Suspeitos.Add(obj.Suspeito);
            var alert = _context.Alertas.Add(obj);

            int x = await _context.SaveChangesAsync();

            return x;
            
        }

        public override async Task<int> DeleteAsync(int id)
        {
            Alerta x = await _context.Alertas.FirstOrDefaultAsync(obj => obj.Id == id);

            _context.Alertas.Remove(x);

            return await _context.SaveChangesAsync();
        }

        //################## Falta fazer #####################

        public override Task<int> EditAsync(Alerta obj)
        {
            //TODO: Pensar em como editar item
            throw new NotImplementedException();
        }

        //####################################################

        public Task<Alerta> GetAlertaBySuspeitoAsync(Suspeito s)
        {
            var alerta = _context.Alertas.FirstOrDefaultAsync(x => x.Suspeito.Nome == s.Nome);
            return alerta;
        }

        //################## Falta fazer #####################

        public Task<ICollection<Alerta>> GetAlertasAbertoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Alerta>> GetAlertasEmAndamentoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Alerta>> GetAlertasFechadoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Alerta>> GetAlertasSuspeitoCapturadoAsync()
        {
            throw new NotImplementedException();
        }

        //####################################################

        public async override Task<Alerta> GetByIdAsync(int id)
        {
            return await _context.Alertas.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async override Task<ICollection<Alerta>> ListAsync()
        {
            return await _context.Alertas.ToListAsync();
        }
    }
}
