using System.ComponentModel.DataAnnotations;

namespace Fittness.Data.Models
{
    public class ProfileUser
    {
        [Key]
        public int Id { get; set; }
        public string Img { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }

    }
}

