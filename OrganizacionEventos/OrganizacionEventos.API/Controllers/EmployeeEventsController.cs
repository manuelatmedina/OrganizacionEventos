using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizacionEventos.API.Data;
using OrganizacionEventos.Shared.Entities;

namespace OrganizacionEventos.API.Controllers
{

    [ApiController]
    [Route("api/employeeevents")]
    public class EmployeeEventsController:ControllerBase
    {
        private readonly DataContext _context;
        public EmployeeEventsController(DataContext context)
        {

            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.EmployeeEvents.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var employeeEvent = await _context.EmployeeEvents.FirstOrDefaultAsync(x => x.Id == id);
            if (employeeEvent is null)
            {
                return NotFound();
            }

            return Ok(employeeEvent);
        }

        [HttpPost]
        public async Task<ActionResult> Post(EmployeeEvent employeeEvent)
        {
            _context.Add(employeeEvent);
            await _context.SaveChangesAsync();
            return Ok(employeeEvent);
        }

        [HttpPut]
        public async Task<ActionResult> Put(EmployeeEvent employeeEvent )
        {
            _context.Update(employeeEvent);
            await _context.SaveChangesAsync();
            return Ok(employeeEvent);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var afectedRows = await _context.EmployeeEvents
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
