﻿// <auto-generated />
using System;
using Blogs.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blogs.Core.Migrations
{
    [DbContext(typeof(BlogsContext))]
    partial class BlogsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blogs.Core.Model.AuthToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AuthTokens");

                    b.HasData(
                        new
                        {
                            Id = new Guid("40788c8e-3754-401b-8256-9426f5b25ae4"),
                            ExpirationDate = new DateTime(2021, 9, 19, 17, 44, 19, 165, DateTimeKind.Local).AddTicks(4066),
                            Token = "skzUF6rtAW",
                            UserId = new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1")
                        });
                });

            modelBuilder.Entity("Blogs.Core.Model.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("WriterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("WriterId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Blogs.Core.Model.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<DateTime?>("ApprovalDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("WriterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("WriterId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Blogs.Core.Model.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1d696eb7-147e-4570-af78-ab6f57770e60"),
                            Name = "Writer"
                        },
                        new
                        {
                            Id = new Guid("c8bbc75b-b16f-4cd8-aa8e-42ee8ed9b184"),
                            Name = "Editor"
                        });
                });

            modelBuilder.Entity("Blogs.Core.Model.Status", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            Id = 0,
                            Name = "PendingApproval"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Approved"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rejected"
                        });
                });

            modelBuilder.Entity("Blogs.Core.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1"),
                            Email = "editor@sample.com",
                            Password = "1234"
                        },
                        new
                        {
                            Id = new Guid("e720064a-0ef2-4070-a9be-39db075bd485"),
                            Email = "writer@sample.com",
                            Password = "1234"
                        });
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<Guid>("RolesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoleUser");

                    b.HasData(
                        new
                        {
                            RolesId = new Guid("c8bbc75b-b16f-4cd8-aa8e-42ee8ed9b184"),
                            UsersId = new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1")
                        },
                        new
                        {
                            RolesId = new Guid("1d696eb7-147e-4570-af78-ab6f57770e60"),
                            UsersId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        });
                });

            modelBuilder.Entity("Blogs.Core.Model.AuthToken", b =>
                {
                    b.HasOne("Blogs.Core.Model.User", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_AuthToken_User")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Blogs.Core.Model.Comment", b =>
                {
                    b.HasOne("Blogs.Core.Model.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .HasConstraintName("FK_Comments_Posts")
                        .IsRequired();

                    b.HasOne("Blogs.Core.Model.User", "Writer")
                        .WithMany("Comments")
                        .HasForeignKey("WriterId")
                        .HasConstraintName("FK_Comments_User");

                    b.Navigation("Post");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("Blogs.Core.Model.Post", b =>
                {
                    b.HasOne("Blogs.Core.Model.Status", "Status")
                        .WithMany("Posts")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("FK_Posts_Status")
                        .IsRequired();

                    b.HasOne("Blogs.Core.Model.User", "Writer")
                        .WithMany("Posts")
                        .HasForeignKey("WriterId")
                        .HasConstraintName("FK_Posts_User")
                        .IsRequired();

                    b.Navigation("Status");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("Blogs.Core.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blogs.Core.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blogs.Core.Model.Post", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Blogs.Core.Model.Status", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Blogs.Core.Model.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Posts");

                    b.Navigation("Tokens");
                });
#pragma warning restore 612, 618
        }
    }
}
