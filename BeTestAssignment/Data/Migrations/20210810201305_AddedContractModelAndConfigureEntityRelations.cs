using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeTestAssignment.Data.Migrations
{
    public partial class AddedContractModelAndConfigureEntityRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    Occupation = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => new { x.CompanyId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Contract_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contract_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23eaa10a-4fa2-4bfb-ba6a-455f3d2842c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "866da966-a4fb-4fb4-9a28-34184636819d", "AQAAAAEAACcQAAAAEFixmA4Yjg0VfwcvuqOOTPZoPTteE0MQ2c/K05nviuzEC9RVkg5IcJOm36OzldXfBA==", "7aab0428-1dca-4435-97d1-0b3ced4c5cd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2652e409-1d33-4933-baa2-951954e7cf6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcb22c19-e95d-4580-83cf-127e989abaf5", "AQAAAAEAACcQAAAAELJyBHLlBdtn3awVH/2N71V6YnKMQhs0ILnbx4B6HlxHCDhe5h3LPBpOZO3+eDS8Uw==", "0b28ef5c-bfdd-477c-9f9a-5f4a05c74196" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dc0badb-71dd-4ce7-b3e7-052349b2996f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6f383c0-fb55-42b2-82a3-d17092e19242", "AQAAAAEAACcQAAAAEPAJyPVD+8CgvR613d9OdxwwXjpvsGXp+nVtOB+o2bqbHv4Xdmb8+w015AwZea0a0A==", "2e523f8f-e13b-4179-adf6-ffd7f6a874a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "522608c8-bac8-43d6-bdce-cfdf77dfad43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36c6de73-db46-4a8d-9246-57e2ae7e74ec", "AQAAAAEAACcQAAAAEIgOt6o6fGpc54K0XYyKy1n+Nu7KLRlNtEWhVHr3nL8D+mGjxFV9V0Qhau+tCwSyvQ==", "6a95deae-6b31-41c9-a040-a798056146f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "081e214c-04c1-4a78-83e6-01e37e02a6c7", "AQAAAAEAACcQAAAAEJwgrPZsWTGd8vqHMqYz+KKKRB02iz954F+DyLM2jjfUBNoG1arXMX5FKZ1LRT+/YA==", "80b95cc6-4771-488b-9216-86c1a9e2eabb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78c7a942-d876-41bb-bc83-207e91ff7a62", "AQAAAAEAACcQAAAAEBoXroy61yvPRzPr5iWeFTnzbwG/z5yrYyuaIRPOCclcuW9VtoQZk/2XkWOmHiUxIA==", "6413183c-2305-43af-be5a-30b4407e2b44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c6a38f1-80b4-4625-affc-061837bee170",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f0d9429-c9a5-4a25-b433-d2c1de895e7b", "AQAAAAEAACcQAAAAEMxnAv+XCOPFGbYHrVvcH2/Zo2f1q6kx8ckP3OCoKBuaq3y48N6/PBjeJ+5T6aNKlw==", "e0441bce-985b-4d77-a395-afc9f0b21e91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f3b1759-c4f9-49bd-8fa5-aac53f731ae8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95d22183-dec1-4a7a-94c7-0459c58260cd", "AQAAAAEAACcQAAAAEIjJh6QPIgogVni+pT0J56XVOUxBRxid15uqJoj72vuNao2gZmDY++2R1H9ENeuLqQ==", "52ec0347-8be1-4d00-810b-fc1fa69e89d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9448ba20-1b52-45ff-9cad-2870832cacec", "AQAAAAEAACcQAAAAEHZEZLxDwa5kUvHslMfLAk+RjA6MSpWkVCr7dk3rp3jaSQmDyoT6Q/hDNl5QolaJ/A==", "a535cda9-2fb7-425f-9ffa-99665d4e43ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5ab401b-dfc6-4553-b275-5519253cf9da",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e67899c5-c08f-4410-b586-26b6df787b57", "AQAAAAEAACcQAAAAELpKWz4ejfvZD9HxI0bv4mKcV04DN4oYjJadq8Aed0vhuocPgbaQE/BFzCPP/Hp1bw==", "074e01a4-787f-47cf-95ba-15fdc4de02a2" });

            migrationBuilder.CreateIndex(
                name: "IX_Contract_UserId",
                table: "Contract",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contract");

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
