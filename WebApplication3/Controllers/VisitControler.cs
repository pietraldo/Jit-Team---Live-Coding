using HttpRequestsSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.VetObjects;

namespace WebApplication3.Controllers
{
    [Route("api/VisitControler")]
    [ApiController]
    public class VisitControler : ControllerBase
    {
        private  VisitContext _context;
        public VisitControler(VisitContext context)
        {
            _context = context;
        }
        // GET: api/Visit
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Visit>>> VisitItems()
        {
            return await _context.Visits.ToListAsync();
        }

        // GET: api/Visit/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Visit>> GetVisitItems(int id)
        {
            var visit = await _context.Visits.FindAsync(id);
            if (visit == null)
            {
                return NotFound();
            }
            return visit;
        }

        // POST: api/Visits
        [HttpPost]
        public async Task<ActionResult<Visit>> AddVisit(Visit visit)
        {
            _context.Visits.Add(visit);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetVisitItems), new { id = visit.Id }, visit);
        }

        // DELETE: api/Visits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVisit(int id)
        {
            var todoItem = await _context.Visits.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }
            _context.Visits.Remove(todoItem);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
