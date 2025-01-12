using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.WriterPanelLayout;
public class WriterPanelNavbarSection : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}