using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0051 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("0152d32b-4ba9-4175-92f3-10b21218ad67"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("207a74dd-90a5-4d95-90e5-20d32029bf81"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("2c7fc0c2-4d1e-43fc-9edd-04a206fe3e32"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("42a8e54c-fe7b-4eca-a9e5-4b7e5cf4a753"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("d956ed07-29cf-4ef9-9319-3d6c6221b3a3"));

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreatedBy", "IsDeleted", "Order", "Question", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("11a7f9cc-4033-49ac-a9a7-370314727712"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 8, 11, 20, 54, 232, DateTimeKind.Utc).AddTicks(7485), "SYSTEM", false, 3, "What are the Pooling Rules?", new DateTime(2022, 8, 8, 11, 20, 54, 232, DateTimeKind.Utc).AddTicks(7486), "SYSTEM" },
                    { new Guid("1cf62a72-e7cb-448c-a770-74ff05809d78"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 8, 11, 20, 54, 232, DateTimeKind.Utc).AddTicks(7489), "SYSTEM", false, 5, "How are the Funds Distributed?", new DateTime(2022, 8, 8, 11, 20, 54, 232, DateTimeKind.Utc).AddTicks(7489), "SYSTEM" },
                    { new Guid("43699d37-8b1f-4e7a-b976-d46a5f280ba8"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 8, 11, 20, 54, 232, DateTimeKind.Utc).AddTicks(7487), "SYSTEM", false, 4, "What are the Available Pools?", new DateTime(2022, 8, 8, 11, 20, 54, 232, DateTimeKind.Utc).AddTicks(7487), "SYSTEM" },
                    { new Guid("96976919-943b-43c7-bc73-6c5ff8f2eec3"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 8, 11, 20, 54, 232, DateTimeKind.Utc).AddTicks(7484), "SYSTEM", false, 2, "What are Pooling Considerations?", new DateTime(2022, 8, 8, 11, 20, 54, 232, DateTimeKind.Utc).AddTicks(7484), "SYSTEM" },
                    { new Guid("a9c56e9a-8936-4328-9e96-3ddc2aa162f5"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 8, 11, 20, 54, 232, DateTimeKind.Utc).AddTicks(7477), "SYSTEM", false, 1, "What is Wick's Crew?", new DateTime(2022, 8, 8, 11, 20, 54, 232, DateTimeKind.Utc).AddTicks(7480), "SYSTEM" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("11a7f9cc-4033-49ac-a9a7-370314727712"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("1cf62a72-e7cb-448c-a770-74ff05809d78"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("43699d37-8b1f-4e7a-b976-d46a5f280ba8"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("96976919-943b-43c7-bc73-6c5ff8f2eec3"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("a9c56e9a-8936-4328-9e96-3ddc2aa162f5"));

            migrationBuilder.CreateTable(
                name: "CodeHeaders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    HeaderCd = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeHeaders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
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
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DetailCd = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
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
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    MinInvestment = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pools_CodeDetails_StatusId",
                        column: x => x.StatusId,
                        principalTable: "CodeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_CodeDetails_RoleId",
                        column: x => x.RoleId,
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
                    PoolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoolActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoolActivities_CodeDetails_StatusId",
                        column: x => x.StatusId,
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
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmtInvested = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    AmtReturned = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CreateDttm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDttm = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    WalletAddress = table.Column<string>(type: "nvarchar(42)", maxLength: 42, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoolFunders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoolFunders_CodeDetails_StatusId",
                        column: x => x.StatusId,
                        principalTable: "CodeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { new Guid("9379bf85-666f-4edc-bd67-3519b29c991c"), new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(3581), "SYSTEM", "CodeHeader for Pool Statuses", "PSTATUS", false, new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(3582), "SYSTEM" },
                    { new Guid("cad9cbd3-b334-4827-92da-ba986d07d658"), new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(3572), "SYSTEM", "CodeHeader for User Roles", "ROLE", false, new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(3575), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreatedBy", "IsDeleted", "Order", "Question", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0152d32b-4ba9-4175-92f3-10b21218ad67"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(5089), "SYSTEM", false, 3, "What are the Pooling Rules?", new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(5090), "SYSTEM" },
                    { new Guid("207a74dd-90a5-4d95-90e5-20d32029bf81"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(5092), "SYSTEM", false, 5, "How are the Funds Distributed?", new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(5093), "SYSTEM" },
                    { new Guid("2c7fc0c2-4d1e-43fc-9edd-04a206fe3e32"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(5087), "SYSTEM", false, 2, "What are Pooling Considerations?", new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(5088), "SYSTEM" },
                    { new Guid("42a8e54c-fe7b-4eca-a9e5-4b7e5cf4a753"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(5091), "SYSTEM", false, 4, "What are the Available Pools?", new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(5091), "SYSTEM" },
                    { new Guid("d956ed07-29cf-4ef9-9319-3d6c6221b3a3"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(5084), "SYSTEM", false, 1, "What is Wick's Crew?", new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(5085), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "IsDeleted", "Name", "UpdateDttm", "UpdatedBy", "WalletAddress" },
                values: new object[,]
                {
                    { new Guid("2afbf58b-c7a9-4494-8037-7f2835fbc9a7"), new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(5697), "SYSTEM", false, "ADMIN-1", new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(5698), "SYSTEM", "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266" },
                    { new Guid("b4a19bc7-abb2-44e7-b9eb-dc866dae266d"), new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(5693), "SYSTEM", false, "SYSTEM", new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(5694), "SYSTEM", "0x8c268f32D7F129ac0D9FB1E5B490d90810dFa446" }
                });

            migrationBuilder.InsertData(
                table: "CodeDetails",
                columns: new[] { "Id", "CodeHeaderId", "CreateDttm", "CreatedBy", "Description", "DetailCd", "IsDeleted", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2379da2d-12d5-41c4-beea-b4811a4ac0fe"), new Guid("9379bf85-666f-4edc-bd67-3519b29c991c"), new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(4566), "SYSTEM", "Pool OPEN", "PSTATUS-OPEN", false, new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(4566), "SYSTEM" },
                    { new Guid("2deb65ba-dc2d-4d1d-b65b-96449ca876b2"), new Guid("cad9cbd3-b334-4827-92da-ba986d07d658"), new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(4549), "SYSTEM", "System User", "ROLE-SYSTEM", false, new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(4550), "SYSTEM" },
                    { new Guid("7508605d-8d64-412d-b432-514810043eb8"), new Guid("cad9cbd3-b334-4827-92da-ba986d07d658"), new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(4556), "SYSTEM", "Normal User", "ROLE-NORMAL", false, new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(4556), "SYSTEM" },
                    { new Guid("ac07ff79-4792-4d96-9dca-b1c38b2fb5d9"), new Guid("cad9cbd3-b334-4827-92da-ba986d07d658"), new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(4553), "SYSTEM", "Admin User", "ROLE-ADMIN", false, new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(4554), "SYSTEM" },
                    { new Guid("c937c13b-de72-457b-99fb-40ef1f148628"), new Guid("9379bf85-666f-4edc-bd67-3519b29c991c"), new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(4569), "SYSTEM", "Pool ONGOING", "PSTATUS-ONGOING", false, new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(4569), "SYSTEM" },
                    { new Guid("f0674d98-917e-4d28-9f47-8a289864e4ae"), new Guid("9379bf85-666f-4edc-bd67-3519b29c991c"), new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(4572), "SYSTEM", "Pool CLOSED", "PSTATUS-CLOSED", false, new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(4572), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "IsDeleted", "RoleId", "UpdateDttm", "UpdatedBy", "UserId" },
                values: new object[] { new Guid("1bc3c37a-ea63-4e23-a8d4-3d0e43323749"), new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(6975), "SYSTEM", false, new Guid("2deb65ba-dc2d-4d1d-b65b-96449ca876b2"), new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(6976), "SYSTEM", new Guid("b4a19bc7-abb2-44e7-b9eb-dc866dae266d") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "IsDeleted", "RoleId", "UpdateDttm", "UpdatedBy", "UserId" },
                values: new object[] { new Guid("de19548f-9628-4159-b4a8-6b95913bce1a"), new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(6979), "SYSTEM", false, new Guid("ac07ff79-4792-4d96-9dca-b1c38b2fb5d9"), new DateTime(2022, 8, 5, 5, 12, 24, 344, DateTimeKind.Utc).AddTicks(6980), "SYSTEM", new Guid("2afbf58b-c7a9-4494-8037-7f2835fbc9a7") });

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
                name: "IX_PoolActivities_PoolId",
                table: "PoolActivities",
                column: "PoolId");

            migrationBuilder.CreateIndex(
                name: "IX_PoolActivities_StatusId",
                table: "PoolActivities",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PoolFunders_PoolId",
                table: "PoolFunders",
                column: "PoolId");

            migrationBuilder.CreateIndex(
                name: "IX_PoolFunders_StatusId",
                table: "PoolFunders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Pools_StatusId",
                table: "Pools",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

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
