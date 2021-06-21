﻿// <auto-generated />
using System;
using Blogs.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blogs.Data.Migrations
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
                            Id = new Guid("d0abe929-4a71-4250-9c0b-404baa25465f"),
                            ExpirationDate = new DateTime(2021, 9, 21, 1, 30, 19, 795, DateTimeKind.Local).AddTicks(1895),
                            Token = "skzUF6rtAW",
                            UserId = new Guid("93da2d99-6e0a-4afe-a039-ba290f10cac1")
                        },
                        new
                        {
                            Id = new Guid("3cf45bae-9167-4010-ad38-eaad4974fd88"),
                            ExpirationDate = new DateTime(2021, 9, 21, 1, 30, 19, 795, DateTimeKind.Local).AddTicks(8566),
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
                            Id = new Guid("ef510b14-9140-45e9-9842-01c83dce0ded"),
                            ApprovalDate = new DateTime(2021, 6, 19, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(2214),
                            IsDeleted = false,
                            StatusId = 1,
                            SubmitDate = new DateTime(2021, 6, 18, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(3822),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Title 1",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("382e5826-b839-4df6-9146-25a4a20320d0"),
                            ApprovalDate = new DateTime(2021, 6, 19, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4262),
                            IsDeleted = false,
                            StatusId = 1,
                            SubmitDate = new DateTime(2021, 6, 18, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4279),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Title 2",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("e3f449f4-0580-456c-a6c2-11ef7d352c1d"),
                            IsDeleted = false,
                            StatusId = 0,
                            SubmitDate = new DateTime(2021, 6, 17, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4283),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Pending Title 1",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("cf321898-5aa1-4f2a-a902-60984c05af43"),
                            IsDeleted = false,
                            StatusId = 0,
                            SubmitDate = new DateTime(2021, 6, 17, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4286),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Pending Title 2",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("5136d26b-bd2a-4a1d-865d-64d72a424e8f"),
                            IsDeleted = false,
                            StatusId = 0,
                            SubmitDate = new DateTime(2021, 6, 17, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4289),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Pending Title 3",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("dfd60ef4-58ea-4f48-a8f6-8d65afda5af3"),
                            IsDeleted = false,
                            StatusId = 0,
                            SubmitDate = new DateTime(2021, 6, 17, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4294),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Pending Title 4",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("c13e6148-479c-4f18-b085-b14e06e5cabe"),
                            IsDeleted = false,
                            StatusId = 2,
                            SubmitDate = new DateTime(2021, 6, 16, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4303),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Rejected Title 1",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("8cc79c13-2f5b-4a1e-819d-f19f995859fe"),
                            IsDeleted = false,
                            StatusId = 2,
                            SubmitDate = new DateTime(2021, 6, 16, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4306),
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec viverra orci augue, sit amet ornare mauris ullamcorper quis. Phasellus mollis mi id vehicula egestas. Vestibulum sodales dolor metus. \r\n                            Pellentesque a purus vel sapien scelerisque rutrum. Sed sed facilisis metus. \r\n                            Donec mollis accumsan neque ac pharetra",
                            Title = "Post Rejected Title 2",
                            WriterId = new Guid("e720064a-0ef2-4070-a9be-39db075bd485")
                        },
                        new
                        {
                            Id = new Guid("d978e6b3-6409-49c1-9642-ddc3477a2f43"),
                            IsDeleted = false,
                            StatusId = 2,
                            SubmitDate = new DateTime(2021, 6, 16, 1, 30, 19, 799, DateTimeKind.Local).AddTicks(4309),
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
