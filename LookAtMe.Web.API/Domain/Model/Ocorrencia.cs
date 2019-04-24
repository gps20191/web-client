using System;

namespace LookAtMe.Web.API.Domain.Model
{
    public class Ocorrencia
    {
        public int Id { get; set; }
        public DateTime DataRegistro { get; set; }
        public TimeSpan HoraRegistro { get; set; }
        public string Descricao { get; set; }
    }
}