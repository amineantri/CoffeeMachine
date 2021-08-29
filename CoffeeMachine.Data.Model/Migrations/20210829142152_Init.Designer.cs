﻿// <auto-generated />
using System;
using CoffeeMachine.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoffeeMachine.Data.Model.Migrations
{
    [DbContext(typeof(CoffeeMachineContext))]
    [Migration("20210829142152_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoffeeMachine.Data.Model.Models.Badge", b =>
                {
                    b.Property<Guid>("badgeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("HistoryID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("badgeID");

                    b.HasIndex("HistoryID");

                    b.ToTable("Badge");
                });

            modelBuilder.Entity("CoffeeMachine.Data.Model.Models.BoissonType", b =>
                {
                    b.Property<Guid>("TypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BoissonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("TypeID");

                    b.ToTable("BoissonType");
                });

            modelBuilder.Entity("CoffeeMachine.Data.Model.Models.Command", b =>
                {
                    b.Property<Guid>("CommandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BoissonTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("HasMug")
                        .HasColumnType("bit");

                    b.Property<Guid?>("SugarID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CommandID");

                    b.HasIndex("BoissonTypeID");

                    b.HasIndex("SugarID");

                    b.ToTable("Commande");
                });

            modelBuilder.Entity("CoffeeMachine.Data.Model.Models.Person", b =>
                {
                    b.Property<Guid>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PersonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("badgeID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PersonID");

                    b.HasIndex("badgeID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("CoffeeMachine.Data.Model.Models.PurchaseHistory", b =>
                {
                    b.Property<Guid>("HistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BoissonTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CommandDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("SugarID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("HistoryID");

                    b.HasIndex("BoissonTypeID");

                    b.HasIndex("SugarID");

                    b.ToTable("PurchaseHistory");
                });

            modelBuilder.Entity("CoffeeMachine.Data.Model.Models.Sugar", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Sugar");
                });

            modelBuilder.Entity("CoffeeMachine.Data.Model.Models.Badge", b =>
                {
                    b.HasOne("CoffeeMachine.Data.Model.Models.PurchaseHistory", "history")
                        .WithMany()
                        .HasForeignKey("HistoryID");
                });

            modelBuilder.Entity("CoffeeMachine.Data.Model.Models.Command", b =>
                {
                    b.HasOne("CoffeeMachine.Data.Model.Models.BoissonType", "Boisson")
                        .WithMany()
                        .HasForeignKey("BoissonTypeID");

                    b.HasOne("CoffeeMachine.Data.Model.Models.Sugar", "Sugar")
                        .WithMany()
                        .HasForeignKey("SugarID");
                });

            modelBuilder.Entity("CoffeeMachine.Data.Model.Models.Person", b =>
                {
                    b.HasOne("CoffeeMachine.Data.Model.Models.Badge", "Badge")
                        .WithMany()
                        .HasForeignKey("badgeID");
                });

            modelBuilder.Entity("CoffeeMachine.Data.Model.Models.PurchaseHistory", b =>
                {
                    b.HasOne("CoffeeMachine.Data.Model.Models.BoissonType", "Boisson")
                        .WithMany()
                        .HasForeignKey("BoissonTypeID");

                    b.HasOne("CoffeeMachine.Data.Model.Models.Sugar", "Sugar")
                        .WithMany()
                        .HasForeignKey("SugarID");
                });
#pragma warning restore 612, 618
        }
    }
}
