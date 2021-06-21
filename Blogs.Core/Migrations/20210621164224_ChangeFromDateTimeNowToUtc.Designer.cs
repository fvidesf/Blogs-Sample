﻿// <auto-generated />
using System;
using Blogs.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blogs.Data.Migrations
{
    [DbContext(typeof(BlogsContext))]
    [Migration("20210621164224_ChangeFromDateTimeNowToUtc")]
    partial class ChangeFromDateTimeNowToUtc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blogs.Data.Model.AuthToken", b =>
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

                    b.HasIndex("Token")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("AuthTokens");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a66b4f70-cd47-49b4-a658-5b068e5fbd14"),
                            ExpirationDate = new DateTime(2021, 9, 21, 16, 42, 24, 325, DateTimeKind.Utc).AddTicks(5166),
                            Token = "skzUF6rtAW",
                            UserId = new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1")
                        },
                        new
                        {
                            Id = new Guid("72ac1666-be46-48d1-ab24-d7e91daf1724"),
                            ExpirationDate = new DateTime(2021, 9, 21, 16, 42, 24, 325, DateTimeKind.Utc).AddTicks(6653),
                            Token = "wrZTLJRCob",
                            UserId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        });
                });

            modelBuilder.Entity("Blogs.Data.Model.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

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

            modelBuilder.Entity("Blogs.Data.Model.Post", b =>
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

                    b.Property<DateTime>("SubmitDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("WriterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("WriterId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("553d1bae-2d51-4537-a513-a9d3ec784059"),
                            ApprovalDate = new DateTime(2021, 6, 19, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(1151),
                            IsDeleted = false,
                            StatusId = 1,
                            SubmitDate = new DateTime(2021, 6, 18, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(3335),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Title 1",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("e0db5f33-11e5-4370-b44b-49ce7fc41d08"),
                            ApprovalDate = new DateTime(2021, 6, 19, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(3967),
                            IsDeleted = false,
                            StatusId = 1,
                            SubmitDate = new DateTime(2021, 6, 18, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(3981),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Title 2",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("c50e9903-8de0-435b-aca4-896369387962"),
                            IsDeleted = false,
                            StatusId = 0,
                            SubmitDate = new DateTime(2021, 6, 17, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(3986),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Pending Title 1",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("1a217727-17ab-47ce-a5ee-b6665aea8f2d"),
                            IsDeleted = false,
                            StatusId = 0,
                            SubmitDate = new DateTime(2021, 6, 17, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(3989),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Pending Title 2",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("3fe177a0-b0d3-45ef-9560-c8bca83c4fd8"),
                            IsDeleted = false,
                            StatusId = 0,
                            SubmitDate = new DateTime(2021, 6, 17, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(3991),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Pending Title 3",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("f5227d24-ff33-4421-a9ed-7884142b3767"),
                            IsDeleted = false,
                            StatusId = 0,
                            SubmitDate = new DateTime(2021, 6, 17, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(3996),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Pending Title 4",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("8a6fc8b1-ab89-4540-bda8-f49d7f03f82b"),
                            IsDeleted = false,
                            StatusId = 2,
                            SubmitDate = new DateTime(2021, 6, 16, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(4004),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Rejected Title 1",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("8789ee6b-a13d-422f-8bb2-e20e7311f1b9"),
                            IsDeleted = false,
                            StatusId = 2,
                            SubmitDate = new DateTime(2021, 6, 16, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(4007),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Rejected Title 2",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("597dcc4c-2cb9-4098-8513-2757495cf317"),
                            IsDeleted = false,
                            StatusId = 2,
                            SubmitDate = new DateTime(2021, 6, 16, 16, 42, 24, 329, DateTimeKind.Utc).AddTicks(4009),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Rejected Title 3",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        });
                });

            modelBuilder.Entity("Blogs.Data.Model.Role", b =>
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

            modelBuilder.Entity("Blogs.Data.Model.Status", b =>
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

            modelBuilder.Entity("Blogs.Data.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1"),
                            Name = "Editor Number 1",
                            Password = "1234",
                            UserName = "editor"
                        },
                        new
                        {
                            Id = new Guid("e720064a-0ef2-4070-a9be-39db075bd485"),
                            Name = "Writer Number 1",
                            Password = "1234",
                            UserName = "writer"
                        },
                        new
                        {
                            Id = new Guid("6dd192b3-fa1f-46b1-bc91-dbdbf8cd40ce"),
                            Name = "Writer Number 2",
                            Password = "1234",
                            UserName = "writer2"
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
                        },
                        new
                        {
                            RolesId = new Guid("1d696eb7-147e-4570-af78-ab6f57770e60"),
                            UsersId = new Guid("6dd192b3-fa1f-46b1-bc91-dbdbf8cd40ce")
                        });
                });

            modelBuilder.Entity("Blogs.Data.Model.AuthToken", b =>
                {
                    b.HasOne("Blogs.Data.Model.User", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_AuthToken_User")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Blogs.Data.Model.Comment", b =>
                {
                    b.HasOne("Blogs.Data.Model.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .HasConstraintName("FK_Comments_Posts")
                        .IsRequired();

                    b.HasOne("Blogs.Data.Model.User", "Writer")
                        .WithMany("Comments")
                        .HasForeignKey("WriterId")
                        .HasConstraintName("FK_Comments_User");

                    b.Navigation("Post");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("Blogs.Data.Model.Post", b =>
                {
                    b.HasOne("Blogs.Data.Model.Status", "Status")
                        .WithMany("Posts")
                        .HasForeignKey("StatusId")
                        .HasConstraintName("FK_Posts_Status")
                        .IsRequired();

                    b.HasOne("Blogs.Data.Model.User", "Writer")
                        .WithMany("Posts")
                        .HasForeignKey("WriterId")
                        .HasConstraintName("FK_Posts_User")
                        .IsRequired();

                    b.Navigation("Status");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("Blogs.Data.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blogs.Data.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blogs.Data.Model.Post", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Blogs.Data.Model.Status", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Blogs.Data.Model.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Posts");

                    b.Navigation("Tokens");
                });
#pragma warning restore 612, 618
        }
    }
}