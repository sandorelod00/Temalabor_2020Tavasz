using Microsoft.EntityFrameworkCore.Migrations;

namespace TémaLab.Migrations
{
    public partial class UserDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserDtoId",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserDtoId",
                table: "Participations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserDtoId",
                table: "Friendship",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserDtoId1",
                table: "Friendship",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserDtoId",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserDtoId",
                table: "EventParticipations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserDtoId",
                table: "Competitions",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserDto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Introduction = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MTGACode = table.Column<string>(nullable: true),
                    Admin = table.Column<bool>(nullable: false),
                    score = table.Column<int>(nullable: false),
                    rank = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDto", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "00f36740-4ddd-4611-9dde-939656407c67");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d29b1672-2a36-4069-a64f-bc1c233eaeed");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "50fc14f8-2fbf-4430-88e7-9b51372dc83e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "cc36bdbb-3856-47ad-8cfe-3b21d5507625");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "ed09de8c-555a-4e2e-a61d-0103cf61fcac");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "d45a6fe3-97f2-44e1-a447-34b792a487ac");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "715f127b-dc9b-4482-9467-f90c78273682");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "63fd3955-b640-4837-ac77-54d0510a1a60");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "3dd38f42-f2d3-4284-9236-1f245be282cf");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "270fd53b-b296-48ba-a5aa-fefbe5b401d6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "af7d0854-91e2-4764-8025-038658847c38");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "eb8e4251-4b41-488d-b919-3827a56b5c77");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "67873897-6d8a-48fc-9457-b402ceab172c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "ConcurrencyStamp",
                value: "bd10dbac-8622-4783-b986-87f0b41842f5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "ConcurrencyStamp",
                value: "1a841fe4-baa6-495a-953d-0a03e6ecf8d1");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserDtoId",
                table: "Posts",
                column: "UserDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_Participations_UserDtoId",
                table: "Participations",
                column: "UserDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_Friendship_UserDtoId",
                table: "Friendship",
                column: "UserDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_Friendship_UserDtoId1",
                table: "Friendship",
                column: "UserDtoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserDtoId",
                table: "Events",
                column: "UserDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_EventParticipations_UserDtoId",
                table: "EventParticipations",
                column: "UserDtoId");

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_UserDtoId",
                table: "Competitions",
                column: "UserDtoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Competitions_UserDto_UserDtoId",
                table: "Competitions",
                column: "UserDtoId",
                principalTable: "UserDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventParticipations_UserDto_UserDtoId",
                table: "EventParticipations",
                column: "UserDtoId",
                principalTable: "UserDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_UserDto_UserDtoId",
                table: "Events",
                column: "UserDtoId",
                principalTable: "UserDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendship_UserDto_UserDtoId",
                table: "Friendship",
                column: "UserDtoId",
                principalTable: "UserDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendship_UserDto_UserDtoId1",
                table: "Friendship",
                column: "UserDtoId1",
                principalTable: "UserDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Participations_UserDto_UserDtoId",
                table: "Participations",
                column: "UserDtoId",
                principalTable: "UserDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_UserDto_UserDtoId",
                table: "Posts",
                column: "UserDtoId",
                principalTable: "UserDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competitions_UserDto_UserDtoId",
                table: "Competitions");

            migrationBuilder.DropForeignKey(
                name: "FK_EventParticipations_UserDto_UserDtoId",
                table: "EventParticipations");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_UserDto_UserDtoId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendship_UserDto_UserDtoId",
                table: "Friendship");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendship_UserDto_UserDtoId1",
                table: "Friendship");

            migrationBuilder.DropForeignKey(
                name: "FK_Participations_UserDto_UserDtoId",
                table: "Participations");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_UserDto_UserDtoId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "UserDto");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserDtoId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Participations_UserDtoId",
                table: "Participations");

            migrationBuilder.DropIndex(
                name: "IX_Friendship_UserDtoId",
                table: "Friendship");

            migrationBuilder.DropIndex(
                name: "IX_Friendship_UserDtoId1",
                table: "Friendship");

            migrationBuilder.DropIndex(
                name: "IX_Events_UserDtoId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_EventParticipations_UserDtoId",
                table: "EventParticipations");

            migrationBuilder.DropIndex(
                name: "IX_Competitions_UserDtoId",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "UserDtoId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserDtoId",
                table: "Participations");

            migrationBuilder.DropColumn(
                name: "UserDtoId",
                table: "Friendship");

            migrationBuilder.DropColumn(
                name: "UserDtoId1",
                table: "Friendship");

            migrationBuilder.DropColumn(
                name: "UserDtoId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UserDtoId",
                table: "EventParticipations");

            migrationBuilder.DropColumn(
                name: "UserDtoId",
                table: "Competitions");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8d53a851-ebaa-4b6f-8e28-0484a9fce208");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f2cc0dbc-302c-44c8-aa68-040c70016f04");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "38e95280-57dd-462c-a5ef-26ecf693f1bd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "ConcurrencyStamp",
                value: "88fa9fe4-3c37-4c4a-94b8-819c5a2a18c2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "ConcurrencyStamp",
                value: "4085abc0-f8d8-4fc4-a9f9-c621489ee99a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "ConcurrencyStamp",
                value: "908d602e-9ebf-48d5-bc7e-09d77c287def");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "ConcurrencyStamp",
                value: "21566553-ca80-4621-bd9f-969a862f4db5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "ConcurrencyStamp",
                value: "14ad6be4-f301-44b6-98af-ffe63f738325");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "ConcurrencyStamp",
                value: "a949f210-e42d-4ccc-9051-e5094502835f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "ConcurrencyStamp",
                value: "452ee125-9ebf-4e81-bef5-f1ff5eb7306a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "ConcurrencyStamp",
                value: "360fdf5a-dbe5-48f4-ab5a-9d4b36df2053");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "ConcurrencyStamp",
                value: "22aad0da-7e4e-4e0b-afc4-227bafeac398");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "ConcurrencyStamp",
                value: "c4521b81-b8ba-4879-99af-44f02c73d6f8");

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
    }
}
