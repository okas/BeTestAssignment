using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeTestAssignment.Data.Migrations
{
    public partial class AddedCompaniesAndSeededUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CountryCode = table.Column<string>(nullable: true),
                    RegistryCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ab07a835-1db0-4610-8661-380134b7d361", 0, "54088a67-6b16-49fd-ae64-7efaca0792fb", null, true, false, null, null, "UBERGEEB@AOL.COM", "AQAAAAEAACcQAAAAEC2Yd/0u+AZIFASX43OfBgvcqGFTLMlBDZ4KwJiZykC+iX80CS6cprUdQ5SacvU2JA==", null, false, "21c4c2c6-57bf-4f06-b89a-ced39991a657", false, "ubergeeb@aol.com" },
                    { "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd", 0, "1a26386f-cb30-4a30-82c6-d8ad1415e1ff", null, true, false, null, null, "AMICHALO@LIVE.COM", "AQAAAAEAACcQAAAAEC3pDTiVGYOurwt2TrdLuUnHE+Bj/Qwuuvmg/xiLP2IMDaChnNNkhHEF8RPS0qRkGA==", null, false, "ecb15de4-8aa4-44be-af24-efc9fb833896", false, "amichalo@live.com" },
                    { "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec", 0, "63194488-88fe-4477-be42-958ea66bab16", null, true, false, null, null, "MASTINFO@SBCGLOBAL.NET", "AQAAAAEAACcQAAAAEItvjVjYp+aknsT/IeCU8H0/1ofeqnRPcVXb4d+KsUoogNhaxVBY8mk6dlvj6By5LQ==", null, false, "80986410-e9a2-41bf-be27-4cbee191e76b", false, "mastinfo@sbcglobal.net" },
                    { "3dc0badb-71dd-4ce7-b3e7-052349b2996f", 0, "115a3b18-bb6b-4f48-9d40-0c3eb6d53bb6", null, true, false, null, null, "SBMRJBR@OPTONLINE.NET", "AQAAAAEAACcQAAAAEI5mX9cH849GIKT/sUMaBOiZOmcjn8Y41vEl/NeWMdtaq4edi/oOg5PdCV6i+bsyQQ==", null, false, "fb60eccc-fe93-4c94-891a-baf80df5e715", false, "sbmrjbr@optonline.net" },
                    { "b5ab401b-dfc6-4553-b275-5519253cf9da", 0, "e3840ed6-fa2e-4bc3-a429-24587cb4b547", null, true, false, null, null, "SATISHR@HOTMAIL.COM", "AQAAAAEAACcQAAAAENYUmQ3mjaFyRJRtdXiHHKlZPPdXTYt6LTp1yq3H7e6n0007m4d6TgBQDSyj2i5ppg==", null, false, "1b906418-b3d1-4b35-9c5c-6ac6e0d6eb47", false, "satishr@hotmail.com" },
                    { "522608c8-bac8-43d6-bdce-cfdf77dfad43", 0, "aff2795f-c977-4773-966e-24c3de12483b", null, true, false, null, null, "WEAZELMAN@ICLOUD.COM", "AQAAAAEAACcQAAAAENbwd2YTNvHjYgiSfKNol1AxDgl0/soZXVhXt7PPsSQif5yfTbSFLrJwJ6R0TsBOoA==", null, false, "db82c9a9-1a03-43c9-a543-92bade695400", false, "weazelman@icloud.com" },
                    { "8f3b1759-c4f9-49bd-8fa5-aac53f731ae8", 0, "d77f9822-0a9a-4c74-a621-7128e08036b5", null, true, false, null, null, "WMSZELIGA@YAHOO.CA", "AQAAAAEAACcQAAAAEF7GzDn9hcO3wDh58M+WyCkdrtSYh2ug8aIJhVW/4Ye7AHbYF4LvYOp//Epv4x1R2g==", null, false, "c19b81c7-e16f-414d-a26b-f37bd8054f9e", false, "wmszeliga@yahoo.ca" },
                    { "2652e409-1d33-4933-baa2-951954e7cf6b", 0, "d70a5330-e718-4faf-977e-9518fd29fdac", null, true, false, null, null, "CDEROOVE@ATT.NET", "AQAAAAEAACcQAAAAEKz962MuRQASEWrA5vigbARX4BdDTUtquHMlBWYTc+CyGCVugOA9UTZz89+3cuzOfw==", null, false, "94aa28ff-4769-4201-a745-ad408db43950", false, "cderoove@att.net" },
                    { "23eaa10a-4fa2-4bfb-ba6a-455f3d2842c2", 0, "f2c118f0-3e38-4044-98a1-b33d070bd31f", null, true, false, null, null, "JAARNIAL@AOL.COM", "AQAAAAEAACcQAAAAELVAYsxw20Ra5V4MDpvaK/us/fmTLEQ9fhZTHkkwUVZhJY4OkYvgchQwcLcYhbgfHg==", null, false, "c43ce542-9af9-4762-9b31-6e528beae9ec", false, "jaarnial@aol.com" },
                    { "8c6a38f1-80b4-4625-affc-061837bee170", 0, "988acb66-6911-42c8-88fc-3ba4fa399ba9", null, true, false, null, null, "SARAHS@OUTLOOK.COM", "AQAAAAEAACcQAAAAED8A5Ia2Rh+4nSI1gxItuF+lFXb5i6degAFsMZ+3QTvcMiJUq3+GVpcAZHrjnwujcA==", null, false, "473ca7ef-f39c-4555-a1a4-4e2f4651078c", false, "sarahs@outlook.com" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CountryCode", "Name", "RegistryCode" },
                values: new object[,]
                {
                    { new Guid("6b55dfab-c72e-4a1b-a229-fd11c406e146"), "Nurme 99, Varudi, Lääne-Virumaa", "est", "Company One", "123451" },
                    { new Guid("68a720d6-049f-4f4b-957e-04bfb4380d64"), "Kase 93, Paatsalu, Pärnumaa", "est", "Company Two", "123452" },
                    { new Guid("8e8004bc-25c9-4313-b9d9-60358ad2c995"), "Kraavi 4, Viljandi, Viljandimaa", "est", "Company Three", "123453" },
                    { new Guid("7fa7d08e-d5d1-4c34-bf7d-83c3f55a749b"), "Tamme 78, Tsiamäe, Võrumaa", "est", "Company Four", "123454" },
                    { new Guid("4f7750ac-02b9-43eb-af0d-1b8ae1601867"), "Jõe 41, Mõisamäe, Võrumaa", "est", "Company Five", "123455" },
                    { new Guid("88fb0b1b-ad3a-4991-98f6-4673263bca31"), "Õie 96, Neeruti, Lääne-Virumaa", "est", "Company Six", "123456" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23eaa10a-4fa2-4bfb-ba6a-455f3d2842c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2652e409-1d33-4933-baa2-951954e7cf6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dc0badb-71dd-4ce7-b3e7-052349b2996f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "522608c8-bac8-43d6-bdce-cfdf77dfad43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c6a38f1-80b4-4625-affc-061837bee170");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f3b1759-c4f9-49bd-8fa5-aac53f731ae8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5ab401b-dfc6-4553-b275-5519253cf9da");
        }
    }
}
