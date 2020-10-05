﻿// <auto-generated />
using System;
using GoodBooks.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GoodBooks.Data.Migrations
{
    [DbContext(typeof(GoodBooksDbContext))]
    [Migration("20201002114657_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("GoodBooks.Data.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("GoodBooks.Data.Models.BookReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("BookId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ReviewAuthor")
                        .HasColumnType("text");

                    b.Property<string>("ReviewContent")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("BooksReviews");
                });

            modelBuilder.Entity("GoodBooks.Data.Models.BookReview", b =>
                {
                    b.HasOne("GoodBooks.Data.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");
                });
#pragma warning restore 612, 618
        }
    }
}