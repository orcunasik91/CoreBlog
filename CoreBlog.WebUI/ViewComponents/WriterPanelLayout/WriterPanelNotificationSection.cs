using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.WriterPanelLayout;
public class WriterPanelNotificationSection : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}