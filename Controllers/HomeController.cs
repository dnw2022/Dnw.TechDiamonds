using Microsoft.AspNetCore.Mvc;

namespace Dnw.TechDiamonds.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}