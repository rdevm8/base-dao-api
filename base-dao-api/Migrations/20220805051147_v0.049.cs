using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0049 : Migration
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
                keyValue: new Guid("1e77f882-dae4-4999-9f8e-96744d715096"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("2b2ff831-73eb-43dc-8178-c20fc514c886"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("babe1567-4329-4cd0-8a22-b0ead3a39c67"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("d486524e-0c7a-41ff-b0aa-09788b56ac56"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("db9d9f76-042c-41ec-9d23-8686e16d1fda"));

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreatedBy", "IsDeleted", "Order", "Question", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("286d4492-cb01-45dc-8288-d2f3ba818bc3"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8924), "SYSTEM", false, 3, "What are the Pooling Rules?", new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8924), "SYSTEM" },
                    { new Guid("3f961360-c4fc-45c0-9baa-44702538cf4b"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8934), "SYSTEM", false, 5, "How are the Funds Distributed?", new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8934), "SYSTEM" },
                    { new Guid("6ef5c77f-3149-46ce-a28a-9d9545d6dcfd"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8922), "SYSTEM", false, 2, "What are Pooling Considerations?", new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8922), "SYSTEM" },
                    { new Guid("b8a0d975-b255-413c-a538-63eca482940a"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8932), "SYSTEM", false, 4, "What are the Available Pools?", new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8932), "SYSTEM" },
                    { new Guid("c12cc22f-e7ec-433a-aa0b-d3138e2c5acf"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8915), "SYSTEM", false, 1, "What is Wick's Crew?", new DateTime(2022, 8, 5, 5, 11, 46, 697, DateTimeKind.Utc).AddTicks(8917), "SYSTEM" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("286d4492-cb01-45dc-8288-d2f3ba818bc3"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("3f961360-c4fc-45c0-9baa-44702538cf4b"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("6ef5c77f-3149-46ce-a28a-9d9545d6dcfd"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("b8a0d975-b255-413c-a538-63eca482940a"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("c12cc22f-e7ec-433a-aa0b-d3138e2c5acf"));

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
                    { new Guid("3e6302a1-99fe-4d4b-a731-f7b449dc51c4"), new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(6370), "SYSTEM", "CodeHeader for Pool Statuses", "PSTATUS", false, new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(6371), "SYSTEM" },
                    { new Guid("42be1ccb-ae0f-4748-a591-8c73c17be5c4"), new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(6363), "SYSTEM", "CodeHeader for User Roles", "ROLE", false, new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(6365), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreatedBy", "IsDeleted", "Order", "Question", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1e77f882-dae4-4999-9f8e-96744d715096"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7519), "SYSTEM", false, 1, "What is Wick's Crew?", new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7519), "SYSTEM" },
                    { new Guid("2b2ff831-73eb-43dc-8178-c20fc514c886"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7525), "SYSTEM", false, 4, "What are the Available Pools?", new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7526), "SYSTEM" },
                    { new Guid("babe1567-4329-4cd0-8a22-b0ead3a39c67"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7522), "SYSTEM", false, 2, "What are Pooling Considerations?", new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7522), "SYSTEM" },
                    { new Guid("d486524e-0c7a-41ff-b0aa-09788b56ac56"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7527), "SYSTEM", false, 5, "How are the Funds Distributed?", new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7527), "SYSTEM" },
                    { new Guid("db9d9f76-042c-41ec-9d23-8686e16d1fda"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7524), "SYSTEM", false, 3, "What are the Pooling Rules?", new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7524), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "IsDeleted", "Name", "UpdateDttm", "UpdatedBy", "WalletAddress" },
                values: new object[,]
                {
                    { new Guid("52d09425-fb12-4945-b99c-e70b3e017096"), new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7936), "SYSTEM", false, "ADMIN-1", new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7936), "SYSTEM", "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266" },
                    { new Guid("8a118806-d143-4fc1-9201-99d1ced37122"), new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7929), "SYSTEM", false, "SYSTEM", new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7930), "SYSTEM", "0x8c268f32D7F129ac0D9FB1E5B490d90810dFa446" }
                });

            migrationBuilder.InsertData(
                table: "CodeDetails",
                columns: new[] { "Id", "CodeHeaderId", "CreateDttm", "CreatedBy", "Description", "DetailCd", "IsDeleted", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("493b376c-d7f6-438a-8730-0254d5a02a37"), new Guid("3e6302a1-99fe-4d4b-a731-f7b449dc51c4"), new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7079), "SYSTEM", "Pool CLOSED", "PSTATUS-CLOSED", false, new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7079), "SYSTEM" },
                    { new Guid("4def19b6-49ff-4183-9e47-866fc9dd9c3d"), new Guid("42be1ccb-ae0f-4748-a591-8c73c17be5c4"), new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7062), "SYSTEM", "Admin User", "ROLE-ADMIN", false, new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7062), "SYSTEM" },
                    { new Guid("65aea546-af92-4938-b244-81836d7477d9"), new Guid("42be1ccb-ae0f-4748-a591-8c73c17be5c4"), new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7058), "SYSTEM", "System User", "ROLE-SYSTEM", false, new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7059), "SYSTEM" },
                    { new Guid("dbafb88b-845c-4e6c-8f35-c3e20db898f6"), new Guid("42be1ccb-ae0f-4748-a591-8c73c17be5c4"), new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7066), "SYSTEM", "Normal User", "ROLE-NORMAL", false, new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7066), "SYSTEM" },
                    { new Guid("f4f1eff3-a5e5-4c59-83ca-0a4676e9617c"), new Guid("3e6302a1-99fe-4d4b-a731-f7b449dc51c4"), new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7070), "SYSTEM", "Pool OPEN", "PSTATUS-OPEN", false, new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7071), "SYSTEM" },
                    { new Guid("fb599b2d-d489-4377-a3df-10f02c53ee2f"), new Guid("3e6302a1-99fe-4d4b-a731-f7b449dc51c4"), new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7077), "SYSTEM", "Pool ONGOING", "PSTATUS-ONGOING", false, new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(7077), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "IsDeleted", "RoleId", "UpdateDttm", "UpdatedBy", "UserId" },
                values: new object[] { new Guid("6e758dc3-bbdb-477c-84f0-7770d994a5a4"), new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(9108), "SYSTEM", false, new Guid("65aea546-af92-4938-b244-81836d7477d9"), new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(9109), "SYSTEM", new Guid("8a118806-d143-4fc1-9201-99d1ced37122") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "IsDeleted", "RoleId", "UpdateDttm", "UpdatedBy", "UserId" },
                values: new object[] { new Guid("9cfe6f00-0add-4f85-aa20-10f5d2ff81b6"), new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(9111), "SYSTEM", false, new Guid("4def19b6-49ff-4183-9e47-866fc9dd9c3d"), new DateTime(2022, 8, 5, 5, 8, 31, 211, DateTimeKind.Utc).AddTicks(9112), "SYSTEM", new Guid("52d09425-fb12-4945-b99c-e70b3e017096") });

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
