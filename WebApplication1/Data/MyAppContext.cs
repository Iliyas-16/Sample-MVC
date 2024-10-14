/*using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Data
{
    public class MyAppContext :DbContext
    {
        public  MyAppContext(DbContextOptions<MyAppContext> options)
        {

        }
        public DbSet<Item> Items { get; set; }

    }
}*/
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options)
            : base(options) // This passes the options to the DbContext base class
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}



