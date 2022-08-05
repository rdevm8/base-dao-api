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
    [Migration("20220805051147_v0.049")]
    partial class v0049
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                            Id = new Guid("c12cc22f-e7ec-433a-aa0b-d3138e2c5acf"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8915),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Order = 1,
                            Question = "What is Wick's Crew?",
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8917),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("6ef5c77f-3149-46ce-a28a-9d9545d6dcfd"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8922),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Order = 2,
                            Question = "What are Pooling Considerations?",
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8922),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("286d4492-cb01-45dc-8288-d2f3ba818bc3"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8924),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Order = 3,
                            Question = "What are the Pooling Rules?",
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8924),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("b8a0d975-b255-413c-a538-63eca482940a"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8932),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Order = 4,
                            Question = "What are the Available Pools?",
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8932),
                            UpdatedBy = "SYSTEM"
                        },
                        new
                        {
                            Id = new Guid("3f961360-c4fc-45c0-9baa-44702538cf4b"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8934),
                            CreatedBy = "SYSTEM",
                            IsDeleted = false,
                            Order = 5,
                            Question = "How are the Funds Distributed?",
                            UpdateDttm = new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8934),
                            UpdatedBy = "SYSTEM"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
