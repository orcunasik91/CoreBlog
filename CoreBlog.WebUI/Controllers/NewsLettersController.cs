using CoreBlog.Business.Abstract;
using CoreBlog.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.Controllers;
public class NewsLettersController : Controller
{
    private readonly INewsLetterService _newsLetterService;

    public NewsLettersController(INewsLetterService newsLetterService)
    {
        _newsLetterService = newsLetterService;
    }

    [HttpGet]
    public IActionResult AddSubscribe()
    {
        return PartialView();
    }
    [HttpPost]
    public IActionResult AddSubscribe(NewsLetter newsLetter)
    {
        _newsLetterService.Create(newsLetter);
        return RedirectToAction("Index","Blogs");
    }
}