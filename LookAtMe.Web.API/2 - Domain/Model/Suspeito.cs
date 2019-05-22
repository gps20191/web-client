using System.Collections.Generic;

namespace LookAtMe.Web.API.Domain.Model
{
    public class Suspeito
    {
        public int Id { get; set; }
        public byte[] Foto { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public ICollection<Ocorrencia> Ocorrencias { get; set; }

        public Suspeito()
        {
            Ocorrencias = new List<Ocorrencia>();
        }
    }
}