using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers;

public class AboutController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}