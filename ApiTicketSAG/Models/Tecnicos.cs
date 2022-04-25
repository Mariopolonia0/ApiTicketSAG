using System.ComponentModel.DataAnnotations;

namespace ApiTicketSAG.Models
{
    public class Tecnicos
    {
        [Key]
        public int idEncargado { get; set; }
        public string Nombres { get; set; }
        public int Cantidad { get; set; }
    }
}
