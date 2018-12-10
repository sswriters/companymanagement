﻿// <auto-generated />
using CompanyManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CompanyManagementSystem.Migrations
{
    [DbContext(typeof(cmsDBContext))]
    [Migration("20181210122119_db2")]
    partial class db2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CompanyManagementSystem.Models.People", b =>
                {
                    b.Property<string>("name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("mail");

                    b.Property<string>("pass");

                    b.Property<string>("phone");

                    b.Property<string>("projects");

                    b.Property<string>("role");

                    b.HasKey("name");

                    b.ToTable("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
