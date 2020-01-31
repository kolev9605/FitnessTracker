using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FitnessTracker.Persistance.Migrations
{
    public partial class MuscleGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MuscleGroupTypes",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscleGroupTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MuscleGroups",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: false),
                    ScientificName = table.Column<string>(nullable: false),
                    MuscleGroupTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscleGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MuscleGroups_MuscleGroupTypes_MuscleGroupTypeId",
                        column: x => x.MuscleGroupTypeId,
                        principalSchema: "public",
                        principalTable: "MuscleGroupTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseMuscleGroups",
                schema: "public",
                columns: table => new
                {
                    ExerciseId = table.Column<int>(nullable: false),
                    MuscleGroupId = table.Column<int>(nullable: false),
                    MoverType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseMuscleGroups", x => new { x.ExerciseId, x.MuscleGroupId });
                    table.ForeignKey(
                        name: "FK_ExerciseMuscleGroups_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalSchema: "public",
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseMuscleGroups_MuscleGroups_MuscleGroupId",
                        column: x => x.MuscleGroupId,
                        principalSchema: "public",
                        principalTable: "MuscleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseMuscleGroups_MuscleGroupId",
                schema: "public",
                table: "ExerciseMuscleGroups",
                column: "MuscleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MuscleGroups_MuscleGroupTypeId",
                schema: "public",
                table: "MuscleGroups",
                column: "MuscleGroupTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseMuscleGroups",
                schema: "public");

            migrationBuilder.DropTable(
                name: "MuscleGroups",
                schema: "public");

            migrationBuilder.DropTable(
                name: "MuscleGroupTypes",
                schema: "public");
        }
    }
}
