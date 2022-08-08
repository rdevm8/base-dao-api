using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0052 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    CodeHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DetailCd = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
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
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    WalletAddress = table.Column<string>(type: "nvarchar(42)", maxLength: 42, nullable: false),
                    AmtInvested = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    AmtReturned = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    { new Guid("08d2e890-d7ad-4eb0-a710-37672a5cd98d"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7380), "SYSTEM", "CodeHeader for Pool Activity Statuses", "PASTATUS", false, new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7381), "SYSTEM" },
                    { new Guid("27779cb4-695d-418b-a280-12ef6d8f1606"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7379), "SYSTEM", "CodeHeader for Pool Funder Statuses", "PFSTATUS", false, new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7379), "SYSTEM" },
                    { new Guid("4624cb8f-ba13-4f87-89f4-7ee476abc524"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7369), "SYSTEM", "CodeHeader for User Roles", "ROLE", false, new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7372), "SYSTEM" },
                    { new Guid("47af2b2b-0e80-4f4e-9f3a-5dfb9dbd77a9"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7377), "SYSTEM", "CodeHeader for Pool Statuses", "PSTATUS", false, new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7377), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreatedBy", "IsDeleted", "Order", "Question", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3a3a5773-4b74-4be1-8436-83fea7f4e099"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(8437), "SYSTEM", false, 3, "What are the Pooling Rules?", new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(8437), "SYSTEM" },
                    { new Guid("51c7df49-86e3-4dec-ae9a-48f152c78d31"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(8431), "SYSTEM", false, 1, "What is Wick's Crew?", new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(8432), "SYSTEM" },
                    { new Guid("867c592d-fe25-4360-98bf-0d6f9f9472b3"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(8441), "SYSTEM", false, 5, "How are the Funds Distributed?", new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(8441), "SYSTEM" },
                    { new Guid("ae3b3e6c-396c-4873-a3c2-ff6723057088"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(8435), "SYSTEM", false, 2, "What are Pooling Considerations?", new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(8436), "SYSTEM" },
                    { new Guid("be37afc6-4663-4357-857e-165ed0667d63"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(8439), "SYSTEM", false, 4, "What are the Available Pools?", new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(8439), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "IsDeleted", "Name", "UpdateDttm", "UpdatedBy", "WalletAddress" },
                values: new object[,]
                {
                    { new Guid("8b2a0f70-5386-4746-9440-514867f730c1"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(8938), "SYSTEM", false, "SYSTEM", new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(8938), "SYSTEM", "0x8c268f32D7F129ac0D9FB1E5B490d90810dFa446" },
                    { new Guid("ff3b8dd0-3613-425d-9cc2-e553caab4244"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(8945), "SYSTEM", false, "ADMIN-1", new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(8945), "SYSTEM", "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266" }
                });

            migrationBuilder.InsertData(
                table: "CodeDetails",
                columns: new[] { "Id", "CodeHeaderId", "CreateDttm", "CreatedBy", "Description", "DetailCd", "IsDeleted", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("19eae460-17ce-4fee-92c6-83e53aef18e7"), new Guid("27779cb4-695d-418b-a280-12ef6d8f1606"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7986), "SYSTEM", "Pool funder OUT", "PFTATUS-OUT", false, new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7986), "SYSTEM" },
                    { new Guid("2b5d72a4-ebd3-436e-a28e-4a34565acd6d"), new Guid("08d2e890-d7ad-4eb0-a710-37672a5cd98d"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7995), "SYSTEM", "Pool activity funders update", "PASTATUS-FU", false, new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7995), "SYSTEM" },
                    { new Guid("3121cea8-4779-44fa-a77b-b435d1048515"), new Guid("47af2b2b-0e80-4f4e-9f3a-5dfb9dbd77a9"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7981), "SYSTEM", "Pool CLOSED", "PSTATUS-CLOSED", false, new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7982), "SYSTEM" },
                    { new Guid("55db0242-3c39-4967-b3db-d92cf00e0b39"), new Guid("47af2b2b-0e80-4f4e-9f3a-5dfb9dbd77a9"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7977), "SYSTEM", "Pool OPEN", "PSTATUS-OPEN", false, new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7978), "SYSTEM" },
                    { new Guid("5cfae912-4d88-4ce8-bef7-da795e54402c"), new Guid("4624cb8f-ba13-4f87-89f4-7ee476abc524"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7975), "SYSTEM", "Normal User", "ROLE-NORMAL", false, new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7976), "SYSTEM" },
                    { new Guid("7238ff2a-c0de-4a28-aeef-a2ef404d14d1"), new Guid("47af2b2b-0e80-4f4e-9f3a-5dfb9dbd77a9"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7979), "SYSTEM", "Pool ONGOING", "PSTATUS-ONGOING", false, new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7980), "SYSTEM" },
                    { new Guid("7d08feea-93c3-4ceb-9722-353b74b478d8"), new Guid("4624cb8f-ba13-4f87-89f4-7ee476abc524"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7963), "SYSTEM", "System User", "ROLE-SYSTEM", false, new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7963), "SYSTEM" },
                    { new Guid("8d682f80-f9b5-4fa4-a91e-7df26a7e80d3"), new Guid("08d2e890-d7ad-4eb0-a710-37672a5cd98d"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7993), "SYSTEM", "Pool activity descriptions update", "PASTATUS-PU", false, new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7993), "SYSTEM" },
                    { new Guid("9d9a7df4-f4ae-460c-878d-d8b9222ad154"), new Guid("4624cb8f-ba13-4f87-89f4-7ee476abc524"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7973), "SYSTEM", "Admin User", "ROLE-ADMIN", false, new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7973), "SYSTEM" },
                    { new Guid("ad933d88-4db5-4972-86a1-c386daa4f83c"), new Guid("27779cb4-695d-418b-a280-12ef6d8f1606"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7984), "SYSTEM", "Pool funder IN", "PFSTATUS-IN", false, new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7984), "SYSTEM" },
                    { new Guid("b8ccf71d-0456-4695-be3f-bcdd66b81968"), new Guid("08d2e890-d7ad-4eb0-a710-37672a5cd98d"), new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7988), "SYSTEM", "Pool activity status update", "PASTATUS-SU", false, new DateTime(2022, 8, 8, 11, 21, 21, 587, DateTimeKind.Utc).AddTicks(7988), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "IsDeleted", "RoleId", "UpdateDttm", "UpdatedBy", "UserId" },
                values: new object[] { new Guid("16524b67-80c1-406c-9d42-285bf8cf7157"), new DateTime(2022, 8, 8, 11, 21, 21, 588, DateTimeKind.Utc).AddTicks(78), "SYSTEM", false, new Guid("7d08feea-93c3-4ceb-9722-353b74b478d8"), new DateTime(2022, 8, 8, 11, 21, 21, 588, DateTimeKind.Utc).AddTicks(78), "SYSTEM", new Guid("8b2a0f70-5386-4746-9440-514867f730c1") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "IsDeleted", "RoleId", "UpdateDttm", "UpdatedBy", "UserId" },
                values: new object[] { new Guid("fb5d3d7a-2691-4119-9374-9afe0343d935"), new DateTime(2022, 8, 8, 11, 21, 21, 588, DateTimeKind.Utc).AddTicks(81), "SYSTEM", false, new Guid("9d9a7df4-f4ae-460c-878d-d8b9222ad154"), new DateTime(2022, 8, 8, 11, 21, 21, 588, DateTimeKind.Utc).AddTicks(81), "SYSTEM", new Guid("ff3b8dd0-3613-425d-9cc2-e553caab4244") });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("3a3a5773-4b74-4be1-8436-83fea7f4e099"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("51c7df49-86e3-4dec-ae9a-48f152c78d31"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("867c592d-fe25-4360-98bf-0d6f9f9472b3"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("ae3b3e6c-396c-4873-a3c2-ff6723057088"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("be37afc6-4663-4357-857e-165ed0667d63"));

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
    }
}
