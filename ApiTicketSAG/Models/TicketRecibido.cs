namespace ApiTicketSAG.Models
{
    public class TicketRecibido
    {
        public int idCliente { get; set; }
        public int idEncargado { get; set; }
        public string solicitadoPor { get; set; }
        public string asunto { get; set; }
        public string especificaciones { get; set; }
    }
}
