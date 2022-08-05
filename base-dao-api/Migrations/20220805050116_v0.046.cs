using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0046 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("2ebad7da-393f-4b8c-866c-943e2da5f4eb"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("3d19c08e-b292-4130-b6c8-1f4262fb5de1"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("8001e627-ccc2-4728-bff3-d7a747f731fc"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("862d05de-ea2f-48a4-a502-bcefd4c3c513"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("9165d638-f82a-422f-b0ef-0e190c2d424a"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("f6dcddd3-2999-4813-98e8-5d69265f08eb"));

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

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("2c60dd34-6c88-4727-a0f6-f85c8fc464a2"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("3f4818e6-0882-4789-83f5-178d4f2c25f6"));

            migrationBuilder.InsertData(
                table: "CodeHeaders",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "Description", "HeaderCd", "IsDeleted", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("5aeaa24b-8168-49c7-9305-a468f0c37a49"), new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(5917), "SYSTEM", "CodeHeader for User Roles", "ROLE", false, new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(5918), "SYSTEM" },
                    { new Guid("bc9cc106-8cdc-45ae-af8b-9964a6a9da6e"), new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(5923), "SYSTEM", "CodeHeader for Pool Statuses", "PSTATUS", false, new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(5923), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "Id", "Answer", "CreateDttm", "CreatedBy", "IsDeleted", "Order", "Question", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1c1c215e-7df5-4eaa-bd9c-f0ccc1d5908e"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(7064), "SYSTEM", false, 2, "What are Pooling Considerations?", new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(7064), "SYSTEM" },
                    { new Guid("207b1456-cf51-4d45-9846-321b8179f9da"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(7065), "SYSTEM", false, 3, "What are the Pooling Rules?", new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(7066), "SYSTEM" },
                    { new Guid("2b7f9a5c-a197-45ee-aca6-8aabfcea2216"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(7060), "SYSTEM", false, 1, "What is Wick's Crew?", new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(7061), "SYSTEM" },
                    { new Guid("51dbae03-805d-4242-8ef1-02efb10a5168"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(7072), "SYSTEM", false, 5, "How are the Funds Distributed?", new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(7073), "SYSTEM" },
                    { new Guid("f731c6a6-110b-4cc3-afee-43eaff457910"), "At vero eos et accusamus et iusto", new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(7067), "SYSTEM", false, 4, "What are the Available Pools?", new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(7067), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "IsDeleted", "Name", "UpdateDttm", "UpdatedBy", "WalletAddress" },
                values: new object[,]
                {
                    { new Guid("9683e940-7b90-4042-9644-12366e58f384"), new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(7470), "SYSTEM", false, "SYSTEM", new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(7471), "SYSTEM", "0x8c268f32D7F129ac0D9FB1E5B490d90810dFa446" },
                    { new Guid("abd61b3c-8f38-4b39-bdc3-4b536fd8aab2"), new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(7475), "SYSTEM", false, "ADMIN-1", new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(7475), "SYSTEM", "0xf39Fd6e51aad88F6F4ce6aB8827279cffFb92266" }
                });

            migrationBuilder.InsertData(
                table: "CodeDetails",
                columns: new[] { "Id", "CodeHeaderId", "CreateDttm", "CreatedBy", "Description", "DetailCd", "IsDeleted", "UpdateDttm", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("7d76fcbc-0718-4e98-b6fb-7e8623bb31c3"), new Guid("bc9cc106-8cdc-45ae-af8b-9964a6a9da6e"), new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(6555), "SYSTEM", "Pool ONGOING", "PSTATUS-ONGOING", false, new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(6555), "SYSTEM" },
                    { new Guid("8be5b810-defc-4603-80a3-18498522c2af"), new Guid("bc9cc106-8cdc-45ae-af8b-9964a6a9da6e"), new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(6557), "SYSTEM", "Pool CLOSED", "PSTATUS-CLOSED", false, new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(6557), "SYSTEM" },
                    { new Guid("a52cb15a-0bf0-44b9-9750-6b90ade160d3"), new Guid("5aeaa24b-8168-49c7-9305-a468f0c37a49"), new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(6550), "SYSTEM", "Normal User", "ROLE-NORMAL", false, new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(6551), "SYSTEM" },
                    { new Guid("b6a01cff-8b18-41a6-906b-817126763b73"), new Guid("5aeaa24b-8168-49c7-9305-a468f0c37a49"), new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(6540), "SYSTEM", "Admin User", "ROLE-SYSTEM", false, new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(6540), "SYSTEM" },
                    { new Guid("c48d573f-a79f-46a7-8ca2-06cd1db0b8ec"), new Guid("5aeaa24b-8168-49c7-9305-a468f0c37a49"), new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(6543), "SYSTEM", "Admin User", "ROLE-ADMIN", false, new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(6543), "SYSTEM" },
                    { new Guid("fcb4d963-9746-4d98-9203-e6ee6afddc72"), new Guid("bc9cc106-8cdc-45ae-af8b-9964a6a9da6e"), new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(6553), "SYSTEM", "Pool OPEN", "PSTATUS-OPEN", false, new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(6553), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "IsDeleted", "RoleId", "UpdateDttm", "UpdatedBy", "UserId" },
                values: new object[] { new Guid("369988ce-c583-4bc8-801f-38e60259da0e"), new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(8525), "SYSTEM", false, new Guid("b6a01cff-8b18-41a6-906b-817126763b73"), new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(8526), "SYSTEM", new Guid("9683e940-7b90-4042-9644-12366e58f384") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreateDttm", "CreatedBy", "IsDeleted", "RoleId", "UpdateDttm", "UpdatedBy", "UserId" },
                values: new object[] { new Guid("6d43294f-f9d2-440d-b7bd-0957944bdefa"), new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(8528), "SYSTEM", false, new Guid("c48d573f-a79f-46a7-8ca2-06cd1db0b8ec"), new DateTime(2022, 8, 5, 5, 1, 16, 207, DateTimeKind.Utc).AddTicks(8528), "SYSTEM", new Guid("abd61b3c-8f38-4b39-bdc3-4b536fd8aab2") });

            migrationBuilder.CreateIndex(
                name: "IX_Users_WalletAddress",
                table: "Users",
                column: "WalletAddress",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_Users_WalletAddress",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("7d76fcbc-0718-4e98-b6fb-7e8623bb31c3"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("8be5b810-defc-4603-80a3-18498522c2af"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("a52cb15a-0bf0-44b9-9750-6b90ade160d3"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("fcb4d963-9746-4d98-9203-e6ee6afddc72"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("1c1c215e-7df5-4eaa-bd9c-f0ccc1d5908e"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("207b1456-cf51-4d45-9846-321b8179f9da"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("2b7f9a5c-a197-45ee-aca6-8aabfcea2216"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("51dbae03-805d-4242-8ef1-02efb10a5168"));

            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "Id",
                keyValue: new Guid("f731c6a6-110b-4cc3-afee-43eaff457910"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("369988ce-c583-4bc8-801f-38e60259da0e"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("6d43294f-f9d2-440d-b7bd-0957944bdefa"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("b6a01cff-8b18-41a6-906b-817126763b73"));

            migrationBuilder.DeleteData(
                table: "CodeDetails",
                keyColumn: "Id",
                keyValue: new Guid("c48d573f-a79f-46a7-8ca2-06cd1db0b8ec"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("bc9cc106-8cdc-45ae-af8b-9964a6a9da6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9683e940-7b90-4042-9644-12366e58f384"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abd61b3c-8f38-4b39-bdc3-4b536fd8aab2"));

            migrationBuilder.DeleteData(
                table: "CodeHeaders",
                keyColumn: "Id",
                keyValue: new Guid("5aeaa24b-8168-49c7-9305-a468f0c37a49"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
