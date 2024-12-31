﻿using CoreBlog.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.Controllers;
public class BlogsController : Controller
{
    private readonly IBlogService _blogService;
    public BlogsController(IBlogService blogService)
    {
        _blogService = blogService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult BlogRead(int id)
    {
        ViewBag.BlogId = id;
        return View();
    }

}