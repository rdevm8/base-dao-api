using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0045 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("02c406f9-6f6f-4f21-a177-738bbf73609e"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("86023b83-bb00-448d-83c4-7151a214f7f1"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("9f265a31-af53-4d65-8c57-9f89416684bd"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("b9f25f56-e869-4e29-bad0-0b6ce8c8315f"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("e272f001-b35e-4a9b-9d83-00886f545f91"));

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
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_UserRoles_CodeDetails_RoleId",
                        column: x => x.RoleId,
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

            migrationBuilder.InsertData(
                table: "CodeHeaders",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "Description", "HeaderCd", "IsDeleted", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2c60dd34-6c88-4727-a0f6-f85c8fc464a2"), new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(1965), "SYSTEM", "CodeHeader for Pool Statuses", "PSTATUS", false, new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(1966), "SYSTEM" },
                    { new Guid("3f4818e6-0882-4789-83f5-178d4f2c25f6"), new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(1958), "SYSTEM", "CodeHeader for User Roles", "ROLE", false, new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(1961), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreatedBy", "IsDeleted", "Order", "Question", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1a461d43-5c88-4f09-9395-61100b073add"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3043), "SYSTEM", false, 1, "What is Wick's Crew?", new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3044), "SYSTEM" },
                    { new Guid("43715d08-0bd8-4472-9af2-7fb4dc0a9023"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3052), "SYSTEM", false, 3, "What are the Pooling Rules?", new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3052), "SYSTEM" },
                    { new Guid("88425971-4192-400e-adda-f56b456ea351"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3053), "SYSTEM", false, 4, "What are the Available Pools?", new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3054), "SYSTEM" },
                    { new Guid("95cb891d-7e62-4d28-95b0-f265cb0dd9dc"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3055), "SYSTEM", false, 5, "How are the Funds Distributed?", new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3055), "SYSTEM" },
                    { new Guid("f2c99f6f-00d0-44f9-80c6-539d5ea36838"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3046), "SYSTEM", false, 2, "What are Pooling Considerations?", new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(3047), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "CodeDetails",
                columns: new[] { "Id", "CodeHeaderId", "CreateDttm", "CreatedBy", "Description", "DetailCd", "IsDeleted", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2ebad7da-393f-4b8c-866c-943e2da5f4eb"), new Guid("3f4818e6-0882-4789-83f5-178d4f2c25f6"), new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2523), "SYSTEM", "Admin User", "ROLE-SYSTEM", false, new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2524), "SYSTEM" },
                    { new Guid("3d19c08e-b292-4130-b6c8-1f4262fb5de1"), new Guid("3f4818e6-0882-4789-83f5-178d4f2c25f6"), new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2527), "SYSTEM", "Admin User", "ROLE-ADMIN", false, new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2527), "SYSTEM" },
                    { new Guid("8001e627-ccc2-4728-bff3-d7a747f731fc"), new Guid("2c60dd34-6c88-4727-a0f6-f85c8fc464a2"), new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2538), "SYSTEM", "Pool CLOSED", "PSTATUS-CLOSED", false, new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2538), "SYSTEM" },
                    { new Guid("862d05de-ea2f-48a4-a502-bcefd4c3c513"), new Guid("2c60dd34-6c88-4727-a0f6-f85c8fc464a2"), new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2532), "SYSTEM", "Pool OPEN", "PSTATUS-OPEN", false, new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2532), "SYSTEM" },
                    { new Guid("9165d638-f82a-422f-b0ef-0e190c2d424a"), new Guid("3f4818e6-0882-4789-83f5-178d4f2c25f6"), new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2529), "SYSTEM", "Normal User", "ROLE-NORMAL", false, new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2529), "SYSTEM" },
                    { new Guid("f6dcddd3-2999-4813-98e8-5d69265f08eb"), new Guid("2c60dd34-6c88-4727-a0f6-f85c8fc464a2"), new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2535), "SYSTEM", "Pool ONGOING", "PSTATUS-ONGOING", false, new DateTime(2022, 8, 5, 5, 0, 24, 683, DateTimeKind.Utc).AddTicks(2535), "SYSTEM" }
                });

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
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "CodeDetails");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CodeHeaders");

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("1a461d43-5c88-4f09-9395-61100b073add"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("43715d08-0bd8-4472-9af2-7fb4dc0a9023"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("88425971-4192-400e-adda-f56b456ea351"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("95cb891d-7e62-4d28-95b0-f265cb0dd9dc"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("f2c99f6f-00d0-44f9-80c6-539d5ea36838"));

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreatedBy", "IsDeleted", "Order", "Question", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("02c406f9-6f6f-4f21-a177-738bbf73609e"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 4, 58, 45, 660, DateTimeKind.Utc).AddTicks(5637), "SYSTEM", false, 5, "How are the Funds Distributed?", new DateTime(2022, 8, 5, 4, 58, 45, 660, DateTimeKind.Utc).AddTicks(5638), "SYSTEM" },
                    { new Guid("86023b83-bb00-448d-83c4-7151a214f7f1"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 4, 58, 45, 660, DateTimeKind.Utc).AddTicks(5627), "SYSTEM", false, 1, "What is Wick's Crew?", new DateTime(2022, 8, 5, 4, 58, 45, 660, DateTimeKind.Utc).AddTicks(5628), "SYSTEM" },
                    { new Guid("9f265a31-af53-4d65-8c57-9f89416684bd"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 4, 58, 45, 660, DateTimeKind.Utc).AddTicks(5636), "SYSTEM", false, 4, "What are the Available Pools?", new DateTime(2022, 8, 5, 4, 58, 45, 660, DateTimeKind.Utc).AddTicks(5636), "SYSTEM" },
                    { new Guid("b9f25f56-e869-4e29-bad0-0b6ce8c8315f"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 4, 58, 45, 660, DateTimeKind.Utc).AddTicks(5632), "SYSTEM", false, 2, "What are Pooling Considerations?", new DateTime(2022, 8, 5, 4, 58, 45, 660, DateTimeKind.Utc).AddTicks(5633), "SYSTEM" },
                    { new Guid("e272f001-b35e-4a9b-9d83-00886f545f91"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 4, 58, 45, 660, DateTimeKind.Utc).AddTicks(5634), "SYSTEM", false, 3, "What are the Pooling Rules?", new DateTime(2022, 8, 5, 4, 58, 45, 660, DateTimeKind.Utc).AddTicks(5634), "SYSTEM" }
                });
        }
    }
}
