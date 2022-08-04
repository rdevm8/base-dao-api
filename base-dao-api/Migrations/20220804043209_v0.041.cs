using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0041 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Faqs",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("88ae6abb-78f6-4aee-8103-6bb2ce5e7d31"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("c7d0105a-cc82-4f97-bc4c-79f0d21e483b"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("e996353d-8f34-4b5b-8f74-d6fdc8bf5f76"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("ef9be470-b772-483c-a782-ab1f371b094c"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("0dc1e163-3bdc-4c2e-8033-8cc11284901d"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("750624a4-919d-4b0e-ab32-2415bf703dc1"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("9f45a9e7-d421-4b8a-90c8-455164e13930"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("e55e8522-06a4-4a14-9d36-0c90d5496b1c"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("f26fbd08-c78e-451b-8cab-b185760f7be0"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("277e912b-b949-4f80-9656-fc1f0f15ce32"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("9b6c9a88-58d4-4e5d-93c9-da8b9e478f73"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("46aedee3-c9e6-4204-ad04-97c96a6ab07a"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("e18e094a-ee28-45f6-93de-54c99263d06d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7245961c-a057-4047-a4b1-82e40f929aa5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0d556e3-4b87-445c-9868-8cce26999e2e"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("01a147bd-9e4b-4f60-8dba-ff7d75ae7280"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Faqs");

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
        }
    }
}
