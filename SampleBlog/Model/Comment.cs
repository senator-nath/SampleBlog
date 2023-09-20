namespace SampleBlog.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public int UserId { get; set; }
        public string BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
