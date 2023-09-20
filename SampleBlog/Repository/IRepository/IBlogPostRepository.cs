namespace SampleBlog.Repository.IRepository
{
    public interface IBlogPostRepository
    {
        BlogPost GetPostById(int id);
        IEnumerable<BlogPost> GetAllPosts();
        void CreatePost(BlogPost post);
        void UpdatePost(BlogPost post);
        bool DeletePost(BlogPost post);
        public bool Save();

    }
}
