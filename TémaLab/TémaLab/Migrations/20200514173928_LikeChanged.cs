using Microsoft.EntityFrameworkCore.Migrations;

namespace TémaLab.Migrations
{
    public partial class LikeChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "Likes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "Likes",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Likes_CommentId",
                table: "Likes",
                column: "CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Comments_CommentId",
                table: "Likes",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Comments_CommentId",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Likes_CommentId",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "Likes");

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "Likes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
        }
    }
}
