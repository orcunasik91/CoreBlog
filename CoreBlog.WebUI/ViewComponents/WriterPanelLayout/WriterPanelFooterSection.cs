using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.WriterPanelLayout;
public class WriterPanelFooterSection : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}