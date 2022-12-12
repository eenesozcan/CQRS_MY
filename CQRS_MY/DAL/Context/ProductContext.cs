using CQRS_MY.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS_MY.DAL.Context
{
    public class ProductContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-07T8MF2\\DESKTOP-CSTSJL1\\MSSQLSERVER2019;initial catalog=ZCQRSDb;integrated security=true");
        }



        public DbSet<Product> Products { get; set; }

        
    }
}
