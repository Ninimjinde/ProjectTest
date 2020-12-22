using Microsoft.EntityFrameworkCore.Migrations;

namespace ALE.TimeRegistration.Infrastructure.Migrations
{
    public partial class AddAdminRoleNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00000000-0000-0000-0000-000000000001", "6617ed95-a00f-484d-905c-19522d37aeac", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "LastName", "Name", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c8554266-b401-4519-9aeb-a9283053fc58", true, null, null, "ABOYNAMEDSUE@JCASH.COM", "ABOYNAMEDSUE@JCASH.COM", null, "AQAAAAEAACcQAAAAELDp6qhlaOUyZiTq++0WhNe/FynURZTVs6Qhejl/Jd0MShmlRkmE1SrCnq8JfKChNA==", "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", "aboynamedsue@JCash.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a7eaa428-d59b-49fc-bdeb-f2b37b4048c6", "08997253-9e6d-4130-9e02-fabefe47872b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0daedb8a-803b-47d6-a0d6-c6dddd118527", "c7b2dab7-eeec-428d-a052-6e1209931a45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "60a067cc-7cf5-425a-9df5-c504f1d9f6de", "7b535b76-f807-400c-8254-b0c6d6a786bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46351018-442d-4bee-8abf-fd9df8aa0d6a", "3b1057cc-7dc6-4df9-9ce2-e9090c8b412d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3b5eb76a-8a22-401d-a488-81ea902d0fd2", "dbecbb53-102e-4003-925f-a8f32d025c47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2b375dbb-11c3-47df-bea2-3472bb5332e2", "d6049ed7-a29e-42a3-8825-0f6e7e38b65c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ce525691-fb58-49a0-8f12-a131ae80d046", "c5728fc9-ae61-472c-9e5a-72e411bbe6c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "64fbc69b-0703-4ded-9f87-7d2cb727d9f9", "d25b2f58-cc29-4d48-bea1-fbbf77d9b6de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d70a35e-3487-4f8e-8b93-b772a3657fea", "3e872442-7bda-4d19-82e3-78980e27cc6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9c742f9-4c9b-46be-a656-299927616261", "46ae68dd-d884-4447-bc14-73678e44ecfe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "06fa017b-eddb-41b9-ac41-22adbef7f2df", "82b15a48-d56c-42e6-add3-356a34dcf916" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "040f32ed-a766-4644-a256-6f76b296cb85", "e6f918b1-c12d-4bc1-92b5-90ae6df0d7b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e866b04-1380-423e-ba0b-3b0c5b275d7d", "2fbe2356-91aa-4832-b9af-45a9e44fb221" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d71f1009-9636-4ead-a51d-421c611f550e", "a15d7c31-742b-4c22-842a-45ddf5062a0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cbd0df08-eb4b-4627-ad6d-45068fb8c4c2", "b60ca086-73c2-41a5-8dd3-f826fd9eaddb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "979d251d-b82d-4b2a-816a-3bf322e1895d", "014ef737-e148-4fb3-bb46-d874e5f477f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12e710eb-7f22-485e-b014-5e5ba4445afe", "f055c671-2f6e-424d-832e-0734517949cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2e1681ee-84bf-4d6d-8d86-77db8990497d", "b6f62a05-c9a0-4432-9b95-314426dcc119" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f9a332d0-6acf-4a17-8bd5-a12346ec4bd5", "fe08bc31-36cc-4b13-a8fa-f02e583cf196" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e28c898b-8b5c-4254-8d84-2584672e1fa8", "f2b14b5a-4e93-45d0-a4ca-74688b01d6fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f94aa69-69c3-45b2-8635-e952e0a559cb", "0b9c410a-8a3a-4320-9538-a72733e06d6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd5a958c-7269-4d78-9960-8d82d3288cd5", "0a6bf07d-a5be-4f12-b732-77983a2cab7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000024",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a8d72bfa-12e2-4e7a-86d4-c29f198992b3", "fe4ccde3-da2e-4285-a2cd-ddfdbb985d37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000025",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "da84a928-f085-4b43-9ab5-4f9bfc9295de", "e9d3d5e2-0e5d-40b2-b5e9-db76e999e2a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000026",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a872a1cf-c31e-4b08-aefd-fa37f083cc5e", "e37d4e05-037c-4f94-b881-0d6e38fffd76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000027",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "19ad1cc0-5321-43bc-a594-71267a89069b", "45179a9f-52ea-4f37-b2cd-3ab9c2ecfc46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000028",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9ecc5683-1619-4ddc-a05b-569f0ce0d26d", "3286f182-fd6a-4f30-a6f5-bd158ec87c07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000029",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "493d7269-00c4-47ab-a812-4a0e7ccf5efa", "a61ba6b0-570f-432c-b369-45565bba4f7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f7a599f-0b7e-4c9a-9a30-4614972ae74f", "aaec2e5d-f0df-4828-8ffd-b40d60b737c0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "LastName", "Name", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2dd6ebce-85f4-4e6d-ab7c-b607464ab8d6", false, "Cash", "Johnny", null, null, "TimeReg2020", null, "fafdf24c-b21b-479a-940d-e09cf05fe805", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5bf6c412-762a-4336-83ff-fbf7fdc1de2d", "df0028a6-2d7f-47a0-b9e9-4dd6efb6e137" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ce331d21-afef-4b8c-8956-0b9d8981cd49", "3e7ad697-bb4f-4efe-aefe-8d161769223b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5eac1c7e-ed0c-443c-9c32-8a48c33efed8", "820962cf-8abb-444c-bcce-864735031226" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "daf80bc9-4319-4963-b876-74a68e0a7b97", "17cadf86-8c0a-415e-ab68-6d82a1dcea07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b8e3aa95-7c17-4b10-a8d6-4bc8fe4a2fce", "b9cbb0a4-28bd-4f86-97cb-92c218068fed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2420bb64-cb85-4184-824f-6769ed9b4abf", "66bc3ef8-3277-499f-bbb5-fd521df8fe30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3b74d09d-d958-486a-9437-4ea2b75cd1ed", "45d375d0-f518-43a3-a477-c8da3733d31e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ceffde7e-e675-4a1b-aa01-cd9bcbb1afca", "3c12b780-083c-4f80-a293-36254605b3a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08e09ea2-c0e9-4088-87a8-76495bcf9990", "097e323f-c6fa-43a9-84bb-12c9859a7549" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000011",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb9bfc01-ec62-415d-85eb-0afed9915d3f", "0af6a186-ad94-4889-b3cb-3ceb9f112a1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000012",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed336b22-16d0-4eac-8dd3-2f35f887266b", "534b5ac3-61cd-4679-bb2e-98eefc1b9150" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000013",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eef81be2-9461-49a3-bccd-aed01c41e851", "50502a96-e04d-44d9-bcd6-dd0395bc736b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000014",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b2d6ec7b-61f5-4787-982e-bc4c4b10dc7a", "867cfc84-7d85-4612-9386-cde3ba34ff87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6a6cd57c-67e0-4395-9383-9184f46f4e4a", "54e44d45-64e8-429b-9e53-e41f84cb7e2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000016",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1824f4f2-3824-426d-8701-4218e80a6235", "601affa1-7ff7-477e-88ef-e0fdf2e228af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000017",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b71f5013-7aa8-43ac-a7b8-7c0351683e9d", "30be302e-ed49-44cc-8417-5da0a4def116" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000018",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cdca91cc-11cc-4e88-b1a0-edfedf0e96cd", "82e51ffc-d9be-459e-a610-7f725fccc7df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000019",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32fc5605-bcaf-41b7-8eae-a472350e41b9", "03b86e30-c39c-47fb-89ff-d09089e61d46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000020",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9988662f-1e8e-4cec-a105-87343418c730", "10473684-b153-4036-8a1b-8d5d345cd2d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000021",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e4b421db-8083-496b-bd13-8eca90b49f87", "659ba673-3ccf-41c9-88b6-5f7d71626714" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000022",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2b18ebb0-51c8-419f-b549-aca85978eed9", "a13339d9-ec37-41dc-83e1-69c576639152" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000023",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b14cc51f-cc94-45c9-a3a7-fbfc6afc83cd", "668cb0a6-c819-4aab-a95a-ba007d0a7558" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000024",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "483c5b7d-3bc0-4753-83be-fcb5375e93bc", "ac794649-de65-4e7d-a0ad-d38f5b362b13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000025",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24be20e6-6ac8-4607-bea4-4700b3eebc36", "8accb61f-c739-4125-8a54-16456d44219c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000026",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f97b14a5-6d52-4bc3-a32e-74836b9072fa", "129eeebc-663a-4011-b876-1074d6b73f59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000027",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d4e1d3ec-306b-4762-a51f-bedec9341e51", "63ce733a-18c4-48e4-9f2f-4b3bd0a90ae1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000028",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "acfd418f-095e-4aa0-ac4a-e18be1a25c4d", "e4bf8e6c-74e5-4f7f-a5b9-7030dd4af8d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000029",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "95ca6aba-a19c-499c-8a01-00a4600a51c2", "4caf87ab-bda4-414b-9ecf-c63861401351" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000030",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dbf926d4-17e3-4b46-8bd1-4f98fe0cf898", "a5991d11-1d4a-4b7e-a125-c3b75e02fda8" });
        }
    }
}
