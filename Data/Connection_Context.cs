using Entity_Framework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Data
{
    public class Connection_Context : DbContext
    {
        public DbSet< Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; }=null!;

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BoosStoreAPI:Integrated Security=True");

        }


    }
}
