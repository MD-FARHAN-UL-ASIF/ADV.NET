using NewsPaper.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewsPaper.EF
{
    public class NPContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<News> Newses { get; set; }
    }
}