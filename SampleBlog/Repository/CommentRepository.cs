namespace SampleBlog.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDbContext _Db;

        public CommentRepository(ApplicationDbContext Db)
        {
            _Db = Db;
        }
        public void CreateComment(Comment comment)
        {
            _Db.Comments.Add(comment);
            _Db.SaveChanges();
        }

        public void DeleteComment(int id)
        {
            var comment = _Db.Comments.FirstOrDefault(c => c.Id == id);
            if (comment != null)
            {
                _Db.Comments.Remove(comment);
                _Db.SaveChanges();
            }
        }

        public Comment GetCommentById(int id)
        {
            return _Db.Comments.FirstOrDefault(p => p.Id == id);

        }

        public IEnumerable<Comment> GetAllComments()
        {
            return _Db.Comments.ToList();

        }

        public void UpdateComment(Comment comment)
        {
            _Db.Comments.Update(comment);
            _Db.SaveChanges();
        }


    }
}
