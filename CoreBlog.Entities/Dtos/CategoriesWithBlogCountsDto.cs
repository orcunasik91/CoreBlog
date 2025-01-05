namespace CoreBlog.Entities.Dtos;
public class CategoriesWithBlogCountsDto
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public int BlogCount { get; set; }
}