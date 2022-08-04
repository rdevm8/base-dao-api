using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("659553ec-7d3a-4981-8cd9-9d13f2b0855f"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 22, 48, 55, 359, DateTimeKind.Local).AddTicks(6685), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are Pooling Considerations?", new DateTime(2022, 8, 3, 22, 48, 55, 359, DateTimeKind.Local).AddTicks(6685), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7503531f-8d94-4b4a-b592-801130ec2119"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 22, 48, 55, 359, DateTimeKind.Local).AddTicks(6687), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Pooling Rules?", new DateTime(2022, 8, 3, 22, 48, 55, 359, DateTimeKind.Local).AddTicks(6687), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ae3620f5-4b2f-4a90-b84f-0ec15d84cdf3"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 22, 48, 55, 359, DateTimeKind.Local).AddTicks(6688), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Available Pools?", new DateTime(2022, 8, 3, 22, 48, 55, 359, DateTimeKind.Local).AddTicks(6689), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ed655729-820f-4660-8d03-bc03ee804dbf"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 22, 48, 55, 359, DateTimeKind.Local).AddTicks(6690), new Guid("00000000-0000-0000-0000-000000000000"), true, "How are the Funds Distributed?", new DateTime(2022, 8, 3, 22, 48, 55, 359, DateTimeKind.Local).AddTicks(6690), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f6d4fb8b-974b-44ab-ad03-a079028d1beb"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 22, 48, 55, 359, DateTimeKind.Local).AddTicks(6672), new Guid("00000000-0000-0000-0000-000000000000"), true, "What is Wick's Crew?", new DateTime(2022, 8, 3, 22, 48, 55, 359, DateTimeKind.Local).AddTicks(6682), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("01688393-c20c-40ea-b0f0-3c17808f447a"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" },
                    { new Guid("318fbdaf-621f-4856-80ea-ccedbaa57df9"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" },
                    { new Guid("c40e34de-124d-4e56-b07e-1cfa04091b7d"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDttm", "CreateUserId", "IsActive", "UpdateDttm", "UpdateUserId", "WalletAddress" },
                values: new object[] { new Guid("279bc86d-a452-4ed7-b07d-332a1f15a251"), new DateTime(2022, 8, 3, 22, 48, 55, 359, DateTimeKind.Local).AddTicks(7596), new Guid("00000000-0000-0000-0000-000000000000"), true, new DateTime(2022, 8, 3, 22, 48, 55, 359, DateTimeKind.Local).AddTicks(7598), new Guid("00000000-0000-0000-0000-000000000000"), "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("169cff08-80b6-4cf1-9fd8-ebbe10b6f265"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01688393-c20c-40ea-b0f0-3c17808f447a"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("35d2423d-b863-48e1-aa54-b012f26b548e"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("318fbdaf-621f-4856-80ea-ccedbaa57df9"), "Batman Begins" },
                    { new Guid("4b344cdf-fc5d-45f8-b050-fcda853992f5"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("318fbdaf-621f-4856-80ea-ccedbaa57df9"), "The Dark Knight" },
                    { new Guid("4f42518c-55ce-4839-bc4a-0d5ecee534c2"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01688393-c20c-40ea-b0f0-3c17808f447a"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("92c15a66-b9de-45d7-a28f-c62dda47afb3"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("318fbdaf-621f-4856-80ea-ccedbaa57df9"), "The Dark Knight Rises" },
                    { new Guid("cd8161d2-59c1-4ca4-94d6-5c2e344c3355"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c40e34de-124d-4e56-b07e-1cfa04091b7d"), "Black Widow" },
                    { new Guid("e2e02c8b-c840-41b1-b790-4bdd1392091b"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("01688393-c20c-40ea-b0f0-3c17808f447a"), "Star Wars: Episode IV – A New Hope" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("073bd6e7-433d-46e8-b732-ebbd1e426c6c"), "He got a lot of money", "Wealth.", new Guid("318fbdaf-621f-4856-80ea-ccedbaa57df9") },
                    { new Guid("425b9de5-3c44-4a39-9519-df45722f58ab"), "She's good at spying at people.", "Espionage", new Guid("c40e34de-124d-4e56-b07e-1cfa04091b7d") },
                    { new Guid("a4164de8-df0f-4c32-9c87-f3ca91b66312"), "Sublime fighting skills.", "Fighting", new Guid("318fbdaf-621f-4856-80ea-ccedbaa57df9") },
                    { new Guid("d6fd526e-b2d5-454a-922f-1f9eac50476e"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("c40e34de-124d-4e56-b07e-1cfa04091b7d") },
                    { new Guid("e3640a89-d879-460e-acb8-c92600c7a3d6"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("c40e34de-124d-4e56-b07e-1cfa04091b7d") },
                    { new Guid("ed2caecb-155e-48e3-8099-10eb83a0b27c"), "He's always a step ahead.", "Intellect.", new Guid("318fbdaf-621f-4856-80ea-ccedbaa57df9") },
                    { new Guid("f3c3c7df-89f9-4620-be6b-29159fc86a45"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("01688393-c20c-40ea-b0f0-3c17808f447a") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_WalletAddress",
                table: "Users",
                column: "WalletAddress",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_WalletAddress",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("659553ec-7d3a-4981-8cd9-9d13f2b0855f"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("7503531f-8d94-4b4a-b592-801130ec2119"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("ae3620f5-4b2f-4a90-b84f-0ec15d84cdf3"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("ed655729-820f-4660-8d03-bc03ee804dbf"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("f6d4fb8b-974b-44ab-ad03-a079028d1beb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("169cff08-80b6-4cf1-9fd8-ebbe10b6f265"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("35d2423d-b863-48e1-aa54-b012f26b548e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4b344cdf-fc5d-45f8-b050-fcda853992f5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4f42518c-55ce-4839-bc4a-0d5ecee534c2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("92c15a66-b9de-45d7-a28f-c62dda47afb3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cd8161d2-59c1-4ca4-94d6-5c2e344c3355"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e2e02c8b-c840-41b1-b790-4bdd1392091b"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("073bd6e7-433d-46e8-b732-ebbd1e426c6c"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("425b9de5-3c44-4a39-9519-df45722f58ab"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("a4164de8-df0f-4c32-9c87-f3ca91b66312"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("d6fd526e-b2d5-454a-922f-1f9eac50476e"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("e3640a89-d879-460e-acb8-c92600c7a3d6"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("ed2caecb-155e-48e3-8099-10eb83a0b27c"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("f3c3c7df-89f9-4620-be6b-29159fc86a45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("279bc86d-a452-4ed7-b07d-332a1f15a251"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("01688393-c20c-40ea-b0f0-3c17808f447a"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("318fbdaf-621f-4856-80ea-ccedbaa57df9"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("c40e34de-124d-4e56-b07e-1cfa04091b7d"));

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
    }
}
