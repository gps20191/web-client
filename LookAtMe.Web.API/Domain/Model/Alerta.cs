using System;

namespace LookAtMe.Web.API.Domain.Model
{

    public class Alerta
    {
        public int Id { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public TimeSpan HoraOcorrencia { get; set; }
        public int LinhaTranscol { get; set; }

        public string Localizacao { get; set; }

        public int SuspeitoId { get; set; }
        public Suspeito Suspeito { get; set; }

        public  string Estado { get; set; }

        public bool Capturado { get; set; }
    }
}
