using Microsoft.AspNetCore.Mvc;

namespace Social.NET.Web.Controllers
{
	public class ContentController : Controller
	{
		public IActionResult Index(int id)
		{
			ViewData["PageId"] = id;
			return View();
		}
	}
}