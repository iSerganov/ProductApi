﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductDataAccess;

namespace ProductDataAccess.Migrations
{
    [DbContext(typeof(AwesomeDbContext))]
    partial class AwesomeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductCore.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = new Guid("eaf20c83-b075-4ced-94ed-841a3dacb8bd"), Name = "Food" },
                        new { Id = new Guid("67ba1043-62da-4a8b-99a3-8e4249f899d5"), Name = "Electronics" },
                        new { Id = new Guid("3ef33c24-234c-46d8-9042-fb3c00a7b6ab"), Name = "Cars" }
                    );
                });

            modelBuilder.Entity("ProductCore.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CategoryId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(9,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = new Guid("ae72ef5d-9328-4fc6-877c-129225933928"), CategoryId = new Guid("eaf20c83-b075-4ced-94ed-841a3dacb8bd"), IsActive = true, Name = "Milk GMZ", Price = 9.99m },
                        new { Id = new Guid("603a3303-1060-4e00-acae-c238481a361c"), CategoryId = new Guid("67ba1043-62da-4a8b-99a3-8e4249f899d5"), IsActive = true, Name = "TV Samsung 40\"", Price = 2999.99m },
                        new { Id = new Guid("cd45e298-8b20-46e9-b638-32e6aa978a2b"), CategoryId = new Guid("3ef33c24-234c-46d8-9042-fb3c00a7b6ab"), IsActive = true, Name = "Toyota Tundra V8 4.7L", Price = 64999.99m }
                    );
                });

            modelBuilder.Entity("ProductCore.Entities.Product", b =>
                {
                    b.HasOne("ProductCore.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.SetNull);
                });
#pragma warning restore 612, 618
        }
    }
}
