using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeroHunger.Models
{
    public class EmployeeLogInDTO
    {
        [Required(ErrorMessage ="Enter valid Email")]
        public string email { get; set; }

        [Required(ErrorMessage ="Enter your Password")]
        public string password { get; set; }

        public string position { get; set; }
    }
}