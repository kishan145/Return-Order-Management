﻿// <auto-generated />
using ChargeProceesing.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChargeProceesing.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220515101207_PackageandDeliverySecond")]
    partial class PackageandDeliverySecond
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChargeProceesing.API.Models.PackModel", b =>
                {
                    b.Property<string>("componentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("deliveryCharges")
                        .HasColumnType("bigint");

                    b.Property<long>("packageCharges")
                        .HasColumnType("bigint");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<long>("requestId")
                        .HasColumnType("bigint");

                    b.Property<long>("totalCharges")
                        .HasColumnType("bigint");

                    b.ToTable("PackModels");
                });
#pragma warning restore 612, 618
        }
    }
}
