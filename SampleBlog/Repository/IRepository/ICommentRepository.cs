using SampleBlog.Model;

namespace SampleBlog.Repository.IRepository
{
    public interface ICommentRepository
    {
        Comment GetCommentById(int id);
        public IEnumerable<Comment> GetAllComments();
        void CreateComment(Comment comment);
        void UpdateComment(Comment comment);
        void DeleteComment(int id);

    }
}
