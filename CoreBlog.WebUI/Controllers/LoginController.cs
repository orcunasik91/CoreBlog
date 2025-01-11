using CoreBlog.DataAccess.Concrete.Context;
using CoreBlog.Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoreBlog.WebUI.Controllers;
public class LoginController : Controller
{
    [HttpGet]
    [AllowAnonymous]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Index(Writer writer)
    {
        MyAppContext context = new();
        Writer result = context.Writers.FirstOrDefault(w => w.WriterEmail == writer.WriterEmail && w.WriterPassword == writer.WriterPassword);
        if (result != null)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,writer.WriterEmail)
            };
            ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "a");
            ClaimsPrincipal principal = new(userIdentity);
            await HttpContext.SignInAsync(principal);
            return RedirectToAction("Index","Writer");
        }
        else
            return View();
    }
}