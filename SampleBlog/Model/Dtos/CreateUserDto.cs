using System.ComponentModel.DataAnnotations;

namespace SampleBlog.Model.Dtos
{
    public class CreateUserDto
    {

        [Required]
        public string FullName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*#?&^])[A-Za-z\d@$!%*#?&^]{8,}$")]
        public string Password { get; set; }




    }
}

