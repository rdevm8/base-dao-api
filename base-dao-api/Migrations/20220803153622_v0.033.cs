using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0033 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodeDetail_CodeHeader_CodeHeaderId",
                table: "CodeDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CodeHeader",
                table: "CodeHeader");

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("234a0306-96c2-4817-a406-39ab4f79af5e"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("46624852-0334-4c07-aa61-ad74560f0c17"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("6b713f5e-6054-4378-9fb8-4f265a45a96f"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("bba20ff2-3871-43f2-be5b-a4fd52ef94ef"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("e2d9bbba-b46e-4aa0-a992-a4b462bf17b2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0c0cd6e0-3127-40a9-8f1c-3df1bd35b2e5"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("150e8fb6-e6b2-4941-832e-ac729176637e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2f01cbec-0882-47f3-be9d-14ead6b67580"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("63320f84-b975-4c41-84ea-bc0688e5ce6b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("90143274-fbb1-44a8-aed8-83a1ac6e9c68"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("9309c86b-a043-4d38-a0f3-2e3988718443"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c538fda0-037d-4c3a-a08c-a967ca93439f"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("37775581-25f9-4a82-b81a-17698d3d4619"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("4af2b1c8-78cc-4d7b-8e17-c89404bc2431"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("812e88c3-7879-4d8a-b17c-c04e739332a0"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("83017663-c81f-4362-b209-1809df71dd11"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("cef9a1f2-4ab8-44d3-81f5-6986aa82d691"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("d648e805-6e11-49a8-bee2-3ae3753747a5"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("e562e0ef-a4a2-4901-a661-5b1876b7587c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26f31528-6377-463c-9209-8eeb288261fc"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("4d8e8f0b-1685-45f5-b672-4a643a2c678b"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("86e28cf5-2b6e-4952-a66e-c544d7f2c30e"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("c3005535-8d6c-49fc-8903-10cdc5b8eea6"));

            migrationBuilder.RenameTable(
                name: "CodeHeader",
                newName: "CodeHeaders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CodeHeaders",
                table: "CodeHeaders",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodeDetail_CodeHeaders_CodeHeaderId",
                table: "CodeDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CodeHeaders",
                table: "CodeHeaders");

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
                name: "CodeHeaders",
                newName: "CodeHeader");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CodeHeader",
                table: "CodeHeader",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreateUserId", "IsActive", "Question", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("234a0306-96c2-4817-a406-39ab4f79af5e"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 35, 43, 984, DateTimeKind.Local).AddTicks(2128), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Pooling Rules?", new DateTime(2022, 8, 3, 23, 35, 43, 984, DateTimeKind.Local).AddTicks(2128), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("46624852-0334-4c07-aa61-ad74560f0c17"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 35, 43, 984, DateTimeKind.Local).AddTicks(2113), new Guid("00000000-0000-0000-0000-000000000000"), true, "What is Wick's Crew?", new DateTime(2022, 8, 3, 23, 35, 43, 984, DateTimeKind.Local).AddTicks(2123), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6b713f5e-6054-4378-9fb8-4f265a45a96f"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 35, 43, 984, DateTimeKind.Local).AddTicks(2133), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Available Pools?", new DateTime(2022, 8, 3, 23, 35, 43, 984, DateTimeKind.Local).AddTicks(2133), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bba20ff2-3871-43f2-be5b-a4fd52ef94ef"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 35, 43, 984, DateTimeKind.Local).AddTicks(2126), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are Pooling Considerations?", new DateTime(2022, 8, 3, 23, 35, 43, 984, DateTimeKind.Local).AddTicks(2127), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e2d9bbba-b46e-4aa0-a992-a4b462bf17b2"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 35, 43, 984, DateTimeKind.Local).AddTicks(2135), new Guid("00000000-0000-0000-0000-000000000000"), true, "How are the Funds Distributed?", new DateTime(2022, 8, 3, 23, 35, 43, 984, DateTimeKind.Local).AddTicks(2135), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("4d8e8f0b-1685-45f5-b672-4a643a2c678b"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" },
                    { new Guid("86e28cf5-2b6e-4952-a66e-c544d7f2c30e"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" },
                    { new Guid("c3005535-8d6c-49fc-8903-10cdc5b8eea6"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDttm", "CreateUserId", "IsActive", "UpdateDttm", "UpdateUserId", "WalletAddress" },
                values: new object[] { new Guid("26f31528-6377-463c-9209-8eeb288261fc"), new DateTime(2022, 8, 3, 23, 35, 43, 984, DateTimeKind.Local).AddTicks(3152), new Guid("00000000-0000-0000-0000-000000000000"), true, new DateTime(2022, 8, 3, 23, 35, 43, 984, DateTimeKind.Local).AddTicks(3155), new Guid("00000000-0000-0000-0000-000000000000"), "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("0c0cd6e0-3127-40a9-8f1c-3df1bd35b2e5"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("86e28cf5-2b6e-4952-a66e-c544d7f2c30e"), "The Dark Knight" },
                    { new Guid("150e8fb6-e6b2-4941-832e-ac729176637e"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3005535-8d6c-49fc-8903-10cdc5b8eea6"), "Black Widow" },
                    { new Guid("2f01cbec-0882-47f3-be9d-14ead6b67580"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("86e28cf5-2b6e-4952-a66e-c544d7f2c30e"), "Batman Begins" },
                    { new Guid("63320f84-b975-4c41-84ea-bc0688e5ce6b"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4d8e8f0b-1685-45f5-b672-4a643a2c678b"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("90143274-fbb1-44a8-aed8-83a1ac6e9c68"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("86e28cf5-2b6e-4952-a66e-c544d7f2c30e"), "The Dark Knight Rises" },
                    { new Guid("9309c86b-a043-4d38-a0f3-2e3988718443"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4d8e8f0b-1685-45f5-b672-4a643a2c678b"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("c538fda0-037d-4c3a-a08c-a967ca93439f"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4d8e8f0b-1685-45f5-b672-4a643a2c678b"), "Star Wars: Episode IV – A New Hope" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("37775581-25f9-4a82-b81a-17698d3d4619"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("c3005535-8d6c-49fc-8903-10cdc5b8eea6") },
                    { new Guid("4af2b1c8-78cc-4d7b-8e17-c89404bc2431"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("c3005535-8d6c-49fc-8903-10cdc5b8eea6") },
                    { new Guid("812e88c3-7879-4d8a-b17c-c04e739332a0"), "He got a lot of money", "Wealth.", new Guid("86e28cf5-2b6e-4952-a66e-c544d7f2c30e") },
                    { new Guid("83017663-c81f-4362-b209-1809df71dd11"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("4d8e8f0b-1685-45f5-b672-4a643a2c678b") },
                    { new Guid("cef9a1f2-4ab8-44d3-81f5-6986aa82d691"), "She's good at spying at people.", "Espionage", new Guid("c3005535-8d6c-49fc-8903-10cdc5b8eea6") },
                    { new Guid("d648e805-6e11-49a8-bee2-3ae3753747a5"), "Sublime fighting skills.", "Fighting", new Guid("86e28cf5-2b6e-4952-a66e-c544d7f2c30e") },
                    { new Guid("e562e0ef-a4a2-4901-a661-5b1876b7587c"), "He's always a step ahead.", "Intellect.", new Guid("86e28cf5-2b6e-4952-a66e-c544d7f2c30e") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CodeDetail_CodeHeader_CodeHeaderId",
                table: "CodeDetail",
                column: "CodeHeaderId",
                principalTable: "CodeHeader",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
