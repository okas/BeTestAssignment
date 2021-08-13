using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeTestAssignment.Data.Migrations
{
    public partial class AddedContractModelWithConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Occupation = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    CompanyId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23eaa10a-4fa2-4bfb-ba6a-455f3d2842c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46862783-612e-4828-9de9-9920c10bdf7c", "AQAAAAEAACcQAAAAEA8NRF04S7CWProkRC2d6psH/PdCPobu3JIr90MIu7i6L14YXj/4mbYgtvZUyY/GrQ==", "c9beb133-b7f4-43b0-923a-04eabf16da69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2652e409-1d33-4933-baa2-951954e7cf6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "beb1eae0-f1ba-47eb-8c2b-e7c0728ed7c4", "AQAAAAEAACcQAAAAEA4yk/wWQrG4nRlLzRBLj+rII/V4RBN+ijhFczItdW3BaT3Lszv1O1eo1A6outHiXw==", "e3ebee13-66b8-43da-b1cd-6a75c0a7699c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dc0badb-71dd-4ce7-b3e7-052349b2996f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db75ac19-7e91-4203-ad70-23710a472e78", "AQAAAAEAACcQAAAAEF7Uup3BrFrKXnYl1rAni+fPoYecqEhxdjCyFBxgEmFTILkkl5asFfuIutQ+LUwYYA==", "252af2f4-c8b6-468d-9690-efbcb6952dfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "522608c8-bac8-43d6-bdce-cfdf77dfad43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ffb3edf-8f54-471e-9d34-c9cface7d2db", "AQAAAAEAACcQAAAAEBR/WNMwDYn3iXZZYUGWY4YRR8unnqwbxHJ6t9HxW3zTBlWDr+g0aKn2YnKPT7ebhg==", "f4e06061-75f9-4548-b4f3-efaa96d5d4f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca8a098d-f666-4245-baf4-2e90e9b90316", "AQAAAAEAACcQAAAAENmvkiYv8lqS9PmS4nnMLUH0E5J7DeQ5Bj8zomeF93tGjWD+ESOyR96iRWEsbC6jww==", "814c2db1-dc4f-4ceb-9411-86e4fc0ac2bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fe08c2b-2e2a-4198-b617-5609e2609fa6", "AQAAAAEAACcQAAAAENlI9FWnekGCyXg6c2GB21fjISg/NuuwT86nncuqsv5yf+2hhXB1MQtaLo56v8cp2w==", "0b5c98c8-89ba-4fad-a05b-6761e7a3441e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c6a38f1-80b4-4625-affc-061837bee170",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46c00ff0-d45d-4232-8121-11c519c6d3ee", "AQAAAAEAACcQAAAAEHsrznoE9BWGzPHaiQtF/m6ZB9Wf8v3tM6gEb+WyJdxaJHrYkBGnaf1et/ty10S6Xg==", "96e373d9-a75a-42d0-a04b-6eb4e1e44402" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f3b1759-c4f9-49bd-8fa5-aac53f731ae8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56bf621d-7776-4cf7-9e67-6a3ba8885d48", "AQAAAAEAACcQAAAAEMBn4KG0v3e2LV6ypCYNEZgD1g4de2hbhfMqnOdzQmyDXzQtexqLD3YKOfCQfAtv7Q==", "c8e2aaa4-d440-4f1f-b77f-a6414271a72b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e3ccf4d-8700-4899-8cf5-751fe80d1a8f", "AQAAAAEAACcQAAAAEKiMkNrqNRDXLW4mlzZ56Ibi9W/wI1IxTKrWsj3bNHSfLsKB2vQJrhhd4mMfRkJ2ag==", "11a28d92-0ac4-4c9b-8987-d12dbacd8f9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5ab401b-dfc6-4553-b275-5519253cf9da",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b97a6e85-bdfc-4087-bd4e-9506c3e44f5b", "AQAAAAEAACcQAAAAEJLoU6SCkyrAc63jPtsRN7a3zuWg85siMHV+DIL9iddGaXxC1xbKi1YQB90X5P9r3w==", "b76c9546-90de-4b95-9689-e477ba0c12f0" });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_CompanyId",
                table: "Contracts",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_UserId",
                table: "Contracts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23eaa10a-4fa2-4bfb-ba6a-455f3d2842c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2c118f0-3e38-4044-98a1-b33d070bd31f", "AQAAAAEAACcQAAAAELVAYsxw20Ra5V4MDpvaK/us/fmTLEQ9fhZTHkkwUVZhJY4OkYvgchQwcLcYhbgfHg==", "c43ce542-9af9-4762-9b31-6e528beae9ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2652e409-1d33-4933-baa2-951954e7cf6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d70a5330-e718-4faf-977e-9518fd29fdac", "AQAAAAEAACcQAAAAEKz962MuRQASEWrA5vigbARX4BdDTUtquHMlBWYTc+CyGCVugOA9UTZz89+3cuzOfw==", "94aa28ff-4769-4201-a745-ad408db43950" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dc0badb-71dd-4ce7-b3e7-052349b2996f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "115a3b18-bb6b-4f48-9d40-0c3eb6d53bb6", "AQAAAAEAACcQAAAAEI5mX9cH849GIKT/sUMaBOiZOmcjn8Y41vEl/NeWMdtaq4edi/oOg5PdCV6i+bsyQQ==", "fb60eccc-fe93-4c94-891a-baf80df5e715" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "522608c8-bac8-43d6-bdce-cfdf77dfad43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aff2795f-c977-4773-966e-24c3de12483b", "AQAAAAEAACcQAAAAENbwd2YTNvHjYgiSfKNol1AxDgl0/soZXVhXt7PPsSQif5yfTbSFLrJwJ6R0TsBOoA==", "db82c9a9-1a03-43c9-a543-92bade695400" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a26386f-cb30-4a30-82c6-d8ad1415e1ff", "AQAAAAEAACcQAAAAEC3pDTiVGYOurwt2TrdLuUnHE+Bj/Qwuuvmg/xiLP2IMDaChnNNkhHEF8RPS0qRkGA==", "ecb15de4-8aa4-44be-af24-efc9fb833896" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63194488-88fe-4477-be42-958ea66bab16", "AQAAAAEAACcQAAAAEItvjVjYp+aknsT/IeCU8H0/1ofeqnRPcVXb4d+KsUoogNhaxVBY8mk6dlvj6By5LQ==", "80986410-e9a2-41bf-be27-4cbee191e76b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c6a38f1-80b4-4625-affc-061837bee170",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "988acb66-6911-42c8-88fc-3ba4fa399ba9", "AQAAAAEAACcQAAAAED8A5Ia2Rh+4nSI1gxItuF+lFXb5i6degAFsMZ+3QTvcMiJUq3+GVpcAZHrjnwujcA==", "473ca7ef-f39c-4555-a1a4-4e2f4651078c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f3b1759-c4f9-49bd-8fa5-aac53f731ae8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d77f9822-0a9a-4c74-a621-7128e08036b5", "AQAAAAEAACcQAAAAEF7GzDn9hcO3wDh58M+WyCkdrtSYh2ug8aIJhVW/4Ye7AHbYF4LvYOp//Epv4x1R2g==", "c19b81c7-e16f-414d-a26b-f37bd8054f9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54088a67-6b16-49fd-ae64-7efaca0792fb", "AQAAAAEAACcQAAAAEC2Yd/0u+AZIFASX43OfBgvcqGFTLMlBDZ4KwJiZykC+iX80CS6cprUdQ5SacvU2JA==", "21c4c2c6-57bf-4f06-b89a-ced39991a657" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5ab401b-dfc6-4553-b275-5519253cf9da",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3840ed6-fa2e-4bc3-a429-24587cb4b547", "AQAAAAEAACcQAAAAENYUmQ3mjaFyRJRtdXiHHKlZPPdXTYt6LTp1yq3H7e6n0007m4d6TgBQDSyj2i5ppg==", "1b906418-b3d1-4b35-9c5c-6ac6e0d6eb47" });
        }
    }
}
