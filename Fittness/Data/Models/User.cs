﻿using Fittness.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace Fittness.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public UserTypeEnum UserType { get; set; }
    }
}
