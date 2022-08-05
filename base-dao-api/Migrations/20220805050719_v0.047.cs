using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace base_dao_api.Migrations
{
    public partial class v0047 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
