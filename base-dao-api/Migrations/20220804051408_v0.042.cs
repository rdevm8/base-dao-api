using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0042 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "CodeHeaders",
                columns: new[] { "Id", "CreateDttm", "CreateUserId", "Description", "HeaderCd", "IsActive", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("51aa911f-5328-4c83-9865-14874520b17c"), new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3132), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), "CodeHeader for User Roles", "ROLE", true, new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3141), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81") },
                    { new Guid("f437f9c0-f79b-45c3-af13-90a58f9af3c2"), new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3144), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), "CodeHeader for Pool Statuses", "PSTATUS", true, new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3145), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81") }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreateUserId", "IsActive", "Order", "Question", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("14297d94-c7d2-4c20-9acb-30a7ea2bde98"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3479), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), true, 2, "What are Pooling Considerations?", new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3479), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81") },
                    { new Guid("2d0e79d7-76bf-4d3c-9671-f8d2159eb1df"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3482), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), true, 4, "What are the Available Pools?", new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3483), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81") },
                    { new Guid("461d9bfd-4d91-4451-942c-c413e49761df"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3484), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), true, 5, "How are the Funds Distributed?", new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3485), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81") },
                    { new Guid("54c9bf8e-37a5-436f-a153-e4e1923fe583"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3481), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), true, 3, "What are the Pooling Rules?", new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3481), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81") },
                    { new Guid("a667261b-ecfa-49f2-beed-fb5302900d33"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3474), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), true, 1, "What is Wick's Crew?", new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3475), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDttm", "CreateUserId", "IsActive", "Name", "UpdateDttm", "UpdateUserId", "WalletAddress" },
                values: new object[,]
                {
                    { new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(4251), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), true, "SYSTEM", new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(4252), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), "" },
                    { new Guid("8cb4de77-2dec-431d-bb36-bf4c03f907bc"), new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(4242), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), true, "", new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(4244), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266" }
                });

            migrationBuilder.InsertData(
                table: "CodeDetails",
                columns: new[] { "Id", "CodeHeaderId", "CreateDttm", "CreateUserId", "Description", "DetailCd", "IsActive", "UpdateDttm", "UpdateUserId" },
                values: new object[,]
                {
                    { new Guid("16dff03f-6567-4433-ba95-d9915840cbbf"), new Guid("f437f9c0-f79b-45c3-af13-90a58f9af3c2"), new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3302), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), "Pool OPEN", "PSTATUS-OPEN", true, new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3302), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81") },
                    { new Guid("7ddea8cd-46e2-4e1b-bec0-a75a2bb2f1b9"), new Guid("51aa911f-5328-4c83-9865-14874520b17c"), new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3294), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), "Admin User", "ROLE-ADMIN", true, new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3295), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81") },
                    { new Guid("8f673f2a-3e5a-4d83-8f23-15bf30c356c1"), new Guid("f437f9c0-f79b-45c3-af13-90a58f9af3c2"), new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3309), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), "Pool CLOSED", "PSTATUS-CLOSED", true, new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3310), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81") },
                    { new Guid("9bf8f484-326f-4c3f-8fce-6af26c04fdbd"), new Guid("51aa911f-5328-4c83-9865-14874520b17c"), new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3299), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), "Normal User", "ROLE-NORMAL", true, new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3300), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81") },
                    { new Guid("dbfba4e3-e09c-4a8a-bc22-8d01317b7bc9"), new Guid("f437f9c0-f79b-45c3-af13-90a58f9af3c2"), new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3304), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), "Pool ONGOING", "PSTATUS-ONGOING", true, new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(3304), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CodeDetailId", "CreateDttm", "CreateUserId", "IsActive", "UpdateDttm", "UpdateUserId", "UserId" },
                values: new object[] { new Guid("7097df56-1004-4471-95a1-d1366a564179"), new Guid("7ddea8cd-46e2-4e1b-bec0-a75a2bb2f1b9"), new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(4359), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), true, new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(4360), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), new Guid("8cb4de77-2dec-431d-bb36-bf4c03f907bc") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CodeDetailId", "CreateDttm", "CreateUserId", "IsActive", "UpdateDttm", "UpdateUserId", "UserId" },
                values: new object[] { new Guid("c80efd0a-2adc-42bc-b8f9-8f4febde4e5e"), new Guid("7ddea8cd-46e2-4e1b-bec0-a75a2bb2f1b9"), new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(4369), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), true, new DateTime(2022, 8, 4, 13, 14, 7, 817, DateTimeKind.Local).AddTicks(4369), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"), new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("16dff03f-6567-4433-ba95-d9915840cbbf"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("8f673f2a-3e5a-4d83-8f23-15bf30c356c1"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("9bf8f484-326f-4c3f-8fce-6af26c04fdbd"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("dbfba4e3-e09c-4a8a-bc22-8d01317b7bc9"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("14297d94-c7d2-4c20-9acb-30a7ea2bde98"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("2d0e79d7-76bf-4d3c-9671-f8d2159eb1df"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("461d9bfd-4d91-4451-942c-c413e49761df"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("54c9bf8e-37a5-436f-a153-e4e1923fe583"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("a667261b-ecfa-49f2-beed-fb5302900d33"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("7097df56-1004-4471-95a1-d1366a564179"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("c80efd0a-2adc-42bc-b8f9-8f4febde4e5e"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("7ddea8cd-46e2-4e1b-bec0-a75a2bb2f1b9"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("f437f9c0-f79b-45c3-af13-90a58f9af3c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("063dafae-d932-4204-9a9a-e5ca079c2f81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8cb4de77-2dec-431d-bb36-bf4c03f907bc"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("51aa911f-5328-4c83-9865-14874520b17c"));

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
    }
}
