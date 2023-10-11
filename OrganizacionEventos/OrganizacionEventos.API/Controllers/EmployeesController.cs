using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizacionEventos.API.Data;
using OrganizacionEventos.Shared.Entities;

namespace OrganizacionEventos.API.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeesController:ControllerBase
    {
        private readonly DataContext _context;
        public EmployeesController(DataContext context)
        {

            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Employees.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
            if (employee is null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Employee employee)
        {
            _context.Add(employee);
            await _context.SaveChangesAsync();
            return Ok(employee);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Employee employee)
        {
            _context.Update(employee);
            await _context.SaveChangesAsync();
            return Ok(employee);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var afectedRows = await _context.Employees
                .Where(x => x.EmployeeId == id)
                .ExecuteDeleteAsync();

            if (afectedRows == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}







  
