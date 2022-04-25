using ApiTicketSAG.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTicketSAG.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }
        public DbSet<Tecnicos> Tecnicos { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
        }
    }
}


