using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeroHunger.Models
{
    public class EmployeeDTO
    {
        public int id { get; set; }

        [Required(ErrorMessage ="Enter Your First Name")]
        public string firstname { get; set; }

        [Required(ErrorMessage ="Enter Your Last Name")]
        public string lastname { get; set; }

        [Required(ErrorMessage ="Enter Your Email")]
        public string email { get; set; }

        [Required(ErrorMessage ="Select Your Gender")]
        public string gender { get; set; }

        [Required(ErrorMessage = "Enter Your Phone number")]
        public string  phone{ get; set; }

        [Required(ErrorMessage = "Please provide your Position")]
        public string position { get; set; }

        [Required(ErrorMessage = "Please provide your Address")]
        public string address { get; set; }

        [Required(ErrorMessage = "Please provide your Age")]
        public string age { get; set; }

        [Required(ErrorMessage = "Please provide your Password")]
        public string password { get; set; }
    }

}
