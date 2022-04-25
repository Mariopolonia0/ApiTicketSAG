#nullable disable
using Microsoft.AspNetCore.Mvc;
using ApiTicketSAG.Data;
using ApiTicketSAG.Models;

namespace ApiTicketSAG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensajesController : ControllerBase
    {

        private readonly Contexto _context;
        
        public MensajesController(Contexto context)
        {
            _context = context;
        }
        // POST: api/Mensajes
        [HttpPost]
        public async Task<ActionResult<Mensaje>> PostMensaje(MensajeRecibido mensaje)
        {
            _context.Mensajes.Add(new Mensaje(mensaje));
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
//