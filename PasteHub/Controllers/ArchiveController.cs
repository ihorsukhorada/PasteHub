using Microsoft.AspNetCore.Mvc;

namespace PasteHub.Controllers;

public class ArchiveController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}