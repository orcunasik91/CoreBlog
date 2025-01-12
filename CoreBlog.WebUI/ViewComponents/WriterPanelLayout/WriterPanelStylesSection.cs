using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.WriterPanelLayout;
public class WriterPanelStylesSection : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}