namespace CoreBlog.Entities.Concrete;
public class Writer
{
    public int WriterId { get; set; }
    public string WriterFullName { get; set; }
    public string WriterAbout { get; set; }
    public string WriterImageUrl { get; set; }
    public string WriterEmail { get; set; }
    public string WriterPassword { get; set; }
    public bool IsActive { get; set; }
}