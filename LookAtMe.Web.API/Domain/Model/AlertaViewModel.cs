using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Web.API.Domain.Model
{
    public class AlertaViewModel
    {
        public int Id { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public TimeSpan HoraOcorrencia { get; set; }
        public int LinhaTranscol { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public SuspeitoViewModel Suspeito { get; set; }
        public bool ViaturaEncaminhada { get; set; }
    }
}
