using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseProjectApp.Migrations
{
    public partial class ForeignKey_AspNet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AspNetUserId",
                table: "Organizations",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AspNetUserId",
                table: "Individuals",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AspNetUserId",
                table: "Hobbies",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_AspNetUserId",
                table: "Organizations",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Individuals_AspNetUserId",
                table: "Individuals",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_AspNetUserId",
                table: "Hobbies",
                column: "AspNetUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hobbies_AspNetUsers_AspNetUserId",
                table: "Hobbies",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Individuals_AspNetUsers_AspNetUserId",
                table: "Individuals",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Organizations_AspNetUsers_AspNetUserId",
                table: "Organizations",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hobbies_AspNetUsers_AspNetUserId",
                table: "Hobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_Individuals_AspNetUsers_AspNetUserId",
                table: "Individuals");

            migrationBuilder.DropForeignKey(
                name: "FK_Organizations_AspNetUsers_AspNetUserId",
                table: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_Organizations_AspNetUserId",
                table: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_Individuals_AspNetUserId",
                table: "Individuals");

            migrationBuilder.DropIndex(
                name: "IX_Hobbies_AspNetUserId",
                table: "Hobbies");

            migrationBuilder.AlterColumn<string>(
                name: "AspNetUserId",
                table: "Organizations",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AspNetUserId",
                table: "Individuals",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AspNetUserId",
                table: "Hobbies",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
