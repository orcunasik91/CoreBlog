namespace CoreBlog.Entities.Concrete;
public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string CategoryDescription { get; set; }
    public bool IsActive { get; set; }
}