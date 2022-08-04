using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0042 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.DropTable(
                name: "PoolActivities");

            migrationBuilder.DropTable(
                name: "PoolFunders");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Pools");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CodeDetails");

            migrationBuilder.DropTable(
                name: "CodeHeaders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CodeHeaders",
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
                    table.PrimaryKey("PK_CodeHeaders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WalletAddress = table.Column<string>(type: "nvarchar(42)", maxLength: 42, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CodeDetails",
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
                    table.PrimaryKey("PK_CodeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CodeDetails_CodeHeaders_CodeHeaderId",
                        column: x => x.CodeHeaderId,
                        principalTable: "CodeHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pools",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    MinInvestment = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_CodeDetails_CodeDetailId",
                        column: x => x.CodeDetailId,
                        principalTable: "CodeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PoolActivities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PoolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    PoolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmtInvested = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    AmtReturned = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WalletAddress = table.Column<string>(type: "nvarchar(42)", maxLength: 42, nullable: false)
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
                    { new Guid("01a147bd-9e4b-4f60-8dba-ff7d75ae7280"), new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(583), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), "CodeHeader for User Roles", "ROLE", true, new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(592), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5") },
                    { new Guid("e18e094a-ee28-45f6-93de-54c99263d06d"), new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(596), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), "CodeHeader for Pool Statuses", "PSTATUS", true, new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(597), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5") }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreateUserId", "IsActive", "Order", "Question", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("0dc1e163-3bdc-4c2e-8033-8cc11284901d"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(909), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), true, 2, "What are Pooling Considerations?", new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(910), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5") },
                    { new Guid("750624a4-919d-4b0e-ab32-2415bf703dc1"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(913), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), true, 4, "What are the Available Pools?", new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(914), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5") },
                    { new Guid("9f45a9e7-d421-4b8a-90c8-455164e13930"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(911), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), true, 3, "What are the Pooling Rules?", new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(912), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5") },
                    { new Guid("e55e8522-06a4-4a14-9d36-0c90d5496b1c"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(901), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), true, 1, "What is Wick's Crew?", new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(902), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5") },
                    { new Guid("f26fbd08-c78e-451b-8cab-b185760f7be0"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(915), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), true, 5, "How are the Funds Distributed?", new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(916), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDttm", "CreateUserId", "IsActive", "Name", "UpdateDttm", "UpdateUserId", "WalletAddress" },
                values: new object[,]
                {
                    { new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(1692), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), true, "SYSTEM", new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(1692), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), "" },
                    { new Guid("c0d556e3-4b87-445c-9868-8cce26999e2e"), new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(1684), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), true, "", new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(1686), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266" }
                });

            migrationBuilder.InsertData(
                table: "CodeDetails",
                columns: new[] { "Id", "CodeHeaderId", "CreateDttm", "CreateUserId", "Description", "DetailCd", "IsActive", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("46aedee3-c9e6-4204-ad04-97c96a6ab07a"), new Guid("01a147bd-9e4b-4f60-8dba-ff7d75ae7280"), new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(753), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), "Admin User", "ROLE-ADMIN", true, new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(753), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5") },
                    { new Guid("88ae6abb-78f6-4aee-8103-6bb2ce5e7d31"), new Guid("e18e094a-ee28-45f6-93de-54c99263d06d"), new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(761), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), "Pool ONGOING", "PSTATUS-ONGOING", true, new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(762), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5") },
                    { new Guid("c7d0105a-cc82-4f97-bc4c-79f0d21e483b"), new Guid("e18e094a-ee28-45f6-93de-54c99263d06d"), new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(763), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), "Pool CLOSED", "PSTATUS-CLOSED", true, new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(764), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5") },
                    { new Guid("e996353d-8f34-4b5b-8f74-d6fdc8bf5f76"), new Guid("01a147bd-9e4b-4f60-8dba-ff7d75ae7280"), new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(757), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), "Normal User", "ROLE-NORMAL", true, new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(758), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5") },
                    { new Guid("ef9be470-b772-483c-a782-ab1f371b094c"), new Guid("e18e094a-ee28-45f6-93de-54c99263d06d"), new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(759), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), "Pool OPEN", "PSTATUS-OPEN", true, new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(760), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CodeDetailId", "CreateDttm", "CreateUserId", "IsActive", "UpdateDttm", "UpdateUserId", "UserId" },
                values: new object[] { new Guid("277e912b-b949-4f80-9656-fc1f0f15ce32"), new Guid("46aedee3-c9e6-4204-ad04-97c96a6ab07a"), new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(1782), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), true, new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(1782), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CodeDetailId", "CreateDttm", "CreateUserId", "IsActive", "UpdateDttm", "UpdateUserId", "UserId" },
                values: new object[] { new Guid("9b6c9a88-58d4-4e5d-93c9-da8b9e478f73"), new Guid("46aedee3-c9e6-4204-ad04-97c96a6ab07a"), new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(1778), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), true, new DateTime(2022, 8, 4, 12, 32, 8, 934, DateTimeKind.Local).AddTicks(1779), new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"), new Guid("c0d556e3-4b87-445c-9868-8cce26999e2e") });

            migrationBuilder.CreateIndex(
                name: "IX_CodeDetails_CodeHeaderId",
                table: "CodeDetails",
                column: "CodeHeaderId");

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

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_CodeDetailId",
                table: "UserRoles",
                column: "CodeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_WalletAddress",
                table: "Users",
                column: "WalletAddress",
                unique: true);
        }
    }
}
