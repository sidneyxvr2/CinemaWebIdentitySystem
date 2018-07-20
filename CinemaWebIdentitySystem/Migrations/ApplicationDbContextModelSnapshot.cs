﻿// <auto-generated />
using CinemaWebIdentitySystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CinemaWebIdentitySystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CinemaWebIdentitySystem.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<bool>("Ativa");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("Estudante");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Nome")
                        .HasMaxLength(50);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CinemaWebIdentitySystem.Models.Assento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativa");

                    b.Property<string>("Fila")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<int>("Numero");

                    b.Property<int>("SalaId");

                    b.HasKey("Id");

                    b.HasIndex("SalaId");

                    b.ToTable("Assentos");
                });

            modelBuilder.Entity("CinemaWebIdentitySystem.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativa");

                    b.Property<string>("Bairro")
                        .HasMaxLength(50);

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Estado");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Numero");

                    b.Property<string>("Rua")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("CinemaWebIdentitySystem.Models.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativa");

                    b.Property<int>("Classificacao");

                    b.Property<int>("GeneroId");

                    b.Property<byte[]>("Imagem");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.HasIndex("GeneroId");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("CinemaWebIdentitySystem.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("CinemaWebIdentitySystem.Models.Ingresso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssentoId");

                    b.Property<bool>("Estudante");

                    b.Property<int>("SessaoId");

                    b.Property<int>("VendaId");

                    b.HasKey("Id");

                    b.HasIndex("AssentoId");

                    b.HasIndex("SessaoId");

                    b.HasIndex("VendaId");

                    b.ToTable("Ingressos");
                });

            modelBuilder.Entity("CinemaWebIdentitySystem.Models.Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativa");

                    b.Property<int>("CinemaId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("QuantidadeAssentos");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("CinemaWebIdentitySystem.Models.Sessao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativa");

                    b.Property<int>("CinemaId");

                    b.Property<int>("FilmeId");

                    b.Property<DateTime>("Horario");

                    b.Property<decimal>("Preco");

                    b.Property<int>("SalaId");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("FilmeId");

                    b.HasIndex("SalaId");

                    b.ToTable("Sessoes");
                });

            modelBuilder.Entity("CinemaWebIdentitySystem.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ApplicationUserId");

                    b.Property<int>("Cartao");

                    b.Property<DateTime>("Data");

                    b.Property<int>("Inteira");

                    b.Property<int>("Meia");

                    b.Property<int>("SessaoId");

                    b.Property<string>("UsuarioId");

                    b.Property<decimal>("ValorTotal");

                    b.HasKey("Id");

                    b.HasIndex("SessaoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CinemaWebIdentitySystem.Models.Assento", b =>
                {
                    b.HasOne("CinemaWebIdentitySystem.Models.Sala", "Sala")
                        .WithMany("Assentos")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CinemaWebIdentitySystem.Models.Filme", b =>
                {
                    b.HasOne("CinemaWebIdentitySystem.Models.Genero", "Genero")
                        .WithMany("Filmes")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CinemaWebIdentitySystem.Models.Ingresso", b =>
                {
                    b.HasOne("CinemaWebIdentitySystem.Models.Assento", "Assento")
                        .WithMany("Ingressos")
                        .HasForeignKey("AssentoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CinemaWebIdentitySystem.Models.Sessao", "Sessao")
                        .WithMany("Ingressos")
                        .HasForeignKey("SessaoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CinemaWebIdentitySystem.Models.Venda", "Venda")
                        .WithMany("Ingressos")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CinemaWebIdentitySystem.Models.Sala", b =>
                {
                    b.HasOne("CinemaWebIdentitySystem.Models.Cinema", "Cinema")
                        .WithMany("Salas")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CinemaWebIdentitySystem.Models.Sessao", b =>
                {
                    b.HasOne("CinemaWebIdentitySystem.Models.Cinema", "Cinema")
                        .WithMany("Sessoes")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CinemaWebIdentitySystem.Models.Filme", "Filme")
                        .WithMany("Sessoes")
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CinemaWebIdentitySystem.Models.Sala", "Sala")
                        .WithMany("Sessoes")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CinemaWebIdentitySystem.Models.Venda", b =>
                {
                    b.HasOne("CinemaWebIdentitySystem.Models.Sessao", "Sessao")
                        .WithMany("Vendas")
                        .HasForeignKey("SessaoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CinemaWebIdentitySystem.Models.ApplicationUser", "Usuario")
                        .WithMany("Vendas")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CinemaWebIdentitySystem.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CinemaWebIdentitySystem.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinemaWebIdentitySystem.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CinemaWebIdentitySystem.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
