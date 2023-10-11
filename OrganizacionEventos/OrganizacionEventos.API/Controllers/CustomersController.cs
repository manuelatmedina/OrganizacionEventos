using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizacionEventos.API.Data;
using OrganizacionEventos.Shared.Entities;

namespace OrganizacionEventos.API.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : ControllerBase { 

    private readonly DataContext _context;
    public CustomersController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        return Ok(await _context.Customers.ToListAsync());
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> Get(int id)
    {
        var customer = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
        if (customer is null)
        {
            return NotFound();
        }
        return Ok(customer);
    }

    [HttpPost]
    public async Task<ActionResult> Post(Customer customer)
    {
        _context.Add(customer);
        await _context.SaveChangesAsync();
        return Ok(customer);
    }

    [HttpPut]
    public async Task<ActionResult> Put(Customer customer)
    {
        _context.Update(customer);
        await _context.SaveChangesAsync();
        return Ok(customer);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        var afectedRows = await _context.Customers
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




