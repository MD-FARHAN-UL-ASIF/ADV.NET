using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Web;

namespace Portfolio.Models
{
    public class MyProfile
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Nation { get; set; }
        public string BloodGroup { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string[] Hobbies { get; set; }
    }
}