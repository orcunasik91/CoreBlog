using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.CoreBlogLayout;
public class HeaderMenuLayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}