﻿using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.CoreBlogLayout;
public class HeadLayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}