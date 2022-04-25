using System.ComponentModel.DataAnnotations;

namespace ApiTicketSAG.Models
{
    public class Clientes
    {
        [Key]
        public int codigoCliente { get; set; }
        public string empresa { get; set; }
    }
}
