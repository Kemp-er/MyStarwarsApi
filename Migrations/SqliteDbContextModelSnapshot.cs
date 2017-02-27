﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MyStarwarsApi.Context;

namespace MyStarwarsApi.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    partial class SqliteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("MyStarwarsApi.Models.Character", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("Characterid");

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<string>("side");

                    b.HasKey("id");

                    b.HasIndex("Characterid");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("MyStarwarsApi.Models.Character", b =>
                {
                    b.HasOne("MyStarwarsApi.Models.Character")
                        .WithMany("charactersKilled")
                        .HasForeignKey("Characterid");
                });
        }
    }
}