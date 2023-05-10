using System.ComponentModel.DataAnnotations;

namespace NAVA_MVP1.Models
{
    public class UsersModel
    {
        [Display(Name = " User ID")]
        public int UserID { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You need a valid email.")]
        public string? UserEmail { get; set; }

        [Display(Name = "Confirm Email")]
        [DataType(DataType.EmailAddress)]
        [Compare("UserEmail", ErrorMessage = "Both email and confirm email should be match.")]
        public string? ConfirmEmail { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "You need a valid username.")]
        public string? UserName { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Your password is not valid.")]
        public string? Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Both Password and Confirm password should match.")]
        public string? ConfirmPassword { get; set; }
       
    }
}
