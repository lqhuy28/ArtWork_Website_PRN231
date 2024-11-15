using AWS_BusinessObjects.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Models
{
    public class SignUpModel
    {
        /* [Required]
         public string FirstName { get; set; } = null!;
         [Required]
         public string LastName { get; set; } = null!;*/
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public SignUpStatus Status { get; set; }
    }
}
