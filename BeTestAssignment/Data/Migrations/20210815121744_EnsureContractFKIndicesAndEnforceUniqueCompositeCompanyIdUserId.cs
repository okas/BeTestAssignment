using Microsoft.EntityFrameworkCore.Migrations;

namespace BeTestAssignment.Data.Migrations
{
    public partial class EnsureContractFKIndicesAndEnforceUniqueCompositeCompanyIdUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23eaa10a-4fa2-4bfb-ba6a-455f3d2842c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "532df8b1-4dee-4b61-a7b1-7da5804a08d2", "AQAAAAEAACcQAAAAEPpkE5zh/V5hmW26dcLxmb2v3SdNgYZzIj52Ghf6281XNK25ap4iV6DXNauDMqWXiQ==", "8c585f66-f90f-4ade-86db-71aa777a74f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2652e409-1d33-4933-baa2-951954e7cf6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "293f005c-f06a-4d72-bf2d-2730ab0f568f", "AQAAAAEAACcQAAAAEL/2yFCrCNB9ok3UW5o0E2McoRWG90wg3PbCsx/rPD226lM5KY0yA1UWokWTTk+FZg==", "2f08ebf5-0d14-4153-a1a0-4d4470fec560" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dc0badb-71dd-4ce7-b3e7-052349b2996f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b54de2af-1d04-4592-9332-545a89931b41", "AQAAAAEAACcQAAAAEIRU1djDttwk+JQksfHCWnA9wv+5jgntncj84q0N6OMzEZRcJLzvp63fwmPtC2S6hg==", "1b39cdf0-e7f7-45bc-84bb-34336c3390b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "522608c8-bac8-43d6-bdce-cfdf77dfad43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c02c7d5a-e49d-42b6-9dc4-6ae455fc1f70", "AQAAAAEAACcQAAAAEIKP/KXJjWVf65ZBvZTK9UArcbCuJ0B2avqrQjbHm9PRwr+WRgXrfVhRE6v2IWKhfw==", "f2ffe45a-b86e-48f6-810f-18b4a6bd6be4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "261d5a19-bfa8-4cbc-ae56-c529596d6970", "AQAAAAEAACcQAAAAEJjSST4zg/k5p7AxNiQ9eCkmXH+UJqeOCwMp/f4Kj7UlBID4zRoQ8TnQxA1aGB5vGA==", "000bc3ee-e9ff-4df4-ae52-e5a55b9a157d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25fa556c-fa11-4973-95ce-5c37828721a1", "AQAAAAEAACcQAAAAEGHX8gQpfbmd06VJU0QicgC7X8yRWLUCANuPqkUcYOKCym9J5kmej6AWAmGnv2wBew==", "ffe5408b-90be-4834-8470-9a221fbbbac0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c6a38f1-80b4-4625-affc-061837bee170",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d51376d7-697b-4120-9dda-a0f61ed58d49", "AQAAAAEAACcQAAAAEESmFV3zqs1RABO5cGZ4n9yzf0zmgmPzCxAMZOFJvN0RqH9NcIeYHqRHBdItMEH2UA==", "189056eb-1ed8-418d-959a-256e1c086a9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f3b1759-c4f9-49bd-8fa5-aac53f731ae8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7f45732-b370-470f-be70-a137c1e66088", "AQAAAAEAACcQAAAAENnQOe1MFPdp8FNBnHCwvCrO1GxMD2TpzTxDI5Em2ASXhSZNh1HY/+HJ8vZDFTz5nQ==", "c3372aa0-56ae-4bf5-9adb-77428999f73a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4f0f6e8-c7b0-4caf-8024-9942e5a82447", "AQAAAAEAACcQAAAAEEBMfi4QxsDw9vJ0Hqjzs7IMGKTvknDtcZ9j7SsqN4wxl+VcIWhqciogLvoOebrIkQ==", "6e3f39ff-086d-4081-ab58-b8ffd37c8a06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5ab401b-dfc6-4553-b275-5519253cf9da",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5413e91f-986f-45de-a52a-3f970ad91d6c", "AQAAAAEAACcQAAAAEC94WMyxnSCNDpdts+Rtx4MVOcq/0cyZbS6RF4V1jVkA/0QbhYrLJVHgoroPYNgX/g==", "e15e85fe-8a3a-48c1-8c23-6a36e50de3ce" });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_CompanyId_UserId",
                table: "Contracts",
                columns: new[] { "CompanyId", "UserId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contracts_CompanyId_UserId",
                table: "Contracts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23eaa10a-4fa2-4bfb-ba6a-455f3d2842c2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c7199e9-4045-459e-b4e0-0e9a30a2d773", "AQAAAAEAACcQAAAAEIxsZvR5YwDZ7zRztLWbn+h/TTMb0r538yrs744UkyReTMhgzIteABO0+hu9rFqCgg==", "d7a04198-6c0e-4f8e-b6eb-72fb97a7daf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2652e409-1d33-4933-baa2-951954e7cf6b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acafaf72-9e3d-4dc5-8d29-41370eb11dca", "AQAAAAEAACcQAAAAEB0P3FGZvGYtjIhk/fIljsFONPvSp+DaEJ0DjPx2sFGvC9Kai1TTlGgxYETQYmUf4Q==", "5ac31807-525d-4213-826e-3966d8e0e6c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dc0badb-71dd-4ce7-b3e7-052349b2996f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70dec176-0164-41ef-a7e5-e22ab7ff33ab", "AQAAAAEAACcQAAAAEM4YssnYumCLglcXDAZ1OVvMnmfyDakN8KgaNXTnt0Wr5O9vC+RnVLfpq5UbUik0eQ==", "a2abdf02-6ef9-48ab-9ce0-03f44eb0e585" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "522608c8-bac8-43d6-bdce-cfdf77dfad43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca0a7baf-6bb6-4590-bafd-49009f01d4ae", "AQAAAAEAACcQAAAAELUUbvAnm97WGS0TFvzLxf3VkWseyBISLKrhxAseiXCDNzoY99+CjdgdCTBlUbJFXA==", "6f0fcdbb-ec1f-4173-beac-05f683a807b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c544a49-2dfc-4a93-9c64-78bf4b668bee", "AQAAAAEAACcQAAAAEPWt7zp7mDRttwVl4vYoqxZY7wNHc717SayWPLLsfZ9v8l+32Kdnqq/vERV6GBpPUQ==", "7e21df40-8458-4cce-bc5f-c4372bdd9608" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cfc91ef-7010-4105-8f23-f1fa03c066de", "AQAAAAEAACcQAAAAEFmhMFWq9zP3JAIH62VlCXJR3QtfxMMfvDfobZquI84uwH+T2KpbzADuIcw1D4qDBQ==", "161a9c1a-8217-4ef4-9719-539526dd1281" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c6a38f1-80b4-4625-affc-061837bee170",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7725a54-bdf9-44e4-a343-b12f2a141a55", "AQAAAAEAACcQAAAAEA2jXH33GSaNUdaH98vDIOVgJW1ui0vTXguYZm8PCuyCDcNGY2ddK2buioL9kmc55A==", "9f5f9a92-3b44-46c8-91cb-4a599c3d60bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f3b1759-c4f9-49bd-8fa5-aac53f731ae8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63519956-2955-4739-ac48-1e87dbe3da9f", "AQAAAAEAACcQAAAAEB44XUHX+m/6prQZLfDTAnZqg76xBCdgkbdYYRbVfm6U3vsM6Rem8ub+qSejmxvF6Q==", "a2c139b8-101d-4fd7-bee3-a8534ec946f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "537e7eaf-d6fe-4eab-9693-3464c4c3561e", "AQAAAAEAACcQAAAAEDz9EcBSZL9ELLsJxQbV4p+QFELEWAwGRyRaH0N5YGM0uOEdO+WYzGzF9ta2VpnM6w==", "37637238-87a4-45a4-acd5-ec04c776b56e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5ab401b-dfc6-4553-b275-5519253cf9da",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b861ff92-6104-41c5-9321-28d8a877fc0c", "AQAAAAEAACcQAAAAEKDvkKdQWYO4hGxjBF17Q6J578S8TDzib9l2bVYCRHMTQJAw8x9hBOoteZF0y6pGNA==", "cecf23e5-e270-4cfa-a37b-6afb84d072b0" });
        }
    }
}
