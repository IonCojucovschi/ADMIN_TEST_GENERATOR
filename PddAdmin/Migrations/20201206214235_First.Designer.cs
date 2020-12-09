﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PddAdmin.Models;

namespace PddAdmin.Migrations
{
    [DbContext(typeof(PDDContext))]
    [Migration("20201206214235_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("PddAdmin.Models.QueryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<string>("ImageUri");

                    b.Property<string>("Query");

                    b.Property<string>("Thema");

                    b.HasKey("Id");

                    b.ToTable("QueryItem");
                });

            modelBuilder.Entity("PddAdmin.Models.Responses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsRight");

                    b.Property<int>("QueryId");

                    b.Property<string>("Response");

                    b.HasKey("Id");

                    b.HasIndex("QueryId");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("PddAdmin.Models.Responses", b =>
                {
                    b.HasOne("PddAdmin.Models.QueryItem", "Query")
                        .WithMany("Responses")
                        .HasForeignKey("QueryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}