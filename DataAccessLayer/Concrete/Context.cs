using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KG9QJV7;database=FinallProjectDb; integrated security = true;");
        }

        public DbSet<Foods> Foodss { get; set; }
        public DbSet<Profil> Profils { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Recipes> Recipess { get; set; }


    }
}