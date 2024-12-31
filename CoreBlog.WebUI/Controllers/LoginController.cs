using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.Controllers;
public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}