using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using 管理系统.Models;

namespace 管理系统.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<管理系统.Models.BuyMerchandiseList> BuyMerchandiseList { get; set; }
        public DbSet<管理系统.Models.OutMerchandiseList> OutMerchandiseList { get; set; }
        public DbSet<管理系统.Models.Merchandise> Merchandise { get; set; }
        public DbSet<管理系统.Models.BuyMerchandise> BuyMerchandise { get; set; }
        public DbSet<管理系统.Models.OutMerchandise> OutMerchandise { get; set; }
    }
}
