using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.WriterPanelLayout;
public class WriterPanelMessageNotificationSection : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}