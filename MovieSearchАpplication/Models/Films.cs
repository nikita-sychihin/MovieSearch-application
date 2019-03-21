using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSearchАpplication.Models
{
    public class Films
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Genre { get; set; }
        public string Released { get; set; }
        public string Director { get; set; }

        public virtual ICollection<Actors> Actors { get; set; }

        public Films()
        {
            Actors = new List<Actors>();
        }
    }
}