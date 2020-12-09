using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PddAdmin.Models
{
    public partial class PDDContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite("Data Source=pdd.db");

        //Add-Migration [migrationName]    /to create new migration
        //Update-Database    // to apply created last migration 

        //public PDDContext()
        //{
        //}

        public PDDContext(DbContextOptions<PDDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<QueryItem> QueryItem { get; set; }
        public virtual DbSet<Responses> Responses { get; set; }
    }
}
