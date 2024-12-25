using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.Controllers;
public class BlogsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}