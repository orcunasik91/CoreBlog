using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.Controllers;
public class WriterController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}