using CoreBlog.Business.Abstract;
using CoreBlog.Business.ValidationRules.WriterValidation;
using CoreBlog.Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.Controllers;
public class RegisterController : Controller
{
    private readonly IWriterService _writerService;

    public RegisterController(IWriterService writerService)
    {
        _writerService = writerService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Writer writer)
    {
        WriterValidator validationRules = new();
        ValidationResult validationResult = validationRules.Validate(writer);
        if (validationResult.IsValid)
        {
            writer.IsActive = false;
            writer.WriterAbout = "test";
            _writerService.Create(writer);
            return RedirectToAction("Index", "Blogs");
        }
        else
        {
            foreach (ValidationFailure error in validationResult.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
        }
        return View();
        
    }
}