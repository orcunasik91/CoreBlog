using CoreBlog.Business.Abstract;
using CoreBlog.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreBlog.WebUI.Controllers;
public class WriterController : Controller
{
    private readonly IBlogService _blogService;
    private readonly ICategoryService _categoryService;
    private readonly IWriterService _writerService;

    public WriterController(IBlogService blogService, ICategoryService categoryService, IWriterService writerService)
    {
        _blogService = blogService;
        _categoryService = categoryService;
        _writerService = writerService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var datas = _blogService.GetBlogsWithCategoryByWriter(1);
        return View(datas);
    }

    [HttpGet]
    public IActionResult CreateBlog()
    {
        List<Category> categories = _categoryService.GetList();
        ViewBag.Categories = new SelectList(categories, "CategoryId", "CategoryName");
        Writer writer = _writerService.GetById(1);
        ViewBag.Writer = writer.WriterId;
        return View();
    }

    [HttpPost]
    public IActionResult CreateBlog(Blog blog)
    {
        blog.IsActive = true;
        blog.WriterId = 1;
        blog.CreatedDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MMMM-yyyy"));
        _blogService.Create(blog);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult GetMyBlog(int id)
    {
        var blog = _blogService.GetById(id);
        List<Category> categories = _categoryService.GetList();
        ViewBag.Categories = new SelectList(categories, "CategoryId", "CategoryName");
        return View(blog);
    }

    [HttpPost]
    public IActionResult UpdateBlog(Blog blog)
    {
        blog.IsActive = true;
        blog.WriterId = 1;
        _blogService.Update(blog);
        return RedirectToAction(nameof(Index));
    }
}