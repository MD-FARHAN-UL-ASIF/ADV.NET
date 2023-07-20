using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZeroHunger.Models
{
    public class CollectionDTO
    {
        public int id { get; set; }
        public string status { get; set; }
        public string restaurant_name { get; set; }
        public string request_date { get; set; }
        public string maxPreservation_time { get; set; }
        public int quantity { get;}
        public string pickup_date { get; set; }
        public string drop_address { get; set; }

    }
}