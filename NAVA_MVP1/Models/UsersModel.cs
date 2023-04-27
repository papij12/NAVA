using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

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

      
        public UsersModel() 
        {

        }

        public bool IsEmail(string useremail)
        {
             //Task1 - Testing if the user email is null: Passed successfully 
            //Task2 - Testing the email domain validity: Not yet.
            var flag = true;
            if(useremail == null)
                flag = false;
            
            return flag;
        }
        public bool IsConfirmedEmail(string confirmedemail)
        {
            //Task 1 - Testing if the confirmed eamil is not null: Passed successfully
            //Task 2 - Testing the confiremd email domain validity: Not yet.
            var flag = true;
            if (confirmedemail == null)
                flag = false;

            return flag;
        }
        public bool IsUserName(string username)
        {
            //Task 1 - Testing if the username is not null: Passed successfully.
            //Task 2 - Testing the username confirmity: Not yet.
            var flag = true;
            if (username == null)
                flag = false;

            return flag;
        }
        public bool IsPassword(string password)
        {
            //Task 1 - Testing if the password is not null: Passed successfully.
            //Task 2 - Testing the password confirmity: Not yet.
            var flag = true;

            if (password == null)
                flag = false;

            return flag;
        }
        public bool IsConfirmedPassword(string confirmpassword)
        {
            //Task 1 - Testing if the confirmpassword is not null: Passed successfully.
            //Task 2 - Testing the confirmpassword confirmity: Not yet.
            var flag = true;

            if (confirmpassword == null)
                flag = false;

            return flag;
        }
        public bool IsEmailSameAsConfirmedEmail(string useremil, string confirmemail)
        {
            //Task 1 - Testing if the email and confirm email are the same: Passed sucessfully.
            var flag = true;

            if (useremil != confirmemail)
                flag = false;

            return flag;

        }
        public bool IsPasswordSameAsConfirmedPassowrd(string password, string confirmpassword)
        {
            //Task 1 - Testing if the password and confirm password are the same: Passed sucessfully.
            var flag = true;

            if (password != confirmpassword)
                flag = false;

            return flag;
        }

    }
}
