using CoreBlog.Business.Abstract;
using CoreBlog.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.Controllers;

[AllowAnonymous]
public class ContactController : Controller
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Contact contact)
    {
        contact.ContactDate = Convert.ToDateTime(DateTime.Now.ToString("g"));
        _contactService.Create(contact);
        return RedirectToAction(nameof(Index));
    }
}