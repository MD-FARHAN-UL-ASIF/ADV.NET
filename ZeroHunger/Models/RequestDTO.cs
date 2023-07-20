using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeroHunger.Models
{
    public class RequestDTO
    {
        public int id { get; set; }

        public string restaurant_name { get; set; }

        public string request_time { get; set; }

        public string maxPreservation_time { get; set; }

        public string food_item { get; set; }

        public string Quantity { get; set; }

        public string address { get; set; }
    }
}
