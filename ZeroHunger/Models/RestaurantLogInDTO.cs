using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeroHunger.Models
{
    public class RestaurantLogInDTO
    {
        [Required(ErrorMessage = "Enter your email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Enter your password")]
        public string password { get; set; }
    }
}