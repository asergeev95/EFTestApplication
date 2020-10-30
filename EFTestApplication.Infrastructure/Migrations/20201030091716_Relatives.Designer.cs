﻿// <auto-generated />
using System;
using EFTestApplication.Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFTestApplication.Infrastructure.Migrations
{
    [DbContext(typeof(PersonsContext))]
    [Migration("20201030091716_Relatives")]
    partial class Relatives
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Persons")
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(4000);

                    b.Property<int>("Age");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Person","Persons");
                });

            modelBuilder.Entity("Core.Relative", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<Guid>("PersonId");

                    b.Property<string>("Relation")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Relative","Persons");
                });

            modelBuilder.Entity("Core.Relative", b =>
                {
                    b.HasOne("Core.Person", "Person")
                        .WithMany("Relatives")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
