using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0034 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodeDetail_CodeHeaders_CodeHeaderId",
                table: "CodeDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_CodeDetail_CodeDetailId",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CodeDetail",
                table: "CodeDetail");

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("01547f0a-bfda-485c-8a3d-9a6059ab2002"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("77f9aa46-913f-4ba6-b397-58ece5b41c4a"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("0a20b91d-1c9a-4da7-a4d5-cd0d6d9d5c03"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("37b059e7-8d67-4e96-a656-b54851829466"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("3c4bd359-0b4b-4f8f-8600-8a048e376862"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("88af2407-03db-455e-8319-692a3be41d4b"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("def85276-1183-4bfd-9a65-56b403b7fc79"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("18b36e45-6be8-40d0-b53f-05ac130b5989"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3b849031-7c52-41e5-a321-e8d220bb66f1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("65d34f9d-531e-42f1-9856-381fb6f2b97e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("750edc9b-a562-4123-93e6-8b246493c3b8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7f6a8f52-3e77-4e6a-9596-cc835f5cf40a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b0c44bd5-43ec-46d2-8d29-99e6bcd219e4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("ef512732-d01e-4621-8beb-892134ebae71"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("06d872c4-d41a-4f03-99cd-271058e5e37e"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("69481c19-1ca7-4f4d-bb9c-dff1f08e9007"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("857e53e5-d1d1-43ab-a166-4b9aeb44f951"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("ab73ac9a-cfe3-4b72-ae98-20bfd918505e"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("acbcda14-5bff-4140-8693-2354f0a01f96"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("cc774191-1342-4e90-a365-8568415926a7"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("fd111e07-1b41-4107-b055-435346415386"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("227b8789-61f1-406b-90b4-8fe37d91dd26"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("00815201-bfc5-43b5-b0ad-88b7a7406f1f"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("0d75989f-818c-4fea-81f0-c301ccf43be3"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("5ebd94ca-37b7-4cf8-bba1-18a937cfa0d1"));

            migrationBuilder.RenameTable(
                name: "CodeDetail",
                newName: "CodeDetails");

            migrationBuilder.RenameIndex(
                name: "IX_CodeDetail_CodeHeaderId",
                table: "CodeDetails",
                newName: "IX_CodeDetails_CodeHeaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CodeDetails",
                table: "CodeDetails",
                column: "Id");

            migrationBuilder.InsertData(
                table: "CodeHeaders",
                columns: new[] { "Id", "CreateDttm", "CreateUserId", "Description", "HeaderCd", "IsActive", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("3d9c3987-7738-4606-a3f2-6c8014a99cf7"), new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5206), new Guid("00000000-0000-0000-0000-000000000000"), "CodeHeader for User Roles", "ROLE", true, new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5216), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("827126e4-cc9d-4c09-a0bc-ffd45246ed5f"), new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5225), new Guid("00000000-0000-0000-0000-000000000000"), "CodeHeader for Pool Statuses", "PSTATUS", true, new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5226), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreateUserId", "IsActive", "Question", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("028af00a-ae31-4ca0-8cc5-1e8147151404"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5356), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Available Pools?", new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5356), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("21416605-9092-426f-a607-369e5ba1a80f"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5349), new Guid("00000000-0000-0000-0000-000000000000"), true, "What is Wick's Crew?", new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5349), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("253abe0a-2fa5-4601-946c-6742de41285a"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5358), new Guid("00000000-0000-0000-0000-000000000000"), true, "How are the Funds Distributed?", new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5358), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("34d21343-3ee0-4862-b3cb-bd7efaee1a2c"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5354), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Pooling Rules?", new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5354), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5c84eab0-5532-4a21-afa6-088c6f150569"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5352), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are Pooling Considerations?", new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5353), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("04a8eab7-41af-4fa3-85d5-8e5c9d1fca4b"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" },
                    { new Guid("3694f37f-1b1c-4025-9b39-169e31441548"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" },
                    { new Guid("70dca383-9dd8-47d9-bce8-580dcc2c709b"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDttm", "CreateUserId", "IsActive", "UpdateDttm", "UpdateUserId", "WalletAddress" },
                values: new object[] { new Guid("4d000aac-5d88-4d68-b5da-746219fb58d4"), new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(6487), new Guid("00000000-0000-0000-0000-000000000000"), true, new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(6491), new Guid("00000000-0000-0000-0000-000000000000"), "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266" });

            migrationBuilder.InsertData(
                table: "CodeDetails",
                columns: new[] { "Id", "CodeHeaderId", "CreateDttm", "CreateUserId", "Description", "DetailCd", "IsActive", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("00226a3e-9cd9-4de7-a6e6-15b7585094e3"), new Guid("827126e4-cc9d-4c09-a0bc-ffd45246ed5f"), new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5284), new Guid("00000000-0000-0000-0000-000000000000"), "Pool OPEN", "PSTATUS-OPEN", true, new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5285), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("249672e7-e39b-4cb6-84c6-5c99e4e5d939"), new Guid("3d9c3987-7738-4606-a3f2-6c8014a99cf7"), new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5282), new Guid("00000000-0000-0000-0000-000000000000"), "Normal User", "ROLE-NORMAL", true, new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5283), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5fe8c5c0-678d-48fb-8460-3cb305a22bc7"), new Guid("827126e4-cc9d-4c09-a0bc-ffd45246ed5f"), new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5289), new Guid("00000000-0000-0000-0000-000000000000"), "Pool CLOSED", "PSTATUS-CLOSED", true, new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5289), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8b820d54-bed7-4b81-a27d-e4b336cf76a9"), new Guid("3d9c3987-7738-4606-a3f2-6c8014a99cf7"), new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5278), new Guid("00000000-0000-0000-0000-000000000000"), "Admin User", "ROLE-ADMIN", true, new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5278), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e9e164ad-eb5f-4da6-b6d9-fde9c46ea15b"), new Guid("827126e4-cc9d-4c09-a0bc-ffd45246ed5f"), new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5287), new Guid("00000000-0000-0000-0000-000000000000"), "Pool ONGOING", "PSTATUS-ONGOING", true, new DateTime(2022, 8, 3, 23, 36, 52, 869, DateTimeKind.Local).AddTicks(5287), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("03c9dc0a-0745-43a9-ac4e-c6545974697b"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("70dca383-9dd8-47d9-bce8-580dcc2c709b"), "The Dark Knight Rises" },
                    { new Guid("12d36223-9141-4887-8b3a-7d9e2b8ca453"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("70dca383-9dd8-47d9-bce8-580dcc2c709b"), "Batman Begins" },
                    { new Guid("26b65732-549f-44f7-87e9-f99af7b598f2"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3694f37f-1b1c-4025-9b39-169e31441548"), "Black Widow" },
                    { new Guid("2a4c60a7-0ff9-412b-a8ff-03c946ee2c57"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("04a8eab7-41af-4fa3-85d5-8e5c9d1fca4b"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("718980d0-08e1-466e-aba3-c421a7bef58e"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("04a8eab7-41af-4fa3-85d5-8e5c9d1fca4b"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("bf251862-32d2-49a2-84eb-fc5c7d3ad7a2"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("04a8eab7-41af-4fa3-85d5-8e5c9d1fca4b"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("e564c490-d44c-4181-8df0-5a6ea74dafc1"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("70dca383-9dd8-47d9-bce8-580dcc2c709b"), "The Dark Knight" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("0712d23d-f8e6-4699-a9a1-d60bbafb3fed"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("3694f37f-1b1c-4025-9b39-169e31441548") },
                    { new Guid("32638fac-4043-4496-a1af-eaaae23128bc"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("3694f37f-1b1c-4025-9b39-169e31441548") },
                    { new Guid("67474698-6f26-4725-8068-9cb5f292cebf"), "She's good at spying at people.", "Espionage", new Guid("3694f37f-1b1c-4025-9b39-169e31441548") },
                    { new Guid("937cfe45-d1d8-4f3d-a0c1-5a42dc05e1ef"), "He got a lot of money", "Wealth.", new Guid("70dca383-9dd8-47d9-bce8-580dcc2c709b") },
                    { new Guid("977ff932-6c47-4aca-a861-fdeff06a4c8c"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("04a8eab7-41af-4fa3-85d5-8e5c9d1fca4b") },
                    { new Guid("b95d6c77-43e2-4589-9804-430c264cea68"), "He's always a step ahead.", "Intellect.", new Guid("70dca383-9dd8-47d9-bce8-580dcc2c709b") },
                    { new Guid("f724aa8d-acc9-48b9-86cd-39617551cfdd"), "Sublime fighting skills.", "Fighting", new Guid("70dca383-9dd8-47d9-bce8-580dcc2c709b") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CodeDetails_CodeHeaders_CodeHeaderId",
                table: "CodeDetails",
                column: "CodeHeaderId",
                principalTable: "CodeHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_CodeDetails_CodeDetailId",
                table: "UserRole",
                column: "CodeDetailId",
                principalTable: "CodeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodeDetails_CodeHeaders_CodeHeaderId",
                table: "CodeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_CodeDetails_CodeDetailId",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CodeDetails",
                table: "CodeDetails");

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("00226a3e-9cd9-4de7-a6e6-15b7585094e3"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("249672e7-e39b-4cb6-84c6-5c99e4e5d939"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("5fe8c5c0-678d-48fb-8460-3cb305a22bc7"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("8b820d54-bed7-4b81-a27d-e4b336cf76a9"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("e9e164ad-eb5f-4da6-b6d9-fde9c46ea15b"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("028af00a-ae31-4ca0-8cc5-1e8147151404"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("21416605-9092-426f-a607-369e5ba1a80f"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("253abe0a-2fa5-4601-946c-6742de41285a"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("34d21343-3ee0-4862-b3cb-bd7efaee1a2c"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("5c84eab0-5532-4a21-afa6-088c6f150569"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("03c9dc0a-0745-43a9-ac4e-c6545974697b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("12d36223-9141-4887-8b3a-7d9e2b8ca453"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("26b65732-549f-44f7-87e9-f99af7b598f2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2a4c60a7-0ff9-412b-a8ff-03c946ee2c57"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("718980d0-08e1-466e-aba3-c421a7bef58e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bf251862-32d2-49a2-84eb-fc5c7d3ad7a2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e564c490-d44c-4181-8df0-5a6ea74dafc1"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("0712d23d-f8e6-4699-a9a1-d60bbafb3fed"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("32638fac-4043-4496-a1af-eaaae23128bc"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("67474698-6f26-4725-8068-9cb5f292cebf"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("937cfe45-d1d8-4f3d-a0c1-5a42dc05e1ef"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("977ff932-6c47-4aca-a861-fdeff06a4c8c"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("b95d6c77-43e2-4589-9804-430c264cea68"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("f724aa8d-acc9-48b9-86cd-39617551cfdd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d000aac-5d88-4d68-b5da-746219fb58d4"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("3d9c3987-7738-4606-a3f2-6c8014a99cf7"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("827126e4-cc9d-4c09-a0bc-ffd45246ed5f"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("04a8eab7-41af-4fa3-85d5-8e5c9d1fca4b"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("3694f37f-1b1c-4025-9b39-169e31441548"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("70dca383-9dd8-47d9-bce8-580dcc2c709b"));

            migrationBuilder.RenameTable(
                name: "CodeDetails",
                newName: "CodeDetail");

            migrationBuilder.RenameIndex(
                name: "IX_CodeDetails_CodeHeaderId",
                table: "CodeDetail",
                newName: "IX_CodeDetail_CodeHeaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CodeDetail",
                table: "CodeDetail",
                column: "Id");

            migrationBuilder.InsertData(
                table: "CodeHeaders",
                columns: new[] { "Id", "CreateDttm", "CreateUserId", "Description", "HeaderCd", "IsActive", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("01547f0a-bfda-485c-8a3d-9a6059ab2002"), new DateTime(2022, 8, 3, 23, 36, 21, 610, DateTimeKind.Local).AddTicks(1385), new Guid("00000000-0000-0000-0000-000000000000"), "CodeHeader for Pool Statuses", "PSTATUS", true, new DateTime(2022, 8, 3, 23, 36, 21, 610, DateTimeKind.Local).AddTicks(1386), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("77f9aa46-913f-4ba6-b397-58ece5b41c4a"), new DateTime(2022, 8, 3, 23, 36, 21, 610, DateTimeKind.Local).AddTicks(1372), new Guid("00000000-0000-0000-0000-000000000000"), "CodeHeader for User Roles", "ROLE", true, new DateTime(2022, 8, 3, 23, 36, 21, 610, DateTimeKind.Local).AddTicks(1382), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreateUserId", "IsActive", "Question", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("0a20b91d-1c9a-4da7-a4d5-cd0d6d9d5c03"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 36, 21, 610, DateTimeKind.Local).AddTicks(1467), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Available Pools?", new DateTime(2022, 8, 3, 23, 36, 21, 610, DateTimeKind.Local).AddTicks(1467), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("37b059e7-8d67-4e96-a656-b54851829466"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 36, 21, 610, DateTimeKind.Local).AddTicks(1465), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Pooling Rules?", new DateTime(2022, 8, 3, 23, 36, 21, 610, DateTimeKind.Local).AddTicks(1465), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3c4bd359-0b4b-4f8f-8600-8a048e376862"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 36, 21, 610, DateTimeKind.Local).AddTicks(1471), new Guid("00000000-0000-0000-0000-000000000000"), true, "How are the Funds Distributed?", new DateTime(2022, 8, 3, 23, 36, 21, 610, DateTimeKind.Local).AddTicks(1471), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("88af2407-03db-455e-8319-692a3be41d4b"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 36, 21, 610, DateTimeKind.Local).AddTicks(1463), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are Pooling Considerations?", new DateTime(2022, 8, 3, 23, 36, 21, 610, DateTimeKind.Local).AddTicks(1464), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("def85276-1183-4bfd-9a65-56b403b7fc79"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 36, 21, 610, DateTimeKind.Local).AddTicks(1460), new Guid("00000000-0000-0000-0000-000000000000"), true, "What is Wick's Crew?", new DateTime(2022, 8, 3, 23, 36, 21, 610, DateTimeKind.Local).AddTicks(1460), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("00815201-bfc5-43b5-b0ad-88b7a7406f1f"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" },
                    { new Guid("0d75989f-818c-4fea-81f0-c301ccf43be3"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" },
                    { new Guid("5ebd94ca-37b7-4cf8-bba1-18a937cfa0d1"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDttm", "CreateUserId", "IsActive", "UpdateDttm", "UpdateUserId", "WalletAddress" },
                values: new object[] { new Guid("227b8789-61f1-406b-90b4-8fe37d91dd26"), new DateTime(2022, 8, 3, 23, 36, 21, 610, DateTimeKind.Local).AddTicks(2436), new Guid("00000000-0000-0000-0000-000000000000"), true, new DateTime(2022, 8, 3, 23, 36, 21, 610, DateTimeKind.Local).AddTicks(2438), new Guid("00000000-0000-0000-0000-000000000000"), "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("18b36e45-6be8-40d0-b53f-05ac130b5989"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00815201-bfc5-43b5-b0ad-88b7a7406f1f"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("3b849031-7c52-41e5-a321-e8d220bb66f1"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5ebd94ca-37b7-4cf8-bba1-18a937cfa0d1"), "The Dark Knight" },
                    { new Guid("65d34f9d-531e-42f1-9856-381fb6f2b97e"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0d75989f-818c-4fea-81f0-c301ccf43be3"), "Black Widow" },
                    { new Guid("750edc9b-a562-4123-93e6-8b246493c3b8"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5ebd94ca-37b7-4cf8-bba1-18a937cfa0d1"), "The Dark Knight Rises" },
                    { new Guid("7f6a8f52-3e77-4e6a-9596-cc835f5cf40a"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5ebd94ca-37b7-4cf8-bba1-18a937cfa0d1"), "Batman Begins" },
                    { new Guid("b0c44bd5-43ec-46d2-8d29-99e6bcd219e4"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00815201-bfc5-43b5-b0ad-88b7a7406f1f"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("ef512732-d01e-4621-8beb-892134ebae71"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00815201-bfc5-43b5-b0ad-88b7a7406f1f"), "Star Wars: Episode VI – Return of the Jedi" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("06d872c4-d41a-4f03-99cd-271058e5e37e"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("0d75989f-818c-4fea-81f0-c301ccf43be3") },
                    { new Guid("69481c19-1ca7-4f4d-bb9c-dff1f08e9007"), "He's always a step ahead.", "Intellect.", new Guid("5ebd94ca-37b7-4cf8-bba1-18a937cfa0d1") },
                    { new Guid("857e53e5-d1d1-43ab-a166-4b9aeb44f951"), "He got a lot of money", "Wealth.", new Guid("5ebd94ca-37b7-4cf8-bba1-18a937cfa0d1") },
                    { new Guid("ab73ac9a-cfe3-4b72-ae98-20bfd918505e"), "Sublime fighting skills.", "Fighting", new Guid("5ebd94ca-37b7-4cf8-bba1-18a937cfa0d1") },
                    { new Guid("acbcda14-5bff-4140-8693-2354f0a01f96"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("00815201-bfc5-43b5-b0ad-88b7a7406f1f") },
                    { new Guid("cc774191-1342-4e90-a365-8568415926a7"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("0d75989f-818c-4fea-81f0-c301ccf43be3") },
                    { new Guid("fd111e07-1b41-4107-b055-435346415386"), "She's good at spying at people.", "Espionage", new Guid("0d75989f-818c-4fea-81f0-c301ccf43be3") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CodeDetail_CodeHeaders_CodeHeaderId",
                table: "CodeDetail",
                column: "CodeHeaderId",
                principalTable: "CodeHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_CodeDetail_CodeDetailId",
                table: "UserRole",
                column: "CodeDetailId",
                principalTable: "CodeDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
