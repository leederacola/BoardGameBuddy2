using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BGB2.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Game> Library { get; set; }
    }
}