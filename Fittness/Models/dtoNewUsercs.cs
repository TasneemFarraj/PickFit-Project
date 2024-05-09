using System.ComponentModel.DataAnnotations;

namespace Fittness.Models
{
    public class dtoNewUsercs
    {
  
            [Key]
            public int Id { get; set; }
            [Required]
            public string UserName { get; set; }
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            [Required]
            [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 100 characters.")]
            [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,100}$", ErrorMessage = "Password must include at least one uppercase, one lowercase, one number, and one symbol.")]
            public string Password { get; set; }
            [Required]
            public string conpassword { get; set; }
        }
    }
