﻿// <auto-generated />
using ContactManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactManager.Migrations
{
    [DbContext(typeof(ContactContext))]
    partial class ContactContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContactManager.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Family"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Friend"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Work"
                        });
                });

            modelBuilder.Entity("ContactManager.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            CategoryId = 2,
                            Email = "delores@hotmail.com",
                            FirstName = "Delores",
                            LastName = "Del Rio",
                            Phone = "555-987-6543"
                        },
                        new
                        {
                            ContactId = 2,
                            CategoryId = 3,
                            Email = "efren@aol.com",
                            FirstName = "Efren",
                            LastName = "Herrera",
                            Phone = "555-456-7890"
                        },
                        new
                        {
                            ContactId = 3,
                            CategoryId = 1,
                            Email = "MaryEllen@yahoo.com",
                            FirstName = "Mary Ellen",
                            LastName = "Walton",
                            Phone = "555-123-4567"
                        });
                });

            modelBuilder.Entity("ContactManager.Models.Contact", b =>
                {
                    b.HasOne("ContactManager.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
