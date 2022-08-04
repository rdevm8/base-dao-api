using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0043 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CodeHeaders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HeaderCd = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    Order = table.Column<int>(type: "int", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    WalletAddress = table.Column<string>(type: "nvarchar(42)", maxLength: 42, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    DetailCd = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CodeHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MinInvestment = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CodeDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PoolActivities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PoolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "Description", "HeaderCd", "IsDeleted", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("08ceef9d-ccd7-4382-9826-0228a3aa0c30"), new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(187), "SYSTEM", "CodeHeader for Pool Statuses", "PSTATUS", false, new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(187), "SYSTEM" },
                    { new Guid("db078c10-5d17-45fc-a152-5a92c025987a"), new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(181), "SYSTEM", "CodeHeader for User Roles", "ROLE", false, new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(183), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreatedBy", "IsDeleted", "Order", "Question", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1901e775-0f1a-476f-bc9b-7dded1234e6c"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1717), "SYSTEM", false, 4, "What are the Available Pools?", new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1717), "SYSTEM" },
                    { new Guid("636c3c34-0e34-4350-8418-9dcfe208efa9"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1715), "SYSTEM", false, 3, "What are the Pooling Rules?", new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1716), "SYSTEM" },
                    { new Guid("653f2905-f796-451d-a765-4aef6bbcb882"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1709), "SYSTEM", false, 1, "What is Wick's Crew?", new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1710), "SYSTEM" },
                    { new Guid("818fb495-103a-4791-8763-a1345f26f603"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1713), "SYSTEM", false, 2, "What are Pooling Considerations?", new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1713), "SYSTEM" },
                    { new Guid("95556253-065b-4d71-93db-15a06b207f82"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1724), "SYSTEM", false, 5, "How are the Funds Distributed?", new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(1724), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "IsDeleted", "Name", "UpdateDttm", "UpdatedBy", "WalletAddress" },
                values: new object[,]
                {
                    { new Guid("05715151-b20d-42fe-a507-84f0a92e4eb3"), new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(2239), "SYSTEM", false, "", new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(2240), "SYSTEM", "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266" },
                    { new Guid("e09ac335-3f94-4d21-aaec-ac4dd5395297"), new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(2242), "SYSTEM", false, "SYSTEM", new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(2242), "SYSTEM", "" }
                });

            migrationBuilder.InsertData(
                table: "CodeDetails",
                columns: new[] { "Id", "CodeHeaderId", "CreateDttm", "CreatedBy", "Description", "DetailCd", "IsDeleted", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3b93f365-8551-44ae-8728-7d5020595031"), new Guid("08ceef9d-ccd7-4382-9826-0228a3aa0c30"), new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(782), "SYSTEM", "Pool CLOSED", "PSTATUS-CLOSED", false, new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(783), "SYSTEM" },
                    { new Guid("46616b24-cc7c-4a1e-9189-5db9f0452f48"), new Guid("db078c10-5d17-45fc-a152-5a92c025987a"), new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(768), "SYSTEM", "Admin User", "ROLE-ADMIN", false, new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(768), "SYSTEM" },
                    { new Guid("c038b645-fb66-4083-945b-47851f4cfe5f"), new Guid("08ceef9d-ccd7-4382-9826-0228a3aa0c30"), new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(781), "SYSTEM", "Pool ONGOING", "PSTATUS-ONGOING", false, new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(781), "SYSTEM" },
                    { new Guid("d9ecea68-8bc0-4acd-8ce6-e4b08b227c2d"), new Guid("db078c10-5d17-45fc-a152-5a92c025987a"), new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(771), "SYSTEM", "Normal User", "ROLE-NORMAL", false, new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(772), "SYSTEM" },
                    { new Guid("e57d3bbc-393a-4eba-9877-ab91a4403512"), new Guid("08ceef9d-ccd7-4382-9826-0228a3aa0c30"), new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(778), "SYSTEM", "Pool OPEN", "PSTATUS-OPEN", false, new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(779), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CodeDetailId", "CreateDttm", "CreatedBy", "IsDeleted", "UpdateDttm", "UpdatedBy", "UserId" },
                values: new object[] { new Guid("3f853db1-60c7-4199-a6d9-1d01f780b5cb"), new Guid("46616b24-cc7c-4a1e-9189-5db9f0452f48"), new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(3591), "SYSTEM", false, new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(3591), "SYSTEM", new Guid("e09ac335-3f94-4d21-aaec-ac4dd5395297") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CodeDetailId", "CreateDttm", "CreatedBy", "IsDeleted", "UpdateDttm", "UpdatedBy", "UserId" },
                values: new object[] { new Guid("649c1244-3ad7-4413-a48f-bfed97a4dc1a"), new Guid("46616b24-cc7c-4a1e-9189-5db9f0452f48"), new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(3587), "SYSTEM", false, new DateTime(2022, 8, 4, 12, 41, 0, 652, DateTimeKind.Utc).AddTicks(3588), "SYSTEM", new Guid("05715151-b20d-42fe-a507-84f0a92e4eb3") });

            migrationBuilder.CreateIndex(
                name: "IX_CodeDetails_CodeHeaderId",
                table: "CodeDetails",
                column: "CodeHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeDetails_DetailCd",
                table: "CodeDetails",
                column: "DetailCd",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CodeHeaders_HeaderCd",
                table: "CodeHeaders",
                column: "HeaderCd",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Faqs_Order",
                table: "Faqs",
                column: "Order",
                unique: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
