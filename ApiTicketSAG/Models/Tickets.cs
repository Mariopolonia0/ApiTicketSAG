using System.ComponentModel.DataAnnotations;

namespace ApiTicketSAG.Models
{
    public class Tickets
    {
        [Key]
        public int idTicket { get; set; }
        public DateTime fecha { get; set; }
        public DateTime vence { get; set; }
        public int idEncargado { get; set; }
        public string Empresa { get; set; }
        public string solicitadoPor { get; set; }
        public string asunto { get; set; }
        public string especificaciones { get; set; }

        public Tickets() { }
        public Tickets(TicketRecibido ticketDto)
        {
            this.idTicket = 0;
            this.fecha = DateTime.Now;
            this.vence = DateTime.Now;
            this.idEncargado = ticketDto.idEncargado;
            this.solicitadoPor = ticketDto.solicitadoPor;
            this.asunto = ticketDto.asunto;
            this.especificaciones = ticketDto.especificaciones;
        }
    }
}
