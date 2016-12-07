using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using Social.NET.CMS;
using Social.NET.Web.Data;
using Social.NET.Web.Models.CMS;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social.NET.Web.Controllers.API
{
	[Produces("application/json")]
	[Route("api/Templates")]
	public class TemplatesController : Controller
	{
		private readonly ApplicationDbContext _context;

		public TemplatesController(ApplicationDbContext context)
		{
			_context = context;
		}

		// GET: api/Templates
		[HttpGet]
		public IEnumerable<Template> GetTemplates()
		{
			return _context.Templates;
		}

		// GET: api/Templates/5
		[HttpGet("{id}")]
		public async Task<IActionResult> GetTemplate([FromRoute] int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			Template template = await _context.Templates.SingleOrDefaultAsync(m => m.Id == id);

			if (template == null)
			{
				return NotFound();
			}

			return Ok(template);
		}

		// PUT: api/Templates/5
		[HttpPut("{id}")]
		public async Task<IActionResult> PutTemplate([FromRoute] int id, [FromBody] Template template)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != template.Id)
			{
				return BadRequest();
			}

			_context.Entry(template).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!TemplateExists(id))
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

		// POST: api/Templates
		[HttpPost]
		public async Task<IActionResult> PostTemplate([FromBody] Template template)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			_context.Templates.Add(template);
			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateException)
			{
				if (TemplateExists(template.Id))
				{
					return new StatusCodeResult(StatusCodes.Status409Conflict);
				}
				else
				{
					throw;
				}
			}

			return CreatedAtAction("GetTemplate", new { id = template.Id }, template);
		}

		// DELETE: api/Templates/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteTemplate([FromRoute] int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			Template template = await _context.Templates.SingleOrDefaultAsync(m => m.Id == id);
			if (template == null)
			{
				return NotFound();
			}

			_context.Templates.Remove(template);
			await _context.SaveChangesAsync();

			return Ok(template);
		}

		private bool TemplateExists(int id)
		{
			return _context.Templates.Any(e => e.Id == id);
		}
	}
}