using SampleBlog.Data;
using SampleBlog.Model;
using SampleBlog.Repository.IRepository;

namespace SampleBlog.Repository
{


    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _Db;

        public UserRepository(ApplicationDbContext Db)
        {
            _Db = Db;
        }
        public User Authenticate(string username, string password, string email)
        {
            User value = _Db.Users.SingleOrDefault(x => x.UserName == username && x.Email == email);
            return value;
        }

        public bool isUniqueUser(string username, string Email)
        {
            var user = _Db.Users.SingleOrDefault(x => x.UserName == username && x.Email == Email);
            if (user == null) { return true; }
            return false;
        }

        public User Register(string username, string password, string email)
        {
            User value = _Db.Users.SingleOrDefault(x => x.UserName == username && x.Email == email);
            if (value != null)
            {
                _Db.Users.Add(value);
                _Db.SaveChanges();
            }
            return value;
        }


    }
}
