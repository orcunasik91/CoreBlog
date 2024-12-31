using CoreBlog.Business.Abstract;
using CoreBlog.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.Controllers;
public class RegisterController : Controller
{
    private readonly IWriterService _writerService;

    public RegisterController(IWriterService writerService)
    {
        _writerService = writerService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Writer writer)
    {
        writer.IsActive = false;
        _writerService.Create(writer);
        return RedirectToAction("Index","Blogs");
    }
}