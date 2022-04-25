#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiTicketSAG.Data;
using ApiTicketSAG.Models;

namespace ApiTicketSAG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly Contexto _context;

        public TicketsController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Tickets
        [HttpGet]
        public async Task<ActionResult<ListaTickets>> GetTickets()
        {
            var listaTicket = new ListaTickets();
            listaTicket.Tecnicos = await _context.Tecnicos.ToListAsync();
            listaTicket.Tickets = await _context.Tickets.ToListAsync();
            listaTicket.Mensajes = await _context.Mensajes.ToListAsync();
            listaTicket.Clientes = await _context.Clientes.ToListAsync();
            return listaTicket;
        }
        // POST: api/Tickets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tickets>> PostTickets(TicketRecibido ticketDto)
        {
            var ticket = new Tickets(ticketDto);
            var tecnico = _context.Tecnicos.Find(ticket.idEncargado);
            tecnico.Cantidad++;
            _context.Tecnicos.Update(tecnico);
            ticket.Empresa = _context.Clientes.Find(ticketDto.idCliente).empresa;
            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();

            return  CreatedAtAction("GetTickets", new { id = ticket.idTicket }, ticket);
        }
    }
}
