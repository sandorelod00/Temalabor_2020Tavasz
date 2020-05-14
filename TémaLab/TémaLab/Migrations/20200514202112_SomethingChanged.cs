using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TémaLab.Migrations
{
    public partial class SomethingChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompetitionDtoId",
                table: "Participations",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CompetitionDto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompetitionDto_Users_UserId",
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
                value: "3932320b-8649-47c8-b395-4d8a4d46350d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "277c7eff-8f0b-414e-bbbb-3a4455b6edcd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "32ac3a17-519e-40d3-88d1-81b9776f4823");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "16860a55-da8e-49c9-8fa1-6628f7d72571");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "2b83ec67-829d-4f52-9b90-25757cc8ccb8");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "15eca17d-c705-489c-8b44-a0a7213ce9d8");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "acca2df4-cd94-47c8-96b4-cbe962d1caf5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "1cd59a9c-823e-4038-a711-e7f893f6a03c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "3e8d976f-790f-4e7b-896e-a3a1f8bd1cbc");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "007cd379-207d-458d-88db-91d6b616b53d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "8ebe0802-14ec-45df-90bc-d5597b975705");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "6083b259-8d7f-4129-b912-291571c91110");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "7ec78850-b5d0-493c-9fa9-1d36e7f2ade3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "cc4c5172-6058-42fa-9a33-3e048d0ebeaa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "ffe29bbf-7669-48e7-9f97-6649e3447f5f");

            migrationBuilder.CreateIndex(
                name: "IX_Participations_CompetitionDtoId",
                table: "Participations",
                column: "CompetitionDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionDto_UserId",
                table: "CompetitionDto",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_CompetitionDto_CompetitionDtoId",
                table: "Participations",
                column: "CompetitionDtoId",
                principalTable: "CompetitionDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participations_CompetitionDto_CompetitionDtoId",
                table: "Participations");

            migrationBuilder.DropTable(
                name: "CompetitionDto");

            migrationBuilder.DropIndex(
                name: "IX_Participations_CompetitionDtoId",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "CompetitionDtoId",
                table: "Participations");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c89ad75c-5a96-4e40-bbfa-916d27311d6a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "309e7fcf-9c38-4712-9e4d-db552decb866");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "527c5535-779e-4ac3-a65c-386543b7d7cb");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "9c312974-6c68-486f-a0a8-79146b68c6f5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "f3dc8382-1993-4102-bd0b-4fd9dd1a64ed");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "2fc8a426-1baf-4793-ad33-f4b08712aeb5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "a7773ec2-0bf6-46c9-8a67-62ec167cb097");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "974b0a1d-1a0e-4f56-9cf4-dced81d1a2b2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "b426b443-d31e-4ddf-8302-9dee98731fe1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "2c3b505b-fd23-484e-9697-89d4e213a641");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "173385cc-6ad2-46e9-8a36-62f8b1940d09");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "3fe9e694-f278-4f0e-a6d6-b957829a3bf4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "72ed6a31-28fb-48d3-a289-b8d21ad783e5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "b6308890-a636-45ee-a4d6-b22adcc906f7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "8ab04f72-bdd2-4f30-8ace-8543a077ecf3");
        }
    }
}
