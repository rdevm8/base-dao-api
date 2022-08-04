using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("02346d8f-c7bb-411a-8688-e7aaed7877df"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("04b1cd0d-696e-46cd-a170-f32f72c045c3"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("7d78f667-af49-4757-8a6a-f5698251bd89"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("dab3381f-3979-4c16-963d-94f0f14a7cb6"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("ebfaed19-0d63-48f2-91c1-41ee88feef26"));

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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WalletAddress = table.Column<string>(type: "nvarchar(42)", maxLength: 42, nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreateUserId", "IsActive", "Question", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("2aa12bd8-8e30-4b69-890d-0cd60f115cd9"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 22, 47, 57, 266, DateTimeKind.Local).AddTicks(7315), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are Pooling Considerations?", new DateTime(2022, 8, 3, 22, 47, 57, 266, DateTimeKind.Local).AddTicks(7315), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6f817cec-4460-4c91-90b9-19dc983e41e6"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 22, 47, 57, 266, DateTimeKind.Local).AddTicks(7296), new Guid("00000000-0000-0000-0000-000000000000"), true, "What is Wick's Crew?", new DateTime(2022, 8, 3, 22, 47, 57, 266, DateTimeKind.Local).AddTicks(7311), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ecf6af47-530c-46f9-a5b4-ee9da91a27f8"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 22, 47, 57, 266, DateTimeKind.Local).AddTicks(7318), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Available Pools?", new DateTime(2022, 8, 3, 22, 47, 57, 266, DateTimeKind.Local).AddTicks(7319), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fc992ea1-b009-478b-aac4-51f3b1c74ed9"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 22, 47, 57, 266, DateTimeKind.Local).AddTicks(7317), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Pooling Rules?", new DateTime(2022, 8, 3, 22, 47, 57, 266, DateTimeKind.Local).AddTicks(7317), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fe6d9e33-03ba-438a-bf74-bcd7448b826d"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 22, 47, 57, 266, DateTimeKind.Local).AddTicks(7323), new Guid("00000000-0000-0000-0000-000000000000"), true, "How are the Funds Distributed?", new DateTime(2022, 8, 3, 22, 47, 57, 266, DateTimeKind.Local).AddTicks(7323), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("56181c9d-b1f8-4bbc-a6e5-8679b4d3b4af"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" },
                    { new Guid("6b8f8d51-bca6-4d80-8efe-05bfd8f501f5"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" },
                    { new Guid("bedcf302-158b-4040-afdf-5dea7fe523be"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("3f663174-bd66-48d8-a9ac-fde6e651db5e"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("56181c9d-b1f8-4bbc-a6e5-8679b4d3b4af"), "Black Widow" },
                    { new Guid("4948a574-6b60-48f2-8770-2b5d5ef3b9b0"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6b8f8d51-bca6-4d80-8efe-05bfd8f501f5"), "Batman Begins" },
                    { new Guid("5165458e-2616-48a4-bbae-c445164e98f6"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bedcf302-158b-4040-afdf-5dea7fe523be"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("541e70ab-8d52-4c3e-8848-091b5cdb039d"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6b8f8d51-bca6-4d80-8efe-05bfd8f501f5"), "The Dark Knight Rises" },
                    { new Guid("6ca8fbeb-c2e0-498d-a78f-64dd1eb5ac70"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bedcf302-158b-4040-afdf-5dea7fe523be"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("a749606a-f1f7-4a6c-92d5-56366e4cfe6d"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6b8f8d51-bca6-4d80-8efe-05bfd8f501f5"), "The Dark Knight" },
                    { new Guid("a7bd5e19-67f6-49f1-9972-bd17bf2a46d3"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bedcf302-158b-4040-afdf-5dea7fe523be"), "Star Wars: Episode IV – A New Hope" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("29105a85-8d95-4a72-baaf-b4635f4f5f71"), "She's good at spying at people.", "Espionage", new Guid("56181c9d-b1f8-4bbc-a6e5-8679b4d3b4af") },
                    { new Guid("6c97df08-ebbf-491e-9175-ace24a88bfc8"), "He's always a step ahead.", "Intellect.", new Guid("6b8f8d51-bca6-4d80-8efe-05bfd8f501f5") },
                    { new Guid("79195671-bb0d-485d-86f3-187b9dd14a1d"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("bedcf302-158b-4040-afdf-5dea7fe523be") },
                    { new Guid("942dc3a2-caf5-4bb6-b246-f9748fa671bc"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("56181c9d-b1f8-4bbc-a6e5-8679b4d3b4af") },
                    { new Guid("b55f0d9d-d110-46cd-8498-dcb431eef8e3"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("56181c9d-b1f8-4bbc-a6e5-8679b4d3b4af") },
                    { new Guid("c6a2ba2b-dc47-41f3-a778-a2f583c566da"), "Sublime fighting skills.", "Fighting", new Guid("6b8f8d51-bca6-4d80-8efe-05bfd8f501f5") },
                    { new Guid("e21cae6d-a2ce-4943-8b93-b59c3c69887d"), "He got a lot of money", "Wealth.", new Guid("6b8f8d51-bca6-4d80-8efe-05bfd8f501f5") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("2aa12bd8-8e30-4b69-890d-0cd60f115cd9"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("6f817cec-4460-4c91-90b9-19dc983e41e6"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("ecf6af47-530c-46f9-a5b4-ee9da91a27f8"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("fc992ea1-b009-478b-aac4-51f3b1c74ed9"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("fe6d9e33-03ba-438a-bf74-bcd7448b826d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3f663174-bd66-48d8-a9ac-fde6e651db5e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4948a574-6b60-48f2-8770-2b5d5ef3b9b0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5165458e-2616-48a4-bbae-c445164e98f6"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("541e70ab-8d52-4c3e-8848-091b5cdb039d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("6ca8fbeb-c2e0-498d-a78f-64dd1eb5ac70"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a749606a-f1f7-4a6c-92d5-56366e4cfe6d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a7bd5e19-67f6-49f1-9972-bd17bf2a46d3"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("29105a85-8d95-4a72-baaf-b4635f4f5f71"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("6c97df08-ebbf-491e-9175-ace24a88bfc8"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("79195671-bb0d-485d-86f3-187b9dd14a1d"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("942dc3a2-caf5-4bb6-b246-f9748fa671bc"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("b55f0d9d-d110-46cd-8498-dcb431eef8e3"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("c6a2ba2b-dc47-41f3-a778-a2f583c566da"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("e21cae6d-a2ce-4943-8b93-b59c3c69887d"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("56181c9d-b1f8-4bbc-a6e5-8679b4d3b4af"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("6b8f8d51-bca6-4d80-8efe-05bfd8f501f5"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("bedcf302-158b-4040-afdf-5dea7fe523be"));

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
    }
}
