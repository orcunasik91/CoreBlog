namespace CoreBlog.Entities.Concrete;
public class Blog
{
    public int BlogId { get; set; }
    public string BlogTitle { get; set; }
    public string BlogContent { get; set; }
    public string BlogThumbnailImageUrl { get; set; }
    public string BlogImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool IsActive { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public int WriterId { get; set; }
    public Writer Writer { get; set; }
    public List<Comment> Comments { get; set; }
}