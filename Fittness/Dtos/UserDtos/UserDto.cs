using Fittness.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace Fittness.Dtos.UserDtos
{
    public class UserDto
    {
        public int? Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public UserTypeEnum UserType { get; set; }
        public string Token { get; set; }
    }
    public class WriteUserDto
    {
        public int? Id { get; set; }
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Email must be in a valid format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z\d]).{6,}$",
        ErrorMessage = "Password must contain at least one lowercase character, one uppercase character, one digit, and one special character.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string PasswordConfirm { get; set; }
        public UserTypeEnum UserType { get; set; }
    }
    public class LoginDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
