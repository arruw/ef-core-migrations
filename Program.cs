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

                var posts = db.Posts.ToList();

                Console.WriteLine(JsonConvert.SerializeObject(posts, Formatting.Indented));
            }
        }
    }
}
