using CoreBlog.Business.Abstract;
using CoreBlog.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.Controllers;
public class AboutController : Controller
{
    private readonly IAboutService _aboutService;
    private readonly INewsLetterService _newsLetterService;
    public AboutController(IAboutService aboutService, INewsLetterService newsLetterService)
    {
        _aboutService = aboutService;
        _newsLetterService = newsLetterService;
    }

    public IActionResult Index()
    {
        var datas = _aboutService.GetList();
        return View(datas);
    }

    [HttpGet]
    public IActionResult AddFooterSubscribe()
    {
        return PartialView();
    }

    [HttpPost]
    public IActionResult AddFooterSubscribe(NewsLetter newsLetter)
    {
        newsLetter.IsStatus = true;
        _newsLetterService.Create(newsLetter);
        return RedirectToAction("Index", "Blogs");
    }
}