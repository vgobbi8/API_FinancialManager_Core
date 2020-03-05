using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_FinancialManager_Core.Data;
using API_FinancialManager_Core.Models;

namespace API_FinancialManager_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimentosController : ControllerBase
    {
        private readonly API_DbContext _context;

        public MovimentosController(API_DbContext context)
        {
            _context = context;
        }

        // GET: api/Movimentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movimento>>> GetMovimento()
        {
            return await _context.MOV001_Movimento.ToListAsync();
        }

        // GET: api/Movimentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movimento>> GetMovimento(long id)
        {
            var movimento = await _context.MOV001_Movimento.FindAsync(id);

            if (movimento == null)
            {
                return NotFound();
            }

            return movimento;
        }

        // PUT: api/Movimentos/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovimento(long id, Movimento movimento)
        {
            if (id != movimento.Id)
            {
                return BadRequest();
            }

            _context.Entry(movimento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovimentoExists(id))
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

        // POST: api/Movimentos
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Movimento>> PostMovimento(Movimento movimento)
        {
            _context.MOV001_Movimento.Add(movimento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovimento", new { id = movimento.Id }, movimento);
        }

        // DELETE: api/Movimentos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Movimento>> DeleteMovimento(long id)
        {
            var movimento = await _context.MOV001_Movimento.FindAsync(id);
            if (movimento == null)
            {
                return NotFound();
            }

            _context.MOV001_Movimento.Remove(movimento);
            await _context.SaveChangesAsync();

            return movimento;
        }

        private bool MovimentoExists(long id)
        {
            return _context.MOV001_Movimento.Any(e => e.Id == id);
        }
    }
}
