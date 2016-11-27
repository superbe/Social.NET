using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Social.NET.CMS;
using Social.NET.Web.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social.NET.Web.Controllers.API
{
	[Produces("application/json")]
	[Route("api/PageItems")]
	public class PageItemsController : Controller
	{
		private readonly ApplicationDbContext _context;

		public PageItemsController(ApplicationDbContext context)
		{
			_context = context;
		}

		// GET: api/PageItems
		[HttpGet]
		public IEnumerable<PageItem> GetPageItems()
		{
			return _context.PageItems;
		}

		// GET: api/PageItems/5
		[HttpGet("{id}")]
		public async Task<IActionResult> GetPageItem([FromRoute] int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			PageItem pageItem = await _context.PageItems.SingleOrDefaultAsync(m => m.Id == id);

			if (pageItem == null)
			{
				return NotFound();
			}

			return Ok(pageItem);
		}

		// PUT: api/PageItems/5
		[HttpPut("{id}")]
		public async Task<IActionResult> PutPageItem([FromRoute] int id, [FromBody] PageItem pageItem)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != pageItem.Id)
			{
				return BadRequest();
			}

			_context.Entry(pageItem).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!PageItemExists(id))
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

		// POST: api/PageItems
		[HttpPost]
		public async Task<IActionResult> PostPageItem([FromBody] PageItem pageItem)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			_context.PageItems.Add(pageItem);
			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateException)
			{
				if (PageItemExists(pageItem.Id))
				{
					return new StatusCodeResult(StatusCodes.Status409Conflict);
				}
				else
				{
					throw;
				}
			}

			return CreatedAtAction("GetPageItem", new { id = pageItem.Id }, pageItem);
		}

		// DELETE: api/PageItems/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeletePageItem([FromRoute] int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			PageItem pageItem = await _context.PageItems.SingleOrDefaultAsync(m => m.Id == id);
			if (pageItem == null)
			{
				return NotFound();
			}

			_context.PageItems.Remove(pageItem);
			await _context.SaveChangesAsync();

			return Ok(pageItem);
		}

		private bool PageItemExists(int id)
		{
			return _context.PageItems.Any(e => e.Id == id);
		}
	}
}