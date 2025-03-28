﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ValueAPI.Data;

#nullable disable

namespace ValueAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ValueAPI.Models.Point", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Senderid")
                        .HasColumnType("int");

                    b.Property<int>("Userid")
                        .HasColumnType("int");

                    b.Property<double>("average")
                        .HasColumnType("float");

                    b.Property<int>("fifth")
                        .HasColumnType("int");

                    b.Property<int>("first")
                        .HasColumnType("int");

                    b.Property<int>("fourth")
                        .HasColumnType("int");

                    b.Property<int>("second")
                        .HasColumnType("int");

                    b.Property<int>("third")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("ValueAPI.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("taverage")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
