using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.CoreBlogLayout;
public class StylesLayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}