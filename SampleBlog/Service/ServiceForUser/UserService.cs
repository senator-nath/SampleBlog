using SampleBlog.Model.Dtos;

namespace SampleBlog.Service.ServiceForUser
{
    public class UserService : IUserService
    {
        private readonly IUserService _userService;
        public UserService(IUserService userService)
        {
            _userService = userService;
        }
        public AuthenticateUserDto Authenticate(string username, string password, string email)
        {
            return _userService.Authenticate(username, password, email);

        }

        public bool isUniqueUser(string username, string Email)
        {
            return _userService.IsUniqueUser(username, email);

        }

        public CreateUserDto Register(string username, string password, string email)
        {
            return _userService.Register(username, password, email);

        }
    }
}
