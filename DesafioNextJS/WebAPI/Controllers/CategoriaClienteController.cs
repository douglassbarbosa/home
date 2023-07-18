using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaClienteController : ControllerBase
    {
        private readonly CategoriaClienteContext _context;

        public CategoriaClienteController(CategoriaClienteContext context)
        {
            _context = context;
        }

        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<CategoriaCliente>>> GetCategoriaClientes()
        {
            return await _context.CategoriaCliente.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<CategoriaCliente>> PostCategoriaCliente(CategoriaCliente categoriaCliente)
        {
            _context.CategoriaCliente.Add(categoriaCliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCategoriaCliente), new { id = categoriaCliente.Id }, categoriaCliente);
        }

        [HttpGet("{id}", Name = "GetCategoriaCliente")]
        public async Task<ActionResult<CategoriaCliente>> GetCategoriaCliente(int id)
        {
            var categoriaCliente = await _context.CategoriaCliente.FindAsync(id);

            if (categoriaCliente == null)
            {
                return NotFound();
            }

            return Ok(categoriaCliente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoriaCliente(Guid id, CategoriaCliente categoriaCliente)
        {
            if (id != categoriaCliente.Id)
            {
                return BadRequest();
            }

            _context.Entry(categoriaCliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriaClienteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoriaCliente(Guid id)
        {
            var categoriaCliente = await _context.CategoriaCliente.FindAsync(id);
            if (categoriaCliente == null)
            {
                return NotFound();
            }

            _context.CategoriaCliente.Remove(categoriaCliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool CategoriaClienteExists(Guid id)
        {
            return _context.CategoriaCliente.Any(e => e.Id == id);
        }

    }
}
