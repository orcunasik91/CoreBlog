namespace CoreBlog.Entities.Concrete;
public class Comment
{
    public int CommentId { get; set; }
    public string UserName { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool IsActive { get; set; }
}