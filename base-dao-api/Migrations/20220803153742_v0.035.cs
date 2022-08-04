using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0035 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_CodeDetails_CodeDetailId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Users_UserId",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

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
                name: "UserRole",
                newName: "UserRoles");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_UserId",
                table: "UserRoles",
                newName: "IX_UserRoles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRole_CodeDetailId",
                table: "UserRoles",
                newName: "IX_UserRoles_CodeDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                column: "Id");

            migrationBuilder.InsertData(
                table: "CodeHeaders",
                columns: new[] { "Id", "CreateDttm", "CreateUserId", "Description", "HeaderCd", "IsActive", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("063be586-1ee1-4198-be45-dd1a88dd68ca"), new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3293), new Guid("00000000-0000-0000-0000-000000000000"), "CodeHeader for User Roles", "ROLE", true, new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3308), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b7f4a6d7-4b44-4813-bcf4-308a23b3170b"), new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3311), new Guid("00000000-0000-0000-0000-000000000000"), "CodeHeader for Pool Statuses", "PSTATUS", true, new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3312), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreateUserId", "IsActive", "Question", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("0cc3877b-6ed0-4cac-a8b8-0f5ba18d7897"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3434), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Pooling Rules?", new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3435), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("41e2043e-ff8d-4e63-8b01-f3c0b7047a31"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3436), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Available Pools?", new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3437), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("576043dc-804b-469b-811d-baa0255dd380"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3438), new Guid("00000000-0000-0000-0000-000000000000"), true, "How are the Funds Distributed?", new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3438), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8396fc73-45a4-46be-bc61-1ab0fc6f0343"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3430), new Guid("00000000-0000-0000-0000-000000000000"), true, "What is Wick's Crew?", new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3430), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a08be702-1789-496b-8d86-ee0ec20897f2"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3433), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are Pooling Considerations?", new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3433), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[,]
                {
                    { new Guid("1628f02e-79d9-4f20-9bbe-936c50247f48"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" },
                    { new Guid("70a0b3de-2088-4a34-935f-f59af8b4584b"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" },
                    { new Guid("b4344694-9e54-4632-8306-9bd39b228154"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDttm", "CreateUserId", "IsActive", "UpdateDttm", "UpdateUserId", "WalletAddress" },
                values: new object[] { new Guid("17ffb001-fb2c-424a-8e73-bce644b9b490"), new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(4430), new Guid("00000000-0000-0000-0000-000000000000"), true, new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(4431), new Guid("00000000-0000-0000-0000-000000000000"), "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266" });

            migrationBuilder.InsertData(
                table: "CodeDetails",
                columns: new[] { "Id", "CodeHeaderId", "CreateDttm", "CreateUserId", "Description", "DetailCd", "IsActive", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("275b7d25-dc39-409f-874c-1ac62b0fa02a"), new Guid("b7f4a6d7-4b44-4813-bcf4-308a23b3170b"), new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3372), new Guid("00000000-0000-0000-0000-000000000000"), "Pool CLOSED", "PSTATUS-CLOSED", true, new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3373), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("66d7a761-e1fc-46f2-98af-1773a57f3318"), new Guid("063be586-1ee1-4198-be45-dd1a88dd68ca"), new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3362), new Guid("00000000-0000-0000-0000-000000000000"), "Admin User", "ROLE-ADMIN", true, new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3363), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a5848c30-0d2b-4b11-8d15-e8fea13beaae"), new Guid("063be586-1ee1-4198-be45-dd1a88dd68ca"), new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3366), new Guid("00000000-0000-0000-0000-000000000000"), "Normal User", "ROLE-NORMAL", true, new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3367), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cbaa3265-5737-4773-ab85-caf8a8e2c699"), new Guid("b7f4a6d7-4b44-4813-bcf4-308a23b3170b"), new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3368), new Guid("00000000-0000-0000-0000-000000000000"), "Pool OPEN", "PSTATUS-OPEN", true, new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3369), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fbdc4f4d-414b-4a40-a13e-8d8f41ed41b1"), new Guid("b7f4a6d7-4b44-4813-bcf4-308a23b3170b"), new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3370), new Guid("00000000-0000-0000-0000-000000000000"), "Pool ONGOING", "PSTATUS-ONGOING", true, new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(3371), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("1260c297-aa6a-4757-8544-59f88bcbfd16"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("70a0b3de-2088-4a34-935f-f59af8b4584b"), "The Dark Knight" },
                    { new Guid("2e0b9320-b460-4932-a92e-c2ec7dd6f0ae"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b4344694-9e54-4632-8306-9bd39b228154"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("30fd683c-b5e5-4640-869b-37ba52500bf0"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("70a0b3de-2088-4a34-935f-f59af8b4584b"), "Batman Begins" },
                    { new Guid("517ce98e-86d3-4d97-a94d-16f05d1ff850"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("70a0b3de-2088-4a34-935f-f59af8b4584b"), "The Dark Knight Rises" },
                    { new Guid("5bb207a5-5649-4579-8bd8-dce393521935"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1628f02e-79d9-4f20-9bbe-936c50247f48"), "Black Widow" },
                    { new Guid("cca6871d-e627-4f4f-b0d3-949d8b406f07"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b4344694-9e54-4632-8306-9bd39b228154"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("eec0a8df-3aec-4d96-8adb-1807da790653"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b4344694-9e54-4632-8306-9bd39b228154"), "Star Wars: Episode V – The Empire Strikes Back" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("42c8c0a0-058a-4874-8e6a-3e5a8875a90b"), "He's always a step ahead.", "Intellect.", new Guid("70a0b3de-2088-4a34-935f-f59af8b4584b") },
                    { new Guid("748a572e-ebec-4c49-8e2e-5cff7e122734"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("b4344694-9e54-4632-8306-9bd39b228154") },
                    { new Guid("79d14245-f057-4f77-b645-ba0ac2d248d6"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("1628f02e-79d9-4f20-9bbe-936c50247f48") },
                    { new Guid("7bda86f1-fd7b-4cab-954f-30ae631dee5b"), "Sublime fighting skills.", "Fighting", new Guid("70a0b3de-2088-4a34-935f-f59af8b4584b") },
                    { new Guid("7db602c0-06f0-44a7-a03b-d2546d3ada6b"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("1628f02e-79d9-4f20-9bbe-936c50247f48") },
                    { new Guid("80e75e4e-85db-4c9c-9148-0183547c6a26"), "He got a lot of money", "Wealth.", new Guid("70a0b3de-2088-4a34-935f-f59af8b4584b") },
                    { new Guid("935f1020-d61d-4621-9965-b8a67790fc4a"), "She's good at spying at people.", "Espionage", new Guid("1628f02e-79d9-4f20-9bbe-936c50247f48") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CodeDetailId", "CreateDttm", "CreateUserId", "IsActive", "UpdateDttm", "UpdateUserId", "UserId" },
                values: new object[] { new Guid("401c13b6-d893-4672-9286-b33b6cbcd6e7"), new Guid("66d7a761-e1fc-46f2-98af-1773a57f3318"), new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(4512), new Guid("00000000-0000-0000-0000-000000000000"), true, new DateTime(2022, 8, 3, 23, 37, 41, 876, DateTimeKind.Local).AddTicks(4512), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("17ffb001-fb2c-424a-8e73-bce644b9b490") });

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_CodeDetails_CodeDetailId",
                table: "UserRoles",
                column: "CodeDetailId",
                principalTable: "CodeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_CodeDetails_CodeDetailId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("275b7d25-dc39-409f-874c-1ac62b0fa02a"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("a5848c30-0d2b-4b11-8d15-e8fea13beaae"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("cbaa3265-5737-4773-ab85-caf8a8e2c699"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("fbdc4f4d-414b-4a40-a13e-8d8f41ed41b1"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("0cc3877b-6ed0-4cac-a8b8-0f5ba18d7897"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("41e2043e-ff8d-4e63-8b01-f3c0b7047a31"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("576043dc-804b-469b-811d-baa0255dd380"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("8396fc73-45a4-46be-bc61-1ab0fc6f0343"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("a08be702-1789-496b-8d86-ee0ec20897f2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1260c297-aa6a-4757-8544-59f88bcbfd16"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2e0b9320-b460-4932-a92e-c2ec7dd6f0ae"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("30fd683c-b5e5-4640-869b-37ba52500bf0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("517ce98e-86d3-4d97-a94d-16f05d1ff850"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("5bb207a5-5649-4579-8bd8-dce393521935"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cca6871d-e627-4f4f-b0d3-949d8b406f07"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("eec0a8df-3aec-4d96-8adb-1807da790653"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("42c8c0a0-058a-4874-8e6a-3e5a8875a90b"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("748a572e-ebec-4c49-8e2e-5cff7e122734"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("79d14245-f057-4f77-b645-ba0ac2d248d6"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("7bda86f1-fd7b-4cab-954f-30ae631dee5b"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("7db602c0-06f0-44a7-a03b-d2546d3ada6b"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("80e75e4e-85db-4c9c-9148-0183547c6a26"));

            migrationBuilder.DeleteData(
                table: "Superpowers",
                keyColumn: "Id",
                keyValue: new Guid("935f1020-d61d-4621-9965-b8a67790fc4a"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("401c13b6-d893-4672-9286-b33b6cbcd6e7"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("66d7a761-e1fc-46f2-98af-1773a57f3318"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("b7f4a6d7-4b44-4813-bcf4-308a23b3170b"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("1628f02e-79d9-4f20-9bbe-936c50247f48"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("70a0b3de-2088-4a34-935f-f59af8b4584b"));

            migrationBuilder.DeleteData(
                table: "Superheroes",
                keyColumn: "Id",
                keyValue: new Guid("b4344694-9e54-4632-8306-9bd39b228154"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17ffb001-fb2c-424a-8e73-bce644b9b490"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("063be586-1ee1-4198-be45-dd1a88dd68ca"));

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "UserRole");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRole",
                newName: "IX_UserRole_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_CodeDetailId",
                table: "UserRole",
                newName: "IX_UserRole_CodeDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
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
                name: "FK_UserRole_CodeDetails_CodeDetailId",
                table: "UserRole",
                column: "CodeDetailId",
                principalTable: "CodeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Users_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
