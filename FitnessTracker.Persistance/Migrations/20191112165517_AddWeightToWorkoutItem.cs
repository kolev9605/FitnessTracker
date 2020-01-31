using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessTracker.Persistance.Migrations
{
    public partial class AddWeightToWorkoutItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Weight",
                schema: "public",
                table: "WorkoutItems",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                schema: "public",
                table: "WorkoutItems");
        }
    }
}
