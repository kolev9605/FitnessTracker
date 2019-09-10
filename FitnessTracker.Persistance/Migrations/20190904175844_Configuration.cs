using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessTracker.Persistance.Migrations
{
    public partial class Configuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "public",
                table: "Workouts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "public",
                table: "Exercises",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "public",
                table: "Workouts",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "public",
                table: "Exercises",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
