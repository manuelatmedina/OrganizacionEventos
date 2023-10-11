using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizacionEventos.API.Data;
using OrganizacionEventos.Shared.Entities;

namespace OrganizacionEventos.API.Controllers
{
    [ApiController]
    [Route("api/contracts")]
    public class ContractsController : ControllerBase
    {
        private readonly DataContext _context;
        public ContractsController(DataContext context)
        {

            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Contracts.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var contract = await _context.Contracts.FirstOrDefaultAsync(x => x.Id == id);
            if (contract is null)
            {
                return NotFound();
            }

            return Ok(contract);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Contract contract)
        {
            _context.Add(contract);
            await _context.SaveChangesAsync();
            return Ok(contract);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Contract contract)
        {
            _context.Update(contract);
            await _context.SaveChangesAsync();
            return Ok(contract);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var afectedRows = await _context.Contracts
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
