using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizacionEventos.API.Data;
using OrganizacionEventos.Shared.Entities;

namespace OrganizacionEventos.API.Controllers
{

    [ApiController]
    [Route("api/serviceevents")]
    public class ServiceEventsController:ControllerBase
    {

        private readonly DataContext _context;
        public ServiceEventsController(DataContext context)
        {

            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.ServiceEvents.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var serviceEvent = await _context.ServiceEvents.FirstOrDefaultAsync(x => x.Id == id);
            if (serviceEvent is null)
            {
                return NotFound();
            }

            return Ok(serviceEvent);
        }

        [HttpPost]
        public async Task<ActionResult> Post(ServiceEvent serviceEvent)
        {
            _context.Add(serviceEvent);
            await _context.SaveChangesAsync();
            return Ok(serviceEvent);
        }

        [HttpPut]
        public async Task<ActionResult> Put(ServiceEvent serviceEvent)
        {
            _context.Update(serviceEvent);
            await _context.SaveChangesAsync();
            return Ok(serviceEvent);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var afectedRows = await _context.ServiceEvents
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (afectedRows == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
