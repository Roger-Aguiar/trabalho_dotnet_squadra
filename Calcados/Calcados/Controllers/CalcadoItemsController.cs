using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Calcados.Models;

namespace Calcados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcadoItemsController : ControllerBase
    {
        private readonly CalcadoContext _context;

        public CalcadoItemsController(CalcadoContext context)
        {
            _context = context;
        }

        // GET: api/CalcadoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CalcadoItem>>> GetCalcadoItems()
        {
            return await _context.CalcadoItems.ToListAsync();
        }

        // GET: api/CalcadoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CalcadoItem>> GetCalcadoItem(long id)
        {
            var calcadoItem = await _context.CalcadoItems.FindAsync(id);

            if (calcadoItem == null)
            {
                return NotFound();
            }

            return calcadoItem;
        }

        // PUT: api/CalcadoItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCalcadoItem(long id, CalcadoItem calcadoItem)
        {
            if (id != calcadoItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(calcadoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalcadoItemExists(id))
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

        // POST: api/CalcadoItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CalcadoItem>> PostCalcadoItem(CalcadoItem calcadoItem)
        {
            _context.CalcadoItems.Add(calcadoItem);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetCalcadoItem", new { id = calcadoItem.Id }, calcadoItem);
            return CreatedAtAction(nameof(GetCalcadoItems), new { id = calcadoItem.Id}, calcadoItem);
        }

        // DELETE: api/CalcadoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CalcadoItem>> DeleteCalcadoItem(long id)
        {
            var calcadoItem = await _context.CalcadoItems.FindAsync(id);
            if (calcadoItem == null)
            {
                return NotFound();
            }

            _context.CalcadoItems.Remove(calcadoItem);
            await _context.SaveChangesAsync();

            return calcadoItem;
        }

        private bool CalcadoItemExists(long id)
        {
            return _context.CalcadoItems.Any(e => e.Id == id);
        }
    }
}
