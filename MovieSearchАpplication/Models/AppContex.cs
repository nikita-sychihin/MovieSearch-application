using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MovieSearchАpplication.Models
{
    public class AppContext : DbContext
    {
        public DbSet<Actors> Actor { get; set; }
        public DbSet<Films> Film { get; set; }
    }
}