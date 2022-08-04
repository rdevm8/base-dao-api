using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0031 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CodeDetail");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CodeHeader");

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("14d5e07e-65f1-4fb3-a393-0c3c7f0561ff"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("5b7c921a-5e05-4c41-8e00-af1401d37574"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("7e318dbe-ae32-4176-8518-c04ce3a48aad"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("a6453c9f-a556-45ba-910b-5112378d2457"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("f1760cbc-934c-4584-9c2b-f59c3591688c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1fd87c65-d44d-4341-a2fd-ebb0d0b6a5c0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("62c345ce-b205-476d-9136-b16b3f9ddfdb"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("aca6e774-c1f6-4001-9b32-79bbeca19e2b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("b4c7e563-5e54-4787-b9de-4b3ef259b387"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("c38b4fb0-36ff-4ee2-8760-567d9b58576d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("d630af57-ae84-4775-b458-6275b4830e0d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e88e29f5-01d4-4f5a-b8ea-34abcb028b26"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("0f7d26e2-af36-4b9a-a166-480b50925b5b"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("3761f8ae-1ada-4027-8694-fe505a9dbee0"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("3fc1ca12-ba73-428c-8f54-5c4e33efb0c0"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("624dd538-1867-4d2b-8786-ed460614617b"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("7eee770d-ab9f-441f-bbd2-9cf20f3baad2"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("90808c5c-74a5-4605-83a6-d910f92c5cc8"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("eddc4e8e-4872-444b-b616-bb2de9dec4ef"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("215aca51-0b55-4f6a-85f6-d7ae76d69eaf"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("98c7452b-05b9-425a-bb8d-cded9ae875cd"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("f6b47376-f833-40d7-91c1-82580393cc2c"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    HeaderCd = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WalletAddress = table.Column<string>(type: "nvarchar(42)", maxLength: 42, nullable: false)
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
                    CodeHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DetailCd = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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

            migrationBuilder.InsertData(
                table: "CodeHeader",
                columns: new[] { "Id", "CreateDttm", "CreateUserId", "Description", "HeaderCd", "IsActive", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("52d2007e-cf76-46ef-95a9-5deb9a328d7d"), new DateTime(2022, 8, 3, 23, 3, 36, 812, DateTimeKind.Local).AddTicks(5439), new Guid("00000000-0000-0000-0000-000000000000"), "CodeHeader for Pool Statuses", "PSTATUS", true, new DateTime(2022, 8, 3, 23, 3, 36, 812, DateTimeKind.Local).AddTicks(5440), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5c428d3f-89cc-4732-a16b-b22f4d8930a1"), new DateTime(2022, 8, 3, 23, 3, 36, 812, DateTimeKind.Local).AddTicks(5422), new Guid("00000000-0000-0000-0000-000000000000"), "CodeHeader for User Roles", "ROLE", true, new DateTime(2022, 8, 3, 23, 3, 36, 812, DateTimeKind.Local).AddTicks(5431), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreateUserId", "IsActive", "Question", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("14d5e07e-65f1-4fb3-a393-0c3c7f0561ff"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9904), new Guid("00000000-0000-0000-0000-000000000000"), true, "What is Wick's Crew?", new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9905), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5b7c921a-5e05-4c41-8e00-af1401d37574"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9912), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Available Pools?", new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9913), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7e318dbe-ae32-4176-8518-c04ce3a48aad"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9914), new Guid("00000000-0000-0000-0000-000000000000"), true, "How are the Funds Distributed?", new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9914), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a6453c9f-a556-45ba-910b-5112378d2457"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9909), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are Pooling Considerations?", new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9909), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f1760cbc-934c-4584-9c2b-f59c3591688c"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9911), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Pooling Rules?", new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9911), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("215aca51-0b55-4f6a-85f6-d7ae76d69eaf"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" },
                    { new Guid("98c7452b-05b9-425a-bb8d-cded9ae875cd"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" },
                    { new Guid("f6b47376-f833-40d7-91c1-82580393cc2c"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDttm", "CreateUserId", "IsActive", "UpdateDttm", "UpdateUserId", "WalletAddress" },
                values: new object[] { new Guid("eb10c1a9-0010-4797-bf47-643dc40b884e"), new DateTime(2022, 8, 3, 23, 3, 36, 814, DateTimeKind.Local).AddTicks(913), new Guid("00000000-0000-0000-0000-000000000000"), true, new DateTime(2022, 8, 3, 23, 3, 36, 814, DateTimeKind.Local).AddTicks(915), new Guid("00000000-0000-0000-0000-000000000000"), "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266" });

            migrationBuilder.InsertData(
                table: "CodeDetail",
                columns: new[] { "Id", "CodeHeaderId", "CreateDttm", "CreateUserId", "Description", "DetailCd", "IsActive", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("0140c00c-a26d-4298-a971-0643f5ceb943"), new Guid("5c428d3f-89cc-4732-a16b-b22f4d8930a1"), new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9775), new Guid("00000000-0000-0000-0000-000000000000"), "Normal User", "ROLE-NORMAL", true, new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9776), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a470a02c-88af-4dd9-92ae-bf6e0b7a53ee"), new Guid("52d2007e-cf76-46ef-95a9-5deb9a328d7d"), new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9778), new Guid("00000000-0000-0000-0000-000000000000"), "Pool OPEN", "PSTATUS-OPEN", true, new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9778), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ac9b5d65-f68b-48d9-9de9-fb29431cc6a7"), new Guid("5c428d3f-89cc-4732-a16b-b22f4d8930a1"), new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9761), new Guid("00000000-0000-0000-0000-000000000000"), "Admin User", "ROLE-ADMIN", true, new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9764), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e2f3c5e7-cb31-4c03-a516-d88b3a3987d0"), new Guid("52d2007e-cf76-46ef-95a9-5deb9a328d7d"), new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9780), new Guid("00000000-0000-0000-0000-000000000000"), "Pool ONGOING", "PSTATUS-ONGOING", true, new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9780), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ebebc95d-b3e5-4231-b7dd-2e6c67faee4c"), new Guid("52d2007e-cf76-46ef-95a9-5deb9a328d7d"), new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9787), new Guid("00000000-0000-0000-0000-000000000000"), "Pool CLOSED", "PSTATUS-CLOSED", true, new DateTime(2022, 8, 3, 23, 3, 36, 813, DateTimeKind.Local).AddTicks(9788), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("1fd87c65-d44d-4341-a2fd-ebb0d0b6a5c0"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f6b47376-f833-40d7-91c1-82580393cc2c"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("62c345ce-b205-476d-9136-b16b3f9ddfdb"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("215aca51-0b55-4f6a-85f6-d7ae76d69eaf"), "The Dark Knight" },
                    { new Guid("aca6e774-c1f6-4001-9b32-79bbeca19e2b"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f6b47376-f833-40d7-91c1-82580393cc2c"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("b4c7e563-5e54-4787-b9de-4b3ef259b387"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f6b47376-f833-40d7-91c1-82580393cc2c"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("c38b4fb0-36ff-4ee2-8760-567d9b58576d"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98c7452b-05b9-425a-bb8d-cded9ae875cd"), "Black Widow" },
                    { new Guid("d630af57-ae84-4775-b458-6275b4830e0d"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("215aca51-0b55-4f6a-85f6-d7ae76d69eaf"), "Batman Begins" },
                    { new Guid("e88e29f5-01d4-4f5a-b8ea-34abcb028b26"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("215aca51-0b55-4f6a-85f6-d7ae76d69eaf"), "The Dark Knight Rises" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("0f7d26e2-af36-4b9a-a166-480b50925b5b"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("98c7452b-05b9-425a-bb8d-cded9ae875cd") },
                    { new Guid("3761f8ae-1ada-4027-8694-fe505a9dbee0"), "She's good at spying at people.", "Espionage", new Guid("98c7452b-05b9-425a-bb8d-cded9ae875cd") },
                    { new Guid("3fc1ca12-ba73-428c-8f54-5c4e33efb0c0"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("98c7452b-05b9-425a-bb8d-cded9ae875cd") },
                    { new Guid("624dd538-1867-4d2b-8786-ed460614617b"), "Sublime fighting skills.", "Fighting", new Guid("215aca51-0b55-4f6a-85f6-d7ae76d69eaf") },
                    { new Guid("7eee770d-ab9f-441f-bbd2-9cf20f3baad2"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("f6b47376-f833-40d7-91c1-82580393cc2c") },
                    { new Guid("90808c5c-74a5-4605-83a6-d910f92c5cc8"), "He's always a step ahead.", "Intellect.", new Guid("215aca51-0b55-4f6a-85f6-d7ae76d69eaf") },
                    { new Guid("eddc4e8e-4872-444b-b616-bb2de9dec4ef"), "He got a lot of money", "Wealth.", new Guid("215aca51-0b55-4f6a-85f6-d7ae76d69eaf") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CodeDetail_CodeHeaderId",
                table: "CodeDetail",
                column: "CodeHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_WalletAddress",
                table: "Users",
                column: "WalletAddress",
                unique: true);
        }
    }
}
