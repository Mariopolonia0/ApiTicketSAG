using System.ComponentModel.DataAnnotations;

namespace ApiTicketSAG.Models
{
    public class Mensaje
    {
        [Key]
        public int idMensaje { get; set; }
        public int idTicket { get; set; }
        public DateTime fecha { get; set; } 
        public string Mensajes { get; set; }
        public string EnviadoPor { get; set; }

        public Mensaje() { }
        public Mensaje(MensajeRecibido mensaje)
        {
            this.idMensaje = 0;
            this.idTicket = mensaje.idTicket;
            this.fecha = DateTime.Now;
            this.Mensajes = mensaje.Mensaje;
            this.EnviadoPor = mensaje.EnviadoPor;
        }
    }
}
