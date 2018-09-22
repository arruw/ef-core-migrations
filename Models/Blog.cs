using System;
using System.Collections.Generic;

namespace EfCoreMigrations.Models
{
    public class Blog
    {
        public int Id { get; set; }

        public string Title { get; set; } 

        public string Description { get; set; }

        public string Author { get; set; }

        public int Readers { get; set; }

        public virtual ICollection<Post> Posts { get; set; }      
    }
}