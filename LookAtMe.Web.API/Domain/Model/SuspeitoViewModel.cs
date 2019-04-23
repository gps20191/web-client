using System.Collections.Generic;

namespace LookAtMe.Web.API.Domain.Model
{
    public class SuspeitoViewModel
    {
        public int Id { get; set; }
        public byte[] Foto { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public ICollection<OcorrenciaViewModel> Ocorrencias { get; set; }
    }
}