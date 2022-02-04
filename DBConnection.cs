using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace customDesktopApp
{
    internal class DBConnection : DbContext
    {
        public DBConnection()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-ILIVC2L\SQLEXPRESS;Database=Shop;Trusted_Connection=true;");
        }
    }
}
