using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeroHunger.Models
{
    public class RestaurantDTO
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please Enter the Restaurant Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Please Enter your First Name")]
        public string address { get; set; }

        [Required(ErrorMessage = "Please Enter your contact number")]
        public string contact { get; set; }

        [Required(ErrorMessage = "Please Enter your email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Please Select your Restaurant Type")]
        public string type { get; set; }

        [Required(ErrorMessage = "Please set password")]
        public string password { get; set; }
    }
}