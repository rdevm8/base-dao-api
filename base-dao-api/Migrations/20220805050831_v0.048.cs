using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0048 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("0c855d44-a09c-46d2-9b88-56af37ff0131"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("32e33f0a-77bf-450e-9606-da3a1e234a36"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("a6799ec0-0948-4c2e-bd5b-a568d611a111"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("cb6ac79c-bf90-4557-934f-6c251d1069d3"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("253c90bc-2b09-4cf4-8860-173f00692b80"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("7af6632b-ee43-4891-81af-d1a8ce94a2e7"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("a9b1d99d-8f57-46d6-a28a-d0c73b3faf60"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("f28a411e-0423-4d32-adac-7435a9390311"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("f7cedf80-f83d-40ee-8232-9a229c7e04ec"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("1bb78a7f-8cb0-4c97-ab33-08defd957c62"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("cca114f4-fd13-415b-ab9f-c7b38826047c"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("473c5d7c-2e4b-41a0-92ef-26d390a95ade"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("52c2e33d-0538-4a8a-af2c-fe48fa18a7c7"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("03cf8d52-3fd5-42e8-be92-c4f65209ec52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b9f2343-55a1-4673-9344-cbfaab734761"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7659b3b7-bd60-4082-9d9d-226637e997d2"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("2a587862-18dd-4e07-9c5b-a62ecca1b28e"));

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
                name: "PoolActivities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    WalletAddress = table.Column<string>(type: "nvarchar(42)", maxLength: 42, nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                keyValue: new Guid("493b376c-d7f6-438a-8730-0254d5a02a37"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("dbafb88b-845c-4e6c-8f35-c3e20db898f6"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("f4f1eff3-a5e5-4c59-83ca-0a4676e9617c"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("fb599b2d-d489-4377-a3df-10f02c53ee2f"));

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

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("6e758dc3-bbdb-477c-84f0-7770d994a5a4"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("9cfe6f00-0add-4f85-aa20-10f5d2ff81b6"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("4def19b6-49ff-4183-9e47-866fc9dd9c3d"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("65aea546-af92-4938-b244-81836d7477d9"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("3e6302a1-99fe-4d4b-a731-f7b449dc51c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52d09425-fb12-4945-b99c-e70b3e017096"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a118806-d143-4fc1-9201-99d1ced37122"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("42be1ccb-ae0f-4748-a591-8c73c17be5c4"));

            migrationBuilder.InsertData(
                table: "CodeHeaders",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "Description", "HeaderCd", "IsDeleted", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("03cf8d52-3fd5-42e8-be92-c4f65209ec52"), new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(1845), "SYSTEM", "CodeHeader for Pool Statuses", "PSTATUS", false, new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(1845), "SYSTEM" },
                    { new Guid("2a587862-18dd-4e07-9c5b-a62ecca1b28e"), new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(1836), "SYSTEM", "CodeHeader for User Roles", "ROLE", false, new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(1840), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreatedBy", "IsDeleted", "Order", "Question", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("253c90bc-2b09-4cf4-8860-173f00692b80"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(3141), "SYSTEM", false, 5, "How are the Funds Distributed?", new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(3142), "SYSTEM" },
                    { new Guid("7af6632b-ee43-4891-81af-d1a8ce94a2e7"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(3132), "SYSTEM", false, 1, "What is Wick's Crew?", new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(3133), "SYSTEM" },
                    { new Guid("a9b1d99d-8f57-46d6-a28a-d0c73b3faf60"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(3140), "SYSTEM", false, 4, "What are the Available Pools?", new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(3140), "SYSTEM" },
                    { new Guid("f28a411e-0423-4d32-adac-7435a9390311"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(3136), "SYSTEM", false, 2, "What are Pooling Considerations?", new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(3136), "SYSTEM" },
                    { new Guid("f7cedf80-f83d-40ee-8232-9a229c7e04ec"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(3138), "SYSTEM", false, 3, "What are the Pooling Rules?", new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(3138), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "IsDeleted", "Name", "UpdateDttm", "UpdatedBy", "WalletAddress" },
                values: new object[,]
                {
                    { new Guid("4b9f2343-55a1-4673-9344-cbfaab734761"), new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(3555), "SYSTEM", false, "SYSTEM", new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(3556), "SYSTEM", "0x8c268f32D7F129ac0D9FB1E5B490d90810dFa446" },
                    { new Guid("7659b3b7-bd60-4082-9d9d-226637e997d2"), new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(3564), "SYSTEM", false, "ADMIN-1", new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(3564), "SYSTEM", "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266" }
                });

            migrationBuilder.InsertData(
                table: "CodeDetails",
                columns: new[] { "Id", "CodeHeaderId", "CreateDttm", "CreatedBy", "Description", "DetailCd", "IsDeleted", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0c855d44-a09c-46d2-9b88-56af37ff0131"), new Guid("03cf8d52-3fd5-42e8-be92-c4f65209ec52"), new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(2589), "SYSTEM", "Pool OPEN", "PSTATUS-OPEN", false, new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(2590), "SYSTEM" },
                    { new Guid("32e33f0a-77bf-450e-9606-da3a1e234a36"), new Guid("03cf8d52-3fd5-42e8-be92-c4f65209ec52"), new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(2601), "SYSTEM", "Pool CLOSED", "PSTATUS-CLOSED", false, new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(2601), "SYSTEM" },
                    { new Guid("473c5d7c-2e4b-41a0-92ef-26d390a95ade"), new Guid("2a587862-18dd-4e07-9c5b-a62ecca1b28e"), new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(2574), "SYSTEM", "System User", "ROLE-SYSTEM", false, new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(2576), "SYSTEM" },
                    { new Guid("52c2e33d-0538-4a8a-af2c-fe48fa18a7c7"), new Guid("2a587862-18dd-4e07-9c5b-a62ecca1b28e"), new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(2580), "SYSTEM", "Admin User", "ROLE-ADMIN", false, new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(2580), "SYSTEM" },
                    { new Guid("a6799ec0-0948-4c2e-bd5b-a568d611a111"), new Guid("03cf8d52-3fd5-42e8-be92-c4f65209ec52"), new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(2598), "SYSTEM", "Pool ONGOING", "PSTATUS-ONGOING", false, new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(2599), "SYSTEM" },
                    { new Guid("cb6ac79c-bf90-4557-934f-6c251d1069d3"), new Guid("2a587862-18dd-4e07-9c5b-a62ecca1b28e"), new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(2583), "SYSTEM", "Normal User", "ROLE-NORMAL", false, new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(2584), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "IsDeleted", "RoleId", "UpdateDttm", "UpdatedBy", "UserId" },
                values: new object[] { new Guid("1bb78a7f-8cb0-4c97-ab33-08defd957c62"), new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(4750), "SYSTEM", false, new Guid("52c2e33d-0538-4a8a-af2c-fe48fa18a7c7"), new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(4750), "SYSTEM", new Guid("7659b3b7-bd60-4082-9d9d-226637e997d2") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "IsDeleted", "RoleId", "UpdateDttm", "UpdatedBy", "UserId" },
                values: new object[] { new Guid("cca114f4-fd13-415b-ab9f-c7b38826047c"), new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(4746), "SYSTEM", false, new Guid("473c5d7c-2e4b-41a0-92ef-26d390a95ade"), new DateTime(2022, 8, 5, 5, 7, 18, 715, DateTimeKind.Utc).AddTicks(4747), "SYSTEM", new Guid("4b9f2343-55a1-4673-9344-cbfaab734761") });
        }
    }
}
