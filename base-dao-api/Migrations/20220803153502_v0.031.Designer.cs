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
    [Migration("20220803153502_v0.031")]
    partial class v0031
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
                            Id = new Guid("5f475987-9109-4fb4-9cc3-f3e6e792fc90"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(43),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            Question = "What is Wick's Crew?",
                            UpdateDttm = new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(54),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("56a2badf-ffbe-48bd-ae3e-514fe3ac1a25"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(60),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            Question = "What are Pooling Considerations?",
                            UpdateDttm = new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(61),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("9e075f64-3333-480c-97de-5f9d97e914f0"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(63),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            Question = "What are the Pooling Rules?",
                            UpdateDttm = new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(64),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("4f7a8dce-4707-43a7-b121-e07bbbaa72a4"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(67),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            Question = "What are the Available Pools?",
                            UpdateDttm = new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(67),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("30fd36b8-df5b-4d0b-8303-96905e5ce936"),
                            Answer = "At vero eos et accusamus et iusto",
                            CreateDttm = new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(70),
                            CreateUserId = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            Question = "How are the Funds Distributed?",
                            UpdateDttm = new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(71),
                            UpdateUserId = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("base_dao_api.Models.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instructor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SuperheroId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c679c4d6-8c4f-4d8a-9715-8a6afbb05b45"),
                            Description = "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("aeff39e7-7060-4b6d-87ae-527d55525f8b"),
                            Title = "Batman Begins"
                        },
                        new
                        {
                            Id = new Guid("e285afb5-ae1f-4abf-87e4-d7d45502626c"),
                            Description = "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("aeff39e7-7060-4b6d-87ae-527d55525f8b"),
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = new Guid("f59e992f-3f24-4f5a-a29e-d7967a476ef1"),
                            Description = "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("aeff39e7-7060-4b6d-87ae-527d55525f8b"),
                            Title = "The Dark Knight Rises"
                        },
                        new
                        {
                            Id = new Guid("61078ae1-8f8a-4417-961d-6282011f15e4"),
                            Description = "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.",
                            Instructor = "George Lucas",
                            ReleaseDate = new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("9826157a-0e2e-4f32-af33-d4e0ee70be72"),
                            Title = "Star Wars: Episode IV – A New Hope"
                        },
                        new
                        {
                            Id = new Guid("26b8b03f-bc8f-46f3-836c-c2475340cf78"),
                            Description = "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.",
                            Instructor = "Irvin Kershner",
                            ReleaseDate = new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("9826157a-0e2e-4f32-af33-d4e0ee70be72"),
                            Title = "Star Wars: Episode V – The Empire Strikes Back"
                        },
                        new
                        {
                            Id = new Guid("f873bba8-a875-4aae-b5cb-455dd004123b"),
                            Description = "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.",
                            Instructor = "Richard Marquand",
                            ReleaseDate = new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("9826157a-0e2e-4f32-af33-d4e0ee70be72"),
                            Title = "Star Wars: Episode VI – Return of the Jedi"
                        },
                        new
                        {
                            Id = new Guid("60fac1ba-6787-466c-bae0-bdb25cb3c6f0"),
                            Description = "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).",
                            Instructor = "Cate Shortland",
                            ReleaseDate = new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("a4812325-8905-4423-8694-3d9eabafbb0a"),
                            Title = "Black Widow"
                        });
                });

            modelBuilder.Entity("base_dao_api.Models.Superhero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Superheroes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("aeff39e7-7060-4b6d-87ae-527d55525f8b"),
                            Description = "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.",
                            Height = 1.9299999999999999,
                            Name = "Batman"
                        },
                        new
                        {
                            Id = new Guid("9826157a-0e2e-4f32-af33-d4e0ee70be72"),
                            Description = "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.",
                            Height = 1.7,
                            Name = "Luke Skywalker"
                        },
                        new
                        {
                            Id = new Guid("a4812325-8905-4423-8694-3d9eabafbb0a"),
                            Description = "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.",
                            Height = 1.7,
                            Name = "Black Widow"
                        });
                });

            modelBuilder.Entity("base_dao_api.Models.Superpower", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuperPower")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SuperheroId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId");

                    b.ToTable("Superpowers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("aee72bac-794a-4325-9710-519eece6f35d"),
                            Description = "He's always a step ahead.",
                            SuperPower = "Intellect.",
                            SuperheroId = new Guid("aeff39e7-7060-4b6d-87ae-527d55525f8b")
                        },
                        new
                        {
                            Id = new Guid("d7527408-d631-4fa3-b20f-7cc889c5d44c"),
                            Description = "Sublime fighting skills.",
                            SuperPower = "Fighting",
                            SuperheroId = new Guid("aeff39e7-7060-4b6d-87ae-527d55525f8b")
                        },
                        new
                        {
                            Id = new Guid("a2b3cda5-0852-47e9-8937-c4c351f4155b"),
                            Description = "He got a lot of money",
                            SuperPower = "Wealth.",
                            SuperheroId = new Guid("aeff39e7-7060-4b6d-87ae-527d55525f8b")
                        },
                        new
                        {
                            Id = new Guid("2abbb698-78f5-48f9-a7dc-e2a89f4dcc61"),
                            Description = "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.",
                            SuperPower = "Deflect blaster power.",
                            SuperheroId = new Guid("9826157a-0e2e-4f32-af33-d4e0ee70be72")
                        },
                        new
                        {
                            Id = new Guid("1dda9eef-e3bd-42dd-b96f-85e3c5c89a9e"),
                            Description = "She's good at spying at people.",
                            SuperPower = "Espionage",
                            SuperheroId = new Guid("a4812325-8905-4423-8694-3d9eabafbb0a")
                        },
                        new
                        {
                            Id = new Guid("442bbdd7-06fa-4157-b87a-f56bab8ee39d"),
                            Description = "She knows how to infiltrate the enemy.",
                            SuperPower = "Infiltration",
                            SuperheroId = new Guid("a4812325-8905-4423-8694-3d9eabafbb0a")
                        },
                        new
                        {
                            Id = new Guid("92a128a4-3203-40a2-9e02-3aa6e4f88d66"),
                            Description = "The knowledge of how to undermine others.",
                            SuperPower = "Subterfuge",
                            SuperheroId = new Guid("a4812325-8905-4423-8694-3d9eabafbb0a")
                        });
                });

            modelBuilder.Entity("base_dao_api.Models.Movie", b =>
                {
                    b.HasOne("base_dao_api.Models.Superhero", "Superhero")
                        .WithMany("Movies")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superhero");
                });

            modelBuilder.Entity("base_dao_api.Models.Superpower", b =>
                {
                    b.HasOne("base_dao_api.Models.Superhero", "Superhero")
                        .WithMany("Superpowers")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superhero");
                });

            modelBuilder.Entity("base_dao_api.Models.Superhero", b =>
                {
                    b.Navigation("Movies");

                    b.Navigation("Superpowers");
                });
#pragma warning restore 612, 618
        }
    }
}
