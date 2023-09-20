using SampleBlog.Model.Dtos;

namespace SampleBlog.Service.ServiceForUser
{
    public interface IUserService
    {

        bool isUniqueUser(string username, string Email);
        AuthenticateUserDto Authenticate(string username, string password, string email);
        CreateUserDto Register(string username, string password, string email);
    }
}
