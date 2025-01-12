using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.WriterPanelLayout;
public class WriterPanelSidebarSection : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}