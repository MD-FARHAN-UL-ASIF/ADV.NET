using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewsPaper.EF.Models
{
    public class News
    {
        public int id { get; set; }

        public string tittle { get; set; }

        public DateTime date { get; set; }

        [ForeignKey("Category")]
        public int cid { get; set; }

        public string description { get; set; }

        public virtual Category Category { get; set; }
    }
}