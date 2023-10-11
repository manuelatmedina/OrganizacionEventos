using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizacionEventos.API.Data;
using OrganizacionEventos.Shared.Entities;

namespace OrganizacionEventos.API.Controllers
{

    [ApiController]
    [Route("api/services")]
    public class ServicesController:ControllerBase
    {
        private readonly DataContext _context;
        public ServicesController(DataContext context)
        {

            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Services.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var service = await _context.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (service is null)
            {
                return NotFound();
            }

            return Ok(service);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Service service)
        {
            _context.Add(service);
            await _context.SaveChangesAsync();
            return Ok(service);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Service service)
        {
            _context.Update(service);
            await _context.SaveChangesAsync();
            return Ok(service);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var afectedRows = await _context.Services
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
