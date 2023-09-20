global using SampleBlog.Data;
global using SampleBlog.Model;
global using SampleBlog.Repository.IRepository;

namespace SampleBlog.Repository
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly ApplicationDbContext _Db;

        public BlogPostRepository(ApplicationDbContext Db)
        {
            _Db = Db;
        }
        public void CreatePost(BlogPost blogPost)
        {
            _Db.BlogPosts.Add(blogPost);
            _Db.SaveChanges();
        }

        public bool DeletePost(BlogPost post)
        {
            _Db.BlogPosts.Remove(post);
            return Save();
        }

        public IEnumerable<BlogPost> GetAllPosts()
        {
            return _Db.BlogPosts.ToList();
        }

        public BlogPost GetPostById(int id)
        {
            return _Db.BlogPosts.FirstOrDefault(p => p.Id == id);
        }

        public bool Save()
        {
            return _Db.SaveChanges() >= 0 ? true : false;
        }

        public void UpdatePost(BlogPost post)
        {
            _Db.BlogPosts.Update(post);
            _Db.SaveChanges();
        }
    }
}
