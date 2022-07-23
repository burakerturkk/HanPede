using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HanPerde.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("server = 77.245.159.10\\MSSQLSERVER2019; database=DbHanPerde;user=adminhanperde;password=2HNCi73MAnRmpAd ");
        }
        public DbSet<AccessoryProduct> AccessoryProducts { get; set; }
        public DbSet<CurtainProduct> CurtainProducts { get; set; }
        public DbSet<CategoryAccessory> CategoryAccessories { get; set; }
        public DbSet<CategoryCurtain> CategoryCurtains { get; set; }
        public DbSet<Admin> Admins { get; set; }


    }
}
