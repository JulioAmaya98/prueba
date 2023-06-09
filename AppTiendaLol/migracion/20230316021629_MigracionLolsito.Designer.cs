﻿// <auto-generated />
using System;
using AppTiendaLol;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppTiendaLol.migracion
{
    [DbContext(typeof(AppDbContex))]
    [Migration("20230316021629_MigracionLolsito")]
    partial class MigracionLolsito
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppTiendaLol.Models.Producto", b =>
                {
                    b.Property<int>("id_producto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_producto"));

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha_ingreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("precio")
                        .HasColumnType("float");

                    b.HasKey("id_producto");

                    b.ToTable("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
