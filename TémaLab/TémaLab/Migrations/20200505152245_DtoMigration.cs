using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TémaLab.Migrations
{
    public partial class DtoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostDtoId",
                table: "Likes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostDtoId",
                table: "Comments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PostDto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostDto_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4fa5cc24-51a1-4553-b6df-0380b349924d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d67e1435-bfec-4948-9a41-f4d6afda58a4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b44ff69d-03de-43d9-924e-e0d9740469fb");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "e2afb8c3-7e14-4873-8f40-6d5cf2a1a3dc");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "ff50d7d0-d8c5-4d02-86be-f6927a998425");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "4b20596b-ca9b-450a-919c-8dd1dbac7ba2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "dae5cde8-2a81-425e-8c1e-50321f830b5e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "c9e96bd4-17e3-4bbf-a41b-44b8eb8c7693");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "f923610a-9455-457f-9acd-fdd4b3b8e3d8");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "5d4a0e06-6332-413b-bc2c-f1c416efc071");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "af8b0cd7-3455-4661-8aba-8612eceaa08f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "14c8139b-3596-4d9b-965f-b00e4190c022");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "e2ad687b-0c94-41a5-9040-459133238a0a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "9963fdeb-4072-41a6-a59b-9b73e915f4d3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "3c2a7b21-6eac-4a74-a1fd-99a5f6a905b1");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_PostDtoId",
                table: "Likes",
                column: "PostDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostDtoId",
                table: "Comments",
                column: "PostDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_PostDto_UserId",
                table: "PostDto",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_PostDto_PostDtoId",
                table: "Comments",
                column: "PostDtoId",
                principalTable: "PostDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_PostDto_PostDtoId",
                table: "Likes",
                column: "PostDtoId",
                principalTable: "PostDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_PostDto_PostDtoId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_PostDto_PostDtoId",
                table: "Likes");

            migrationBuilder.DropTable(
                name: "PostDto");

            migrationBuilder.DropIndex(
                name: "IX_Likes_PostDtoId",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PostDtoId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PostDtoId",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "PostDtoId",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "843da767-57f4-4006-8b5a-20f8085f7dc1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "7928bafb-ebeb-4435-94d5-6da23131f881");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "67e435a3-181c-441d-ab8d-e1bddf97acdd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "58cbb2af-4d56-4eec-8c2d-c8e474fa1c20");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "b40d2af3-628d-4ec3-8bdb-7c07454da96a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "86c782f8-65de-4999-a90c-6c9392307f0e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "9bfe0c5e-f46c-4460-82d7-26f8e5860fa3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "90e3f942-b03d-4498-a74e-4415cb70154a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "9c30ec50-cc3e-469b-954c-7ec0bf2aa454");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "253fa105-0273-4485-8fb8-aff4670a1ad4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "992a4285-3c71-4c83-b609-40543a81b0e3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "2d0c3000-4f6c-4d77-a963-19bccd6f3cc4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "afcee36b-66ba-44f3-962e-075d8f1dc6a3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "97978453-c38c-4609-a93a-a7ede0bd5aa1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "8e0e4cdf-5a14-47f5-99c8-335fa24c3254");
        }
    }
}
