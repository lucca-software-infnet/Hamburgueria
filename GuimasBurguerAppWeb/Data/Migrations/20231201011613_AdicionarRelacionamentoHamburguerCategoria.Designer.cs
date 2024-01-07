﻿// <auto-generated />
using System;
using GuimasBurguerAppWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GuimasBurguerAppWeb.Data.Migrations
{
    [DbContext(typeof(HamburgueriaDbContext))]
    [Migration("20231201011613_AdicionarRelacionamentoHamburguerCategoria")]
    partial class AdicionarRelacionamentoHamburguerCategoria
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoriaHamburguer", b =>
                {
                    b.Property<int>("CategoriasCategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("HamburgueresHamburguerId")
                        .HasColumnType("int");

                    b.HasKey("CategoriasCategoriaId", "HamburgueresHamburguerId");

                    b.HasIndex("HamburgueresHamburguerId");

                    b.ToTable("CategoriaHamburguer");
                });

            modelBuilder.Entity("GuimasBurguerAppWeb.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("GuimasBurguerAppWeb.Models.Hamburguer", b =>
                {
                    b.Property<int>("HamburguerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HamburguerId"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EntregaExpressa")
                        .HasColumnType("bit");

                    b.Property<string>("ImagemUri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("HamburguerId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Hamburguer");
                });

            modelBuilder.Entity("GuimasBurguerAppWeb.Models.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarcaId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarcaId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("CategoriaHamburguer", b =>
                {
                    b.HasOne("GuimasBurguerAppWeb.Models.Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriasCategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GuimasBurguerAppWeb.Models.Hamburguer", null)
                        .WithMany()
                        .HasForeignKey("HamburgueresHamburguerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GuimasBurguerAppWeb.Models.Hamburguer", b =>
                {
                    b.HasOne("GuimasBurguerAppWeb.Models.Marca", null)
                        .WithMany("Hamburgueres")
                        .HasForeignKey("MarcaId");
                });

            modelBuilder.Entity("GuimasBurguerAppWeb.Models.Marca", b =>
                {
                    b.Navigation("Hamburgueres");
                });
#pragma warning restore 612, 618
        }
    }
}
