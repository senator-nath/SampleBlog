using SampleBlog.Model;

namespace SampleBlog.Repository.IRepository
{
    public interface IUserRepository
    {
        bool isUniqueUser(string username, string Email);
        User Authenticate(string username, string password, string email);
        User Register(string username, string password, string email);

    }
}
