using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using MVC6_App.Models;

namespace MVC6_App.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20151125090418_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC6_App.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");
                });

            modelBuilder.Entity("MVC6_App.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<int>("Price");

                    b.Property<string>("ProductName");

                    b.HasKey("ProductId");
                });

            modelBuilder.Entity("MVC6_App.Models.Product", b =>
                {
                    b.HasOne("MVC6_App.Models.Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });
        }
    }
}
