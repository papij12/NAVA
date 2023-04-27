using System.ComponentModel.DataAnnotations;
namespace NAVA_MVP1.Models
{
    public class Login
    {
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You need a valid email.")]
        public string? Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Your password is not valid.")]
        public string? Password { get; set; }

    }
}
