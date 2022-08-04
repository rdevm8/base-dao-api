using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CodeDetail");

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
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb10c1a9-0010-4797-bf47-643dc40b884e"));

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
        }
    }
}
