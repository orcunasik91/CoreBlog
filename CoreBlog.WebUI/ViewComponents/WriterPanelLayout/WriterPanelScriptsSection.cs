using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.WriterPanelLayout;
public class WriterPanelScriptsSection : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
