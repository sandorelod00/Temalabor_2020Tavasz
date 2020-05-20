using Microsoft.EntityFrameworkCore.Migrations;

namespace TémaLab.Migrations
{
    public partial class UserRanks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "rank",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "rank" },
                values: new object[] { "8d53a851-ebaa-4b6f-8e28-0484a9fce208", "silver" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "rank" },
                values: new object[] { "f2cc0dbc-302c-44c8-aa68-040c70016f04", "gold" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "rank" },
                values: new object[] { "38e95280-57dd-462c-a5ef-26ecf693f1bd", "plat" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "rank" },
                values: new object[] { "88fa9fe4-3c37-4c4a-94b8-819c5a2a18c2", "diamond" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "rank" },
                values: new object[] { "4085abc0-f8d8-4fc4-a9f9-c621489ee99a", "silver" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "rank" },
                values: new object[] { "908d602e-9ebf-48d5-bc7e-09d77c287def", "silver" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "rank" },
                values: new object[] { "21566553-ca80-4621-bd9f-969a862f4db5", "gold" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "rank" },
                values: new object[] { "14ad6be4-f301-44b6-98af-ffe63f738325", "diamond" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "rank" },
                values: new object[] { "a949f210-e42d-4ccc-9051-e5094502835f", "plat" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "rank" },
                values: new object[] { "452ee125-9ebf-4e81-bef5-f1ff5eb7306a", "plat" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ConcurrencyStamp", "rank" },
                values: new object[] { "360fdf5a-dbe5-48f4-ab5a-9d4b36df2053", "silver" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ConcurrencyStamp", "rank" },
                values: new object[] { "22aad0da-7e4e-4e0b-afc4-227bafeac398", "gold" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ConcurrencyStamp", "rank" },
                values: new object[] { "c4521b81-b8ba-4879-99af-44f02c73d6f8", "silver" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "6c56f71e-07e3-4c2e-9d10-55435f9cbcee");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "f1a54df7-e8df-4a05-8841-7c8ceed97480");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rank",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "110defbb-f869-426a-8705-458a97dc6fc4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "85297906-9e5b-4b43-b5ca-22abe364782c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "e1e0f5b6-6cf5-4ed2-bda5-3edbdc672fb2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "8821fb2e-809e-4051-9244-905a59f87aa9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "3c7a092c-962d-4972-8f18-5c7c0f311adf");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "ee3dcdf0-6f73-49f3-b99e-c61a545cc7c4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "4ac7a3e1-20ff-4eaa-8058-ff0edb5aaff2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "2fbd852e-a8b7-41a6-88b8-116025f8c2cd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "579b5a8a-1c77-49d7-bf7d-d1c2c7536902");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "dc0473b9-1016-4f40-8d4c-49580d9b169f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "761e0a42-80e9-4e77-81ae-a236472c5773");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "c0046278-6fdb-45fb-a1eb-a05a1768ba09");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "7261e533-5d77-4dd9-b51b-9ecb42746874");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "5614b9ff-a173-42c9-8b45-01bc918a0bd1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "cdf6ac2a-5ede-4346-abd3-d67e2970049d");
        }
    }
}
