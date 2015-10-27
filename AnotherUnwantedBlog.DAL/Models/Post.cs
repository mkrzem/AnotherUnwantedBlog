namespace AnotherUnwantedBlog.DAL.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public virtual Author Author { get; set; }
    }
}
