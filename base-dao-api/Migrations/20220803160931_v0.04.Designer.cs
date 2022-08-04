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
    [Migration("20220803160931_v0.04")]
    partial class v004
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

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("DetailCd")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateDttm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CodeHeaderId");

                    b.ToTable("CodeDetails");

                    b.HasData(
                        new
                        {
                            Id = new Guid("93ca2536-db18-4df4-87e9-59cdbfe26daa"),
                            CodeHeaderId = new Guid("cf4b52a1-013f-4976-b98a-7deccc0d76dc"),
                            CreateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2687),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Description = "Admin User",
                            DetailCd = "ROLE-ADMIN",
                            IsActive = true,
                            UpdateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2688),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("d0133e46-3bc5-41ee-bcdf-94501fa3dca5"),
                            CodeHeaderId = new Guid("cf4b52a1-013f-4976-b98a-7deccc0d76dc"),
                            CreateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2692),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Description = "Normal User",
                            DetailCd = "ROLE-NORMAL",
                            IsActive = true,
                            UpdateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2692),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("3728026c-18c2-4cb8-bb29-82a3d54f0f79"),
                            CodeHeaderId = new Guid("aeff3c75-5050-4bdc-9f1d-b73cb82f066f"),
                            CreateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2694),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Description = "Pool OPEN",
                            DetailCd = "PSTATUS-OPEN",
                            IsActive = true,
                            UpdateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2694),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("51aab4c4-1a1f-49d4-9665-ac932f5b3349"),
                            CodeHeaderId = new Guid("aeff3c75-5050-4bdc-9f1d-b73cb82f066f"),
                            CreateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2696),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Description = "Pool ONGOING",
                            DetailCd = "PSTATUS-ONGOING",
                            IsActive = true,
                            UpdateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2697),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("dd43c4bd-4117-4978-acb4-bfffeaf5c64d"),
                            CodeHeaderId = new Guid("aeff3c75-5050-4bdc-9f1d-b73cb82f066f"),
                            CreateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2698),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Description = "Pool CLOSED",
                            DetailCd = "PSTATUS-CLOSED",
                            IsActive = true,
                            UpdateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2699),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("base_dao_api.Models.CodeHeader", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDttm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("HeaderCd")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateDttm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("CodeHeaders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cf4b52a1-013f-4976-b98a-7deccc0d76dc"),
                            CreateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2523),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Description = "CodeHeader for User Roles",
                            HeaderCd = "ROLE",
                            IsActive = true,
                            UpdateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2533),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("aeff3c75-5050-4bdc-9f1d-b73cb82f066f"),
                            CreateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2540),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Description = "CodeHeader for Pool Statuses",
                            HeaderCd = "PSTATUS",
                            IsActive = true,
                            UpdateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2541),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
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

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("UpdateDttm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Faqs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7c0420c1-22c1-4f1e-be87-4e2871fdb348"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2805),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            Question = "What is Wick's Crew?",
                            UpdateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2805),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("9111dd86-0ca0-4dec-8f84-ded2bae53516"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2809),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            Question = "What are Pooling Considerations?",
                            UpdateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2810),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("80187e77-81b5-40cd-bcac-fc25f86daec8"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2814),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            Question = "What are the Pooling Rules?",
                            UpdateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2815),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("838c8c98-fc47-4b85-9a76-f0d37f453b41"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2816),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            Question = "What are the Available Pools?",
                            UpdateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2817),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("a0b20759-8baa-49eb-a7e1-482d3f97a21e"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2818),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            Question = "How are the Funds Distributed?",
                            UpdateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2818),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("base_dao_api.Models.Pool", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CodeDetailId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDttm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal>("MinInvestment")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdateDttm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CodeDetailId");

                    b.ToTable("Pools");
                });

            modelBuilder.Entity("base_dao_api.Models.PoolActivity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CodeDetailId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDttm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("PoolId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdateDttm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CodeDetailId");

                    b.HasIndex("PoolId");

                    b.ToTable("PoolActivities");
                });

            modelBuilder.Entity("base_dao_api.Models.PoolFunder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("AmtInvested")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AmtReturned")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreateDttm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("PoolId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdateDttm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WalletAddress")
                        .IsRequired()
                        .HasMaxLength(42)
                        .HasColumnType("nvarchar(42)");

                    b.HasKey("Id");

                    b.HasIndex("PoolId");

                    b.ToTable("PoolFunders");
                });

            modelBuilder.Entity("base_dao_api.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDttm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateDttm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WalletAddress")
                        .IsRequired()
                        .HasMaxLength(42)
                        .HasColumnType("nvarchar(42)");

                    b.HasKey("Id");

                    b.HasIndex("WalletAddress")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bb633210-ef25-4671-a246-e75027b5b5cb"),
                            CreateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(3559),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            UpdateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(3561),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            WalletAddress = "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266"
                        });
                });

            modelBuilder.Entity("base_dao_api.Models.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CodeDetailId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDttm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateDttm")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CodeDetailId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4131f3aa-ae7e-4d1b-ad88-c34939d99f3d"),
                            CodeDetailId = new Guid("93ca2536-db18-4df4-87e9-59cdbfe26daa"),
                            CreateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(3655),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            UpdateDttm = new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(3655),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            UserId = new Guid("bb633210-ef25-4671-a246-e75027b5b5cb")
                        });
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

            modelBuilder.Entity("base_dao_api.Models.Pool", b =>
                {
                    b.HasOne("base_dao_api.Models.CodeDetail", "CodeDetail")
                        .WithMany()
                        .HasForeignKey("CodeDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CodeDetail");
                });

            modelBuilder.Entity("base_dao_api.Models.PoolActivity", b =>
                {
                    b.HasOne("base_dao_api.Models.CodeDetail", "CodeDetail")
                        .WithMany()
                        .HasForeignKey("CodeDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("base_dao_api.Models.Pool", "Pool")
                        .WithMany("PoolActivities")
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CodeDetail");

                    b.Navigation("Pool");
                });

            modelBuilder.Entity("base_dao_api.Models.PoolFunder", b =>
                {
                    b.HasOne("base_dao_api.Models.Pool", "Pool")
                        .WithMany("PoolFunders")
                        .HasForeignKey("PoolId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Pool");
                });

            modelBuilder.Entity("base_dao_api.Models.UserRole", b =>
                {
                    b.HasOne("base_dao_api.Models.CodeDetail", "CodeDetail")
                        .WithMany()
                        .HasForeignKey("CodeDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("base_dao_api.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CodeDetail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("base_dao_api.Models.CodeHeader", b =>
                {
                    b.Navigation("CodeDetails");
                });

            modelBuilder.Entity("base_dao_api.Models.Pool", b =>
                {
                    b.Navigation("PoolActivities");

                    b.Navigation("PoolFunders");
                });

            modelBuilder.Entity("base_dao_api.Models.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}