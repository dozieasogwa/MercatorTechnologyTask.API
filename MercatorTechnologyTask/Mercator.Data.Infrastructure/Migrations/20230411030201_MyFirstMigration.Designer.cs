﻿// <auto-generated />
using System;
using Mercator.Data.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mercator.Data.Infrastructure.Migrations
{
    [DbContext(typeof(MercatorContext))]
    [Migration("20230411030201_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Mercator.Data.Domain.AggregateModel.Entities.Merchant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Merchants");
                });

            modelBuilder.Entity("Mercator.Data.Domain.AggregateModel.Entities.Terminal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("MerchantId1")
                        .HasColumnType("bigint");

                    b.Property<string>("Terminaltype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MerchantId1");

                    b.ToTable("Terminals");
                });

            modelBuilder.Entity("Mercator.Data.Domain.AggregateModel.Entities.Transaction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CardType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RRN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("TerminalId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TerminalId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Mercator.Data.Domain.AggregateModel.Entities.Terminal", b =>
                {
                    b.HasOne("Mercator.Data.Domain.AggregateModel.Entities.Merchant", "Merchant")
                        .WithMany("Terminals")
                        .HasForeignKey("MerchantId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Merchant");
                });

            modelBuilder.Entity("Mercator.Data.Domain.AggregateModel.Entities.Transaction", b =>
                {
                    b.HasOne("Mercator.Data.Domain.AggregateModel.Entities.Terminal", null)
                        .WithMany("Transactions")
                        .HasForeignKey("TerminalId");
                });

            modelBuilder.Entity("Mercator.Data.Domain.AggregateModel.Entities.Merchant", b =>
                {
                    b.Navigation("Terminals");
                });

            modelBuilder.Entity("Mercator.Data.Domain.AggregateModel.Entities.Terminal", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}