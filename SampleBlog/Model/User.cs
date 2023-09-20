﻿using System.ComponentModel.DataAnnotations;

namespace SampleBlog.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*#?&^])[A-Za-z\d@$!%*#?&^]{8,}$")]
        public string Password { get; set; }


        //public BlogPost BlogPost { get; set; }


        public List<BlogPost> BlogPosts { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
