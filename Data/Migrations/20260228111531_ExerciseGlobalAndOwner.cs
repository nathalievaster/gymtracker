using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTracker.Migrations
{
    /// <inheritdoc />
    public partial class ExerciseGlobalAndOwner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsGlobal",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Exercises",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_OwnerId",
                table: "Exercises",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_AspNetUsers_OwnerId",
                table: "Exercises",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_AspNetUsers_OwnerId",
                table: "Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_OwnerId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "IsGlobal",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Exercises");
        }
    }
}
