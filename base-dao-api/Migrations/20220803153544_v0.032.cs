using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0032 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("30fd36b8-df5b-4d0b-8303-96905e5ce936"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("4f7a8dce-4707-43a7-b121-e07bbbaa72a4"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("56a2badf-ffbe-48bd-ae3e-514fe3ac1a25"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("5f475987-9109-4fb4-9cc3-f3e6e792fc90"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("9e075f64-3333-480c-97de-5f9d97e914f0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("26b8b03f-bc8f-46f3-836c-c2475340cf78"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("60fac1ba-6787-466c-bae0-bdb25cb3c6f0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("61078ae1-8f8a-4417-961d-6282011f15e4"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c679c4d6-8c4f-4d8a-9715-8a6afbb05b45"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e285afb5-ae1f-4abf-87e4-d7d45502626c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f59e992f-3f24-4f5a-a29e-d7967a476ef1"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("f873bba8-a875-4aae-b5cb-455dd004123b"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("1dda9eef-e3bd-42dd-b96f-85e3c5c89a9e"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("2abbb698-78f5-48f9-a7dc-e2a89f4dcc61"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("442bbdd7-06fa-4157-b87a-f56bab8ee39d"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("92a128a4-3203-40a2-9e02-3aa6e4f88d66"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("a2b3cda5-0852-47e9-8937-c4c351f4155b"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("aee72bac-794a-4325-9710-519eece6f35d"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("d7527408-d631-4fa3-b20f-7cc889c5d44c"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("9826157a-0e2e-4f32-af33-d4e0ee70be72"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("a4812325-8905-4423-8694-3d9eabafbb0a"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("aeff39e7-7060-4b6d-87ae-527d55525f8b"));

            migrationBuilder.CreateTable(
                name: "CodeHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HeaderCd = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeHeader", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "CodeDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DetailCd = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CodeHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CodeDetail_CodeHeader_CodeHeaderId",
                        column: x => x.CodeHeaderId,
                        principalTable: "CodeHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_CodeDetail_CodeDetailId",
                        column: x => x.CodeDetailId,
                        principalTable: "CodeDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CodeDetail_CodeHeaderId",
                table: "CodeDetail",
                column: "CodeHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_CodeDetailId",
                table: "UserRole",
                column: "CodeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_WalletAddress",
                table: "Users",
                column: "WalletAddress",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "CodeDetail");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CodeHeader");

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

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreateUserId", "IsActive", "Question", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("30fd36b8-df5b-4d0b-8303-96905e5ce936"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(70), new Guid("00000000-0000-0000-0000-000000000000"), true, "How are the Funds Distributed?", new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(71), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4f7a8dce-4707-43a7-b121-e07bbbaa72a4"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(67), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Available Pools?", new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(67), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("56a2badf-ffbe-48bd-ae3e-514fe3ac1a25"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(60), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are Pooling Considerations?", new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(61), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5f475987-9109-4fb4-9cc3-f3e6e792fc90"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(43), new Guid("00000000-0000-0000-0000-000000000000"), true, "What is Wick's Crew?", new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(54), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9e075f64-3333-480c-97de-5f9d97e914f0"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(63), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Pooling Rules?", new DateTime(2022, 8, 3, 23, 35, 2, 346, DateTimeKind.Local).AddTicks(64), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("9826157a-0e2e-4f32-af33-d4e0ee70be72"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" },
                    { new Guid("a4812325-8905-4423-8694-3d9eabafbb0a"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" },
                    { new Guid("aeff39e7-7060-4b6d-87ae-527d55525f8b"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("26b8b03f-bc8f-46f3-836c-c2475340cf78"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9826157a-0e2e-4f32-af33-d4e0ee70be72"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("60fac1ba-6787-466c-bae0-bdb25cb3c6f0"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a4812325-8905-4423-8694-3d9eabafbb0a"), "Black Widow" },
                    { new Guid("61078ae1-8f8a-4417-961d-6282011f15e4"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9826157a-0e2e-4f32-af33-d4e0ee70be72"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("c679c4d6-8c4f-4d8a-9715-8a6afbb05b45"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aeff39e7-7060-4b6d-87ae-527d55525f8b"), "Batman Begins" },
                    { new Guid("e285afb5-ae1f-4abf-87e4-d7d45502626c"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aeff39e7-7060-4b6d-87ae-527d55525f8b"), "The Dark Knight" },
                    { new Guid("f59e992f-3f24-4f5a-a29e-d7967a476ef1"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aeff39e7-7060-4b6d-87ae-527d55525f8b"), "The Dark Knight Rises" },
                    { new Guid("f873bba8-a875-4aae-b5cb-455dd004123b"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9826157a-0e2e-4f32-af33-d4e0ee70be72"), "Star Wars: Episode VI – Return of the Jedi" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("1dda9eef-e3bd-42dd-b96f-85e3c5c89a9e"), "She's good at spying at people.", "Espionage", new Guid("a4812325-8905-4423-8694-3d9eabafbb0a") },
                    { new Guid("2abbb698-78f5-48f9-a7dc-e2a89f4dcc61"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("9826157a-0e2e-4f32-af33-d4e0ee70be72") },
                    { new Guid("442bbdd7-06fa-4157-b87a-f56bab8ee39d"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("a4812325-8905-4423-8694-3d9eabafbb0a") },
                    { new Guid("92a128a4-3203-40a2-9e02-3aa6e4f88d66"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("a4812325-8905-4423-8694-3d9eabafbb0a") },
                    { new Guid("a2b3cda5-0852-47e9-8937-c4c351f4155b"), "He got a lot of money", "Wealth.", new Guid("aeff39e7-7060-4b6d-87ae-527d55525f8b") },
                    { new Guid("aee72bac-794a-4325-9710-519eece6f35d"), "He's always a step ahead.", "Intellect.", new Guid("aeff39e7-7060-4b6d-87ae-527d55525f8b") },
                    { new Guid("d7527408-d631-4fa3-b20f-7cc889c5d44c"), "Sublime fighting skills.", "Fighting", new Guid("aeff39e7-7060-4b6d-87ae-527d55525f8b") }
                });
        }
    }
}
