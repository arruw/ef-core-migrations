using System;
using System.Linq;
using EfCoreMigrations.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace EfCoreMigrations
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BlogContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                var blogs = db.Blogs.ToList();

                Console.WriteLine(JsonConvert.SerializeObject(blogs, Formatting.Indented));
            }
        }
    }
}
