using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Superpowers");

            migrationBuilder.DropTable(
                name: "Superheroes");

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
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17ffb001-fb2c-424a-8e73-bce644b9b490"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("063be586-1ee1-4198-be45-dd1a88dd68ca"));

            migrationBuilder.CreateTable(
                name: "Pools",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MinInvestment = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CodeDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pools_CodeDetails_CodeDetailId",
                        column: x => x.CodeDetailId,
                        principalTable: "CodeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PoolActivities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PoolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoolActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoolActivities_CodeDetails_CodeDetailId",
                        column: x => x.CodeDetailId,
                        principalTable: "CodeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PoolActivities_Pools_PoolId",
                        column: x => x.PoolId,
                        principalTable: "Pools",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PoolFunders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WalletAddress = table.Column<string>(type: "nvarchar(42)", maxLength: 42, nullable: false),
                    AmtInvested = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    AmtReturned = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    PoolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoolFunders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoolFunders_Pools_PoolId",
                        column: x => x.PoolId,
                        principalTable: "Pools",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "CodeHeaders",
                columns: new[] { "Id", "CreateDttm", "CreateUserId", "Description", "HeaderCd", "IsActive", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("aeff3c75-5050-4bdc-9f1d-b73cb82f066f"), new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2540), new Guid("00000000-0000-0000-0000-000000000000"), "CodeHeader for Pool Statuses", "PSTATUS", true, new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2541), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cf4b52a1-013f-4976-b98a-7deccc0d76dc"), new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2523), new Guid("00000000-0000-0000-0000-000000000000"), "CodeHeader for User Roles", "ROLE", true, new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2533), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreateUserId", "IsActive", "Question", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("7c0420c1-22c1-4f1e-be87-4e2871fdb348"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2805), new Guid("00000000-0000-0000-0000-000000000000"), true, "What is Wick's Crew?", new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2805), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("80187e77-81b5-40cd-bcac-fc25f86daec8"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2814), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Pooling Rules?", new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2815), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("838c8c98-fc47-4b85-9a76-f0d37f453b41"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2816), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are the Available Pools?", new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2817), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9111dd86-0ca0-4dec-8f84-ded2bae53516"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2809), new Guid("00000000-0000-0000-0000-000000000000"), true, "What are Pooling Considerations?", new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2810), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a0b20759-8baa-49eb-a7e1-482d3f97a21e"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2818), new Guid("00000000-0000-0000-0000-000000000000"), true, "How are the Funds Distributed?", new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2818), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDttm", "CreateUserId", "IsActive", "UpdateDttm", "UpdateUserId", "WalletAddress" },
                values: new object[] { new Guid("bb633210-ef25-4671-a246-e75027b5b5cb"), new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(3559), new Guid("00000000-0000-0000-0000-000000000000"), true, new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(3561), new Guid("00000000-0000-0000-0000-000000000000"), "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266" });

            migrationBuilder.InsertData(
                table: "CodeDetails",
                columns: new[] { "Id", "CodeHeaderId", "CreateDttm", "CreateUserId", "Description", "DetailCd", "IsActive", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("3728026c-18c2-4cb8-bb29-82a3d54f0f79"), new Guid("aeff3c75-5050-4bdc-9f1d-b73cb82f066f"), new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2694), new Guid("00000000-0000-0000-0000-000000000000"), "Pool OPEN", "PSTATUS-OPEN", true, new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2694), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("51aab4c4-1a1f-49d4-9665-ac932f5b3349"), new Guid("aeff3c75-5050-4bdc-9f1d-b73cb82f066f"), new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2696), new Guid("00000000-0000-0000-0000-000000000000"), "Pool ONGOING", "PSTATUS-ONGOING", true, new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2697), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("93ca2536-db18-4df4-87e9-59cdbfe26daa"), new Guid("cf4b52a1-013f-4976-b98a-7deccc0d76dc"), new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2687), new Guid("00000000-0000-0000-0000-000000000000"), "Admin User", "ROLE-ADMIN", true, new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2688), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d0133e46-3bc5-41ee-bcdf-94501fa3dca5"), new Guid("cf4b52a1-013f-4976-b98a-7deccc0d76dc"), new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2692), new Guid("00000000-0000-0000-0000-000000000000"), "Normal User", "ROLE-NORMAL", true, new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2692), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("dd43c4bd-4117-4978-acb4-bfffeaf5c64d"), new Guid("aeff3c75-5050-4bdc-9f1d-b73cb82f066f"), new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2698), new Guid("00000000-0000-0000-0000-000000000000"), "Pool CLOSED", "PSTATUS-CLOSED", true, new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(2699), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CodeDetailId", "CreateDttm", "CreateUserId", "IsActive", "UpdateDttm", "UpdateUserId", "UserId" },
                values: new object[] { new Guid("4131f3aa-ae7e-4d1b-ad88-c34939d99f3d"), new Guid("93ca2536-db18-4df4-87e9-59cdbfe26daa"), new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(3655), new Guid("00000000-0000-0000-0000-000000000000"), true, new DateTime(2022, 8, 4, 0, 9, 30, 963, DateTimeKind.Local).AddTicks(3655), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("bb633210-ef25-4671-a246-e75027b5b5cb") });

            migrationBuilder.CreateIndex(
                name: "IX_PoolActivities_CodeDetailId",
                table: "PoolActivities",
                column: "CodeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PoolActivities_PoolId",
                table: "PoolActivities",
                column: "PoolId");

            migrationBuilder.CreateIndex(
                name: "IX_PoolFunders_PoolId",
                table: "PoolFunders",
                column: "PoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Pools_CodeDetailId",
                table: "Pools",
                column: "CodeDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PoolActivities");

            migrationBuilder.DropTable(
                name: "PoolFunders");

            migrationBuilder.DropTable(
                name: "Pools");

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("3728026c-18c2-4cb8-bb29-82a3d54f0f79"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("51aab4c4-1a1f-49d4-9665-ac932f5b3349"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("d0133e46-3bc5-41ee-bcdf-94501fa3dca5"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("dd43c4bd-4117-4978-acb4-bfffeaf5c64d"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("7c0420c1-22c1-4f1e-be87-4e2871fdb348"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("80187e77-81b5-40cd-bcac-fc25f86daec8"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("838c8c98-fc47-4b85-9a76-f0d37f453b41"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("9111dd86-0ca0-4dec-8f84-ded2bae53516"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("a0b20759-8baa-49eb-a7e1-482d3f97a21e"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("4131f3aa-ae7e-4d1b-ad88-c34939d99f3d"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("93ca2536-db18-4df4-87e9-59cdbfe26daa"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("aeff3c75-5050-4bdc-9f1d-b73cb82f066f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bb633210-ef25-4671-a246-e75027b5b5cb"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("cf4b52a1-013f-4976-b98a-7deccc0d76dc"));

            migrationBuilder.CreateTable(
                name: "Superheroes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superheroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Superpowers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperPower = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superpowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Superpowers_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Movies_SuperheroId",
                table: "Movies",
                column: "SuperheroId");

            migrationBuilder.CreateIndex(
                name: "IX_Superpowers_SuperheroId",
                table: "Superpowers",
                column: "SuperheroId");
        }
    }
}
