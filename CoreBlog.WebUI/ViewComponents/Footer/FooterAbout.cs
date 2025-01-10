using CoreBlog.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.Footer;
public class FooterAbout : ViewComponent
{
    private readonly IAboutService _aboutService;

    public FooterAbout(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    public IViewComponentResult Invoke()
    {
        var datas = _aboutService.GetList();
        return View(datas);
    }
}