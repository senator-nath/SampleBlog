namespace SampleBlog.Model.Dtos
{
    public class CreateBlogPostDto
    {
        public string Title { get; set; }
        public string Details { get; set; }
        public User UserId { get; set; }

        public CreateUserDto User { get; set; }

    }
}

