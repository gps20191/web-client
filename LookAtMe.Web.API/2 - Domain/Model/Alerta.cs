using System;

namespace LookAtMe.Web.API.Domain.Model
{

    public class Alerta
    {
        public int Id { get; set; }

        public DateTime DataHoraRegistro { get; set; }

        public string Estado { get; set; }

        public int NumeroOnibus { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public int SuspeitoId { get; set; }        

        public  string UrlFoto { get; set; }

        public bool Capturado { get; set; }
    }
}
