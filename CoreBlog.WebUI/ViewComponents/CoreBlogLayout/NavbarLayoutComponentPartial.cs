using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.CoreBlogLayout;
public class NavbarLayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}