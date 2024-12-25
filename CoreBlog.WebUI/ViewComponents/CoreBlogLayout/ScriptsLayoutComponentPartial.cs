using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.CoreBlogLayout;
public class ScriptsLayoutComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}