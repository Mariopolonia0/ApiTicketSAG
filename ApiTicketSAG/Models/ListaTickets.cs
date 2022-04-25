namespace ApiTicketSAG.Models
{
    public class ListaTickets
    {
        public List<Tecnicos> Tecnicos { get; set; }
        public List<Tickets> Tickets { get; set; }
        public List<Mensaje> Mensajes { get; set; }
        public List<Clientes> Clientes { get; set; }
    }
}
