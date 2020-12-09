//using Microsoft.EntityFrameworkCore;
//using PddAdmin.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace PddAdmin.Data
//{
//    public class ApplicationDbContext : DbContext
//    {
//        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
//        //{

//        //}
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlite("Filename=PDD.db");
//        }

//        public DbSet<QueryItem> QueryItems { get; set; }
//        public DbSet<Responses> Responses { get; set; }
        
//    }
//}
