namespace CoreBlog.Entities.Concrete;
public class Contact
{
    public int ContactId { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
    public DateTime ContactDate { get; set; }
    public bool IsRead { get; set; }
}