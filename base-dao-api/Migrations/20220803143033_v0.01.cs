using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("05a8e548-8363-4d92-b919-2114d52ce04b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1be330e8-2b33-4ef7-ba01-3dace55a23ee"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("724b3b9f-2e7f-49de-943f-376e23d0f60f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7d6e5c83-5269-4a61-b26e-03bf225695c3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a7323ad6-de39-4ca7-a69d-4d06732de1cb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d55465bb-35a1-4398-8b59-572cca425e00"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f28d44f6-69b4-411d-8ff7-514759ee1cb6"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("18766092-753d-46e0-8682-f97db62975f1"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("286b8dca-ad5f-4b30-9f35-3c0cb65178a3"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("3236e4fa-2621-4524-9c7f-3e4f166f2587"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("aa582dc4-08c7-4c4b-9d3d-ef4c216811c8"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("eef1e834-6c6e-49e7-aefb-198357552ab4"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("f4b79117-1e23-4dd4-bd64-4b867ff0408f"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("fc5ab422-2cc0-41e1-8506-6a540855ece5"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("73fe5042-0e33-4874-b03b-28fff94eebf7"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("8f23deed-2652-46d4-bc80-27515d63c70c"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("f129afb5-facf-4c5e-b326-fe0463d03403"));

            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreateUserId", "IsActive", "Question", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("02346d8f-c7bb-411a-8688-e7aaed7877df"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 22, 30, 33, 157, DateTimeKind.Local).AddTicks(1710), new Guid("00000000-0000-0000-0000-000000000000"), true, "What is Wick's Crew?", new DateTime(2022, 8, 3, 22, 30, 33, 157, DateTimeKind.Local).AddTicks(1720), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("04b1cd0d-696e-46cd-a170-f32f72c045c3"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 22, 30, 33, 157, DateTimeKind.Local).AddTicks(1725), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Pooling Rules?", new DateTime(2022, 8, 3, 22, 30, 33, 157, DateTimeKind.Local).AddTicks(1726), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7d78f667-af49-4757-8a6a-f5698251bd89"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 22, 30, 33, 157, DateTimeKind.Local).AddTicks(1727), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Available Pools?", new DateTime(2022, 8, 3, 22, 30, 33, 157, DateTimeKind.Local).AddTicks(1727), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("dab3381f-3979-4c16-963d-94f0f14a7cb6"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 22, 30, 33, 157, DateTimeKind.Local).AddTicks(1729), new Guid("00000000-0000-0000-0000-000000000000"), true, "How are the Funds Distributed?", new DateTime(2022, 8, 3, 22, 30, 33, 157, DateTimeKind.Local).AddTicks(1729), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ebfaed19-0d63-48f2-91c1-41ee88feef26"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 22, 30, 33, 157, DateTimeKind.Local).AddTicks(1723), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are Pooling Considerations?", new DateTime(2022, 8, 3, 22, 30, 33, 157, DateTimeKind.Local).AddTicks(1724), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("1f2a0abd-baa0-4377-abbb-669d28b1e927"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" },
                    { new Guid("9e0fb84c-d524-4139-a70d-4408917b00b1"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" },
                    { new Guid("c0a532ed-c66f-469d-8999-70b5c869cd73"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("14529fba-72c0-4be0-abc2-b85747444899"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1f2a0abd-baa0-4377-abbb-669d28b1e927"), "The Dark Knight Rises" },
                    { new Guid("19e35133-43ac-4302-b728-a4061d906365"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9e0fb84c-d524-4139-a70d-4408917b00b1"), "Black Widow" },
                    { new Guid("22d08324-664e-4737-b1bb-06d04f240fc6"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c0a532ed-c66f-469d-8999-70b5c869cd73"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("3dcedcdf-7f9a-490c-afbe-c10ac303ecf2"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c0a532ed-c66f-469d-8999-70b5c869cd73"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("8bf0bbe2-26c4-4f7e-8ac5-bd0ca903ed80"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c0a532ed-c66f-469d-8999-70b5c869cd73"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("c4b0010e-e1ca-496b-8899-35977a504a7d"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1f2a0abd-baa0-4377-abbb-669d28b1e927"), "The Dark Knight" },
                    { new Guid("fe037bd6-ccc1-437a-9e17-493752be88fe"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1f2a0abd-baa0-4377-abbb-669d28b1e927"), "Batman Begins" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("221f528b-e775-4c41-9f61-3a9233a973e3"), "He's always a step ahead.", "Intellect.", new Guid("1f2a0abd-baa0-4377-abbb-669d28b1e927") },
                    { new Guid("3260d9ac-1a4d-4abd-8f5f-e71621b17023"), "She's good at spying at people.", "Espionage", new Guid("9e0fb84c-d524-4139-a70d-4408917b00b1") },
                    { new Guid("37ae85ca-2032-47a1-b5fb-c3649979499b"), "Sublime fighting skills.", "Fighting", new Guid("1f2a0abd-baa0-4377-abbb-669d28b1e927") },
                    { new Guid("3859319d-4f14-4160-978d-4876cb2b2760"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("9e0fb84c-d524-4139-a70d-4408917b00b1") },
                    { new Guid("3e3b92b5-df6d-4282-b9bd-2f93aea2f068"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("c0a532ed-c66f-469d-8999-70b5c869cd73") },
                    { new Guid("8fd32232-f3d6-4912-8348-25221647e0dd"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("9e0fb84c-d524-4139-a70d-4408917b00b1") },
                    { new Guid("96bc3bf7-3c22-42bb-ae6a-2eb340f72850"), "He got a lot of money", "Wealth.", new Guid("1f2a0abd-baa0-4377-abbb-669d28b1e927") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("14529fba-72c0-4be0-abc2-b85747444899"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("19e35133-43ac-4302-b728-a4061d906365"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("22d08324-664e-4737-b1bb-06d04f240fc6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3dcedcdf-7f9a-490c-afbe-c10ac303ecf2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("8bf0bbe2-26c4-4f7e-8ac5-bd0ca903ed80"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c4b0010e-e1ca-496b-8899-35977a504a7d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fe037bd6-ccc1-437a-9e17-493752be88fe"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("221f528b-e775-4c41-9f61-3a9233a973e3"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("3260d9ac-1a4d-4abd-8f5f-e71621b17023"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("37ae85ca-2032-47a1-b5fb-c3649979499b"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("3859319d-4f14-4160-978d-4876cb2b2760"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("3e3b92b5-df6d-4282-b9bd-2f93aea2f068"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("8fd32232-f3d6-4912-8348-25221647e0dd"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("96bc3bf7-3c22-42bb-ae6a-2eb340f72850"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("1f2a0abd-baa0-4377-abbb-669d28b1e927"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("9e0fb84c-d524-4139-a70d-4408917b00b1"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("c0a532ed-c66f-469d-8999-70b5c869cd73"));

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("73fe5042-0e33-4874-b03b-28fff94eebf7"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("8f23deed-2652-46d4-bc80-27515d63c70c"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("f129afb5-facf-4c5e-b326-fe0463d03403"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("05a8e548-8363-4d92-b919-2114d52ce04b"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73fe5042-0e33-4874-b03b-28fff94eebf7"), "The Dark Knight Rises" },
                    { new Guid("1be330e8-2b33-4ef7-ba01-3dace55a23ee"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8f23deed-2652-46d4-bc80-27515d63c70c"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("724b3b9f-2e7f-49de-943f-376e23d0f60f"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8f23deed-2652-46d4-bc80-27515d63c70c"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("7d6e5c83-5269-4a61-b26e-03bf225695c3"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f129afb5-facf-4c5e-b326-fe0463d03403"), "Black Widow" },
                    { new Guid("a7323ad6-de39-4ca7-a69d-4d06732de1cb"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8f23deed-2652-46d4-bc80-27515d63c70c"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("d55465bb-35a1-4398-8b59-572cca425e00"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73fe5042-0e33-4874-b03b-28fff94eebf7"), "The Dark Knight" },
                    { new Guid("f28d44f6-69b4-411d-8ff7-514759ee1cb6"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("73fe5042-0e33-4874-b03b-28fff94eebf7"), "Batman Begins" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("18766092-753d-46e0-8682-f97db62975f1"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("f129afb5-facf-4c5e-b326-fe0463d03403") },
                    { new Guid("286b8dca-ad5f-4b30-9f35-3c0cb65178a3"), "Sublime fighting skills.", "Fighting", new Guid("73fe5042-0e33-4874-b03b-28fff94eebf7") },
                    { new Guid("3236e4fa-2621-4524-9c7f-3e4f166f2587"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("8f23deed-2652-46d4-bc80-27515d63c70c") },
                    { new Guid("aa582dc4-08c7-4c4b-9d3d-ef4c216811c8"), "He got a lot of money", "Wealth.", new Guid("73fe5042-0e33-4874-b03b-28fff94eebf7") },
                    { new Guid("eef1e834-6c6e-49e7-aefb-198357552ab4"), "She's good at spying at people.", "Espionage", new Guid("f129afb5-facf-4c5e-b326-fe0463d03403") },
                    { new Guid("f4b79117-1e23-4dd4-bd64-4b867ff0408f"), "He's always a step ahead.", "Intellect.", new Guid("73fe5042-0e33-4874-b03b-28fff94eebf7") },
                    { new Guid("fc5ab422-2cc0-41e1-8506-6a540855ece5"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("f129afb5-facf-4c5e-b326-fe0463d03403") }
                });
        }
    }
}
