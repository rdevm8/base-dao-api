﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using base_dao_api.Data;

#nullable disable

namespace base_dao_api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220805050025_v0.045")]
    partial class v0045
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("base_dao_api.Models.CodeDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CodeHeaderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDttm")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("DetailCd")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDttm")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("CodeHeaderId");

                    b.HasIndex("DetailCd")
                        .IsUnique();

                    b.ToTable("CodeDetails");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2ebad7da-393f-4b8c-866c-943e2da5f4eb"),
                            CodeHeaderId = new Guid("3f4818e6-0882-4789-83f5-178d4f2c25f6"),
                            CreateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2523),
                            CreatedBy = "SYSTEM",
                            Description = "Admin User",
                            DetailCd = "ROLE-SYSTEM",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2524),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("3d19c08e-b292-4130-b6c8-1f4262fb5de1"),
                            CodeHeaderId = new Guid("3f4818e6-0882-4789-83f5-178d4f2c25f6"),
                            CreateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2527),
                            CreatedBy = "SYSTEM",
                            Description = "Admin User",
                            DetailCd = "ROLE-ADMIN",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2527),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("9165d638-f82a-422f-b0ef-0e190c2d424a"),
                            CodeHeaderId = new Guid("3f4818e6-0882-4789-83f5-178d4f2c25f6"),
                            CreateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2529),
                            CreatedBy = "SYSTEM",
                            Description = "Normal User",
                            DetailCd = "ROLE-NORMAL",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2529),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("862d05de-ea2f-48a4-a502-bcefd4c3c513"),
                            CodeHeaderId = new Guid("2c60dd34-6c88-4727-a0f6-f85c8fc464a2"),
                            CreateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2532),
                            CreatedBy = "SYSTEM",
                            Description = "Pool OPEN",
                            DetailCd = "PSTATUS-OPEN",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2532),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("f6dcddd3-2999-4813-98e8-5d69265f08eb"),
                            CodeHeaderId = new Guid("2c60dd34-6c88-4727-a0f6-f85c8fc464a2"),
                            CreateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2535),
                            CreatedBy = "SYSTEM",
                            Description = "Pool ONGOING",
                            DetailCd = "PSTATUS-ONGOING",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2535),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("8001e627-ccc2-4728-bff3-d7a747f731fc"),
                            CodeHeaderId = new Guid("2c60dd34-6c88-4727-a0f6-f85c8fc464a2"),
                            CreateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2538),
                            CreatedBy = "SYSTEM",
                            Description = "Pool CLOSED",
                            DetailCd = "PSTATUS-CLOSED",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2538),
                            UpdatedBy = "SYSTEM"
                        });
                });

            modelBuilder.Entity("base_dao_api.Models.CodeHeader", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDttm")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("HeaderCd")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDttm")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("HeaderCd")
                        .IsUnique();

                    b.ToTable("CodeHeaders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3f4818e6-0882-4789-83f5-178d4f2c25f6"),
                            CreateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(1958),
                            CreatedBy = "SYSTEM",
                            Description = "CodeHeader for User Roles",
                            HeaderCd = "ROLE",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(1961),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("2c60dd34-6c88-4727-a0f6-f85c8fc464a2"),
                            CreateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(1965),
                            CreatedBy = "SYSTEM",
                            Description = "CodeHeader for Pool Statuses",
                            HeaderCd = "PSTATUS",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(1966),
                            UpdatedBy = "SYSTEM"
                        });
                });

            modelBuilder.Entity("base_dao_api.Models.Faq", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("CreateDttm")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("UpdateDttm")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("Order")
                        .IsUnique();

                    b.ToTable("Faqs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1a461d43-5c88-4f09-9395-61100b073add"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3043),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Order = 1,
                            Question = "What is Wick's Crew?",
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3044),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("f2c99f6f-00d0-44f9-80c6-539d5ea36838"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3046),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Order = 2,
                            Question = "What are Pooling Considerations?",
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3047),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("43715d08-0bd8-4472-9af2-7fb4dc0a9023"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3052),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Order = 3,
                            Question = "What are the Pooling Rules?",
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3052),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("88425971-4192-400e-adda-f56b456ea351"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3053),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Order = 4,
                            Question = "What are the Available Pools?",
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3054),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("95cb891d-7e62-4d28-95b0-f265cb0dd9dc"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3055),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Order = 5,
                            Question = "How are the Funds Distributed?",
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3055),
                            UpdatedBy = "SYSTEM"
                        });
                });

            modelBuilder.Entity("base_dao_api.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDttm")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("UpdateDttm")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("WalletAddress")
                        .IsRequired()
                        .HasMaxLength(42)
                        .HasColumnType("nvarchar(42)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("base_dao_api.Models.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDttm")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDttm")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("base_dao_api.Models.CodeDetail", b =>
                {
                    b.HasOne("base_dao_api.Models.CodeHeader", "CodeHeader")
                        .WithMany("CodeDetails")
                        .HasForeignKey("CodeHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CodeHeader");
                });

            modelBuilder.Entity("base_dao_api.Models.UserRole", b =>
                {
                    b.HasOne("base_dao_api.Models.CodeDetail", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("base_dao_api.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("base_dao_api.Models.CodeHeader", b =>
                {
                    b.Navigation("CodeDetails");
                });

            modelBuilder.Entity("base_dao_api.Models.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
