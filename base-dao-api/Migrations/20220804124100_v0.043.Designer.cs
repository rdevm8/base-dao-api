// <auto-generated />
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
    [Migration("20220804124100_v0.043")]
    partial class v0043
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
                            Id = new Guid("46616b24-cc7c-4a1e-9189-5db9f0452f48"),
                            CodeHeaderId = new Guid("db078c10-5d17-45fc-a152-5a92c025987a"),
                            CreateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(768),
                            CreatedBy = "SYSTEM",
                            Description = "Admin User",
                            DetailCd = "ROLE-ADMIN",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(768),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("d9ecea68-8bc0-4acd-8ce6-e4b08b227c2d"),
                            CodeHeaderId = new Guid("db078c10-5d17-45fc-a152-5a92c025987a"),
                            CreateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(771),
                            CreatedBy = "SYSTEM",
                            Description = "Normal User",
                            DetailCd = "ROLE-NORMAL",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(772),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("e57d3bbc-393a-4eba-9877-ab91a4403512"),
                            CodeHeaderId = new Guid("08ceef9d-ccd7-4382-9826-0228a3aa0c30"),
                            CreateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(778),
                            CreatedBy = "SYSTEM",
                            Description = "Pool OPEN",
                            DetailCd = "PSTATUS-OPEN",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(779),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("c038b645-fb66-4083-945b-47851f4cfe5f"),
                            CodeHeaderId = new Guid("08ceef9d-ccd7-4382-9826-0228a3aa0c30"),
                            CreateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(781),
                            CreatedBy = "SYSTEM",
                            Description = "Pool ONGOING",
                            DetailCd = "PSTATUS-ONGOING",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(781),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("3b93f365-8551-44ae-8728-7d5020595031"),
                            CodeHeaderId = new Guid("08ceef9d-ccd7-4382-9826-0228a3aa0c30"),
                            CreateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(782),
                            CreatedBy = "SYSTEM",
                            Description = "Pool CLOSED",
                            DetailCd = "PSTATUS-CLOSED",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(783),
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
                            Id = new Guid("db078c10-5d17-45fc-a152-5a92c025987a"),
                            CreateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(181),
                            CreatedBy = "SYSTEM",
                            Description = "CodeHeader for User Roles",
                            HeaderCd = "ROLE",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(183),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("08ceef9d-ccd7-4382-9826-0228a3aa0c30"),
                            CreateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(187),
                            CreatedBy = "SYSTEM",
                            Description = "CodeHeader for Pool Statuses",
                            HeaderCd = "PSTATUS",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(187),
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
                            Id = new Guid("653f2905-f796-451d-a765-4aef6bbcb882"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1709),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Order = 1,
                            Question = "What is Wick's Crew?",
                            UpdateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1710),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("818fb495-103a-4791-8763-a1345f26f603"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1713),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Order = 2,
                            Question = "What are Pooling Considerations?",
                            UpdateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1713),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("636c3c34-0e34-4350-8418-9dcfe208efa9"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1715),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Order = 3,
                            Question = "What are the Pooling Rules?",
                            UpdateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1716),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("1901e775-0f1a-476f-bc9b-7dded1234e6c"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1717),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Order = 4,
                            Question = "What are the Available Pools?",
                            UpdateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1717),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("95556253-065b-4d71-93db-15a06b207f82"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1724),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Order = 5,
                            Question = "How are the Funds Distributed?",
                            UpdateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1724),
                            UpdatedBy = "SYSTEM"
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

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("MinInvestment")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateDttm")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

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

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("PoolId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdateDttm")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

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

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("PoolId")
                        .HasColumnType("uniqueidentifier");

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

                    b.HasIndex("WalletAddress")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("05715151-b20d-42fe-a507-84f0a92e4eb3"),
                            CreateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(2239),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Name = "",
                            UpdateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(2240),
                            UpdatedBy = "SYSTEM",
                            WalletAddress = "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266"
                        },
                        new
                        {
                            Id = new Guid("e09ac335-3f94-4d21-aaec-ac4dd5395297"),
                            CreateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(2242),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Name = "SYSTEM",
                            UpdateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(2242),
                            UpdatedBy = "SYSTEM",
                            WalletAddress = ""
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

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDttm")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CodeDetailId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("649c1244-3ad7-4413-a48f-bfed97a4dc1a"),
                            CodeDetailId = new Guid("46616b24-cc7c-4a1e-9189-5db9f0452f48"),
                            CreateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(3587),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(3588),
                            UpdatedBy = "SYSTEM",
                            UserId = new Guid("05715151-b20d-42fe-a507-84f0a92e4eb3")
                        },
                        new
                        {
                            Id = new Guid("3f853db1-60c7-4199-a6d9-1d01f780b5cb"),
                            CodeDetailId = new Guid("46616b24-cc7c-4a1e-9189-5db9f0452f48"),
                            CreateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(3591),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            UpdateDttm = new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(3591),
                            UpdatedBy = "SYSTEM",
                            UserId = new Guid("e09ac335-3f94-4d21-aaec-ac4dd5395297")
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
                        .OnDelete(DeleteBehavior.NoAction)
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
