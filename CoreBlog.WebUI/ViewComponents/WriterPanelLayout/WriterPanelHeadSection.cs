using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.WriterPanelLayout;
public class WriterPanelHeadSection : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}