using Microsoft.AspNetCore.Mvc;

namespace Dnw.TechDiamonds.Controllers;

public class FaqController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}