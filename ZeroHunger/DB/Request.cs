//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZeroHunger.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
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