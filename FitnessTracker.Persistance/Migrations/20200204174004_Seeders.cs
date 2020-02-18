using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessTracker.Persistance.Migrations
{
    public partial class Seeders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "public",
                table: "Exercises",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bench Press" },
                    { 29, "Leg Press" },
                    { 28, "Seated Calf Raise" },
                    { 27, "Lying Leg Curls" },
                    { 26, "Leg extensions" },
                    { 25, "Dumbbell Lunges" },
                    { 24, "Squats" },
                    { 23, "Reverse Wrist Curls" },
                    { 22, "Wrist Curls" },
                    { 21, "Reverse Barbell Curls" },
                    { 20, "Dumbbell Incline Curls" },
                    { 19, "Hammer Curls" },
                    { 17, "Skull Crushers" },
                    { 16, "Face pulls" },
                    { 18, "Cable Rope Triceps Pushdown" },
                    { 14, "Lateral Raises" },
                    { 2, "Incline Bench Press" },
                    { 3, "Decline Bench Press" },
                    { 4, "Close-Grip Bench Press" },
                    { 5, "Dumbbell Bench Press" },
                    { 15, "Bent-Over Lateral Raises" },
                    { 7, "Barbell Bent-Over Rows" },
                    { 6, "Dumbbell Incline Bench Press" },
                    { 9, "Lat Pulldowns" },
                    { 10, "Seated Rows" },
                    { 11, "Hyperextensions" },
                    { 12, "Military Shoulder Press" },
                    { 13, "Dumbbell Military Shoulder Seated Press" },
                    { 8, "One-Arm Dumbbell Rows" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "MuscleGroupTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Arms" },
                    { 1, "Back" },
                    { 2, "Chest" },
                    { 3, "Abs" },
                    { 4, "Shoulders" },
                    { 6, "Legs" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "MuscleGroups",
                columns: new[] { "Id", "MuscleGroupTypeId", "Name", "ScientificName" },
                values: new object[,]
                {
                    { 1, 1, "Traps", "Trapezius" },
                    { 15, 6, "Quadriceps", "Quadriceps" },
                    { 14, 6, "Glutes", "Gluteus Maximas" },
                    { 13, 5, "Forearms", "Brachioradialis, Wrist Flexors, Wrist Extensors" },
                    { 12, 5, "Biceps", "Biceps Brachii" },
                    { 11, 5, "Triceps", "Triceps Brachii" },
                    { 10, 4, "Rear Delts", "Rear Deltoids" },
                    { 16, 6, "Hamstrings", "Hamstrings" },
                    { 9, 4, "Side Delts", "Side Deltoids" },
                    { 7, 3, "Abs", "Rectus Abdominis, Obliques" },
                    { 6, 2, "Lower Chest", "Pectoralis Minor" },
                    { 5, 2, "Upper Chest", "Pectoralis Major" },
                    { 4, 1, "Lower Back", "Erector Spinae" },
                    { 3, 1, "Lats", "Latissimus Dorsi" },
                    { 2, 1, "Middle Back", "Rhomboids" },
                    { 8, 4, "Front Delts", "Front Deltoids" },
                    { 17, 6, "Calves", "Gastrocnemius, Soleus" }
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                columns: new[] { "ExerciseId", "MuscleGroupId", "MoverType" },
                values: new object[,]
                {
                    { 4, 1, 0 },
                    { 8, 12, 1 },
                    { 7, 12, 1 },
                    { 6, 12, 3 },
                    { 5, 12, 3 },
                    { 4, 12, 3 },
                    { 3, 12, 3 },
                    { 2, 12, 3 },
                    { 1, 12, 3 },
                    { 18, 11, 0 },
                    { 17, 11, 0 },
                    { 9, 12, 1 },
                    { 9, 11, 3 },
                    { 5, 11, 1 },
                    { 3, 11, 1 },
                    { 2, 11, 1 },
                    { 1, 11, 1 },
                    { 17, 10, 3 },
                    { 10, 10, 1 },
                    { 9, 10, 1 },
                    { 8, 10, 1 },
                    { 7, 10, 1 },
                    { 21, 8, 3 },
                    { 6, 11, 1 },
                    { 20, 8, 3 },
                    { 10, 12, 1 },
                    { 20, 12, 0 },
                    { 25, 17, 3 },
                    { 24, 17, 3 },
                    { 29, 16, 1 },
                    { 27, 16, 0 },
                    { 25, 16, 1 },
                    { 24, 16, 1 },
                    { 11, 16, 1 },
                    { 29, 15, 0 },
                    { 26, 15, 0 },
                    { 25, 15, 0 },
                    { 19, 12, 1 },
                    { 24, 15, 0 },
                    { 25, 14, 1 },
                    { 24, 14, 1 },
                    { 11, 14, 1 },
                    { 23, 13, 0 },
                    { 22, 13, 0 },
                    { 21, 13, 0 },
                    { 20, 13, 3 },
                    { 19, 13, 0 },
                    { 18, 13, 3 },
                    { 21, 12, 1 },
                    { 29, 14, 1 },
                    { 28, 17, 0 },
                    { 19, 8, 3 },
                    { 6, 8, 1 },
                    { 3, 5, 1 },
                    { 2, 5, 0 },
                    { 1, 5, 0 },
                    { 24, 4, 3 },
                    { 11, 4, 0 },
                    { 18, 3, 3 },
                    { 17, 3, 3 },
                    { 10, 3, 1 },
                    { 9, 3, 0 },
                    { 8, 3, 1 },
                    { 4, 5, 1 },
                    { 7, 3, 1 },
                    { 9, 2, 1 },
                    { 8, 2, 0 },
                    { 7, 2, 0 },
                    { 21, 1, 3 },
                    { 20, 1, 3 },
                    { 19, 1, 3 },
                    { 10, 1, 3 },
                    { 9, 1, 1 },
                    { 8, 1, 3 },
                    { 7, 1, 3 },
                    { 10, 2, 0 },
                    { 17, 8, 3 },
                    { 5, 5, 0 },
                    { 7, 5, 3 },
                    { 5, 8, 1 },
                    { 4, 8, 1 },
                    { 3, 8, 1 },
                    { 2, 8, 1 },
                    { 1, 8, 1 },
                    { 24, 7, 3 },
                    { 11, 7, 3 },
                    { 17, 6, 3 },
                    { 10, 6, 3 },
                    { 9, 6, 3 },
                    { 6, 5, 0 },
                    { 8, 6, 3 },
                    { 6, 6, 1 },
                    { 5, 6, 0 },
                    { 4, 6, 1 },
                    { 3, 6, 0 },
                    { 2, 6, 1 },
                    { 1, 6, 0 },
                    { 17, 5, 3 },
                    { 10, 5, 3 },
                    { 9, 5, 3 },
                    { 8, 5, 3 },
                    { 7, 6, 3 },
                    { 29, 17, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 8, 12 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 9, 11 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 11, 14 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 11, 16 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 17, 6 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 17, 8 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 17, 10 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 17, 11 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 18, 11 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 18, 13 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 19, 8 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 19, 12 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 19, 13 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 20, 12 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 20, 13 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 21, 8 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 21, 12 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 21, 13 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 22, 13 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 23, 13 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 24, 4 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 24, 7 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 24, 14 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 24, 15 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 24, 16 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 24, 17 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 25, 14 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 25, 15 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 25, 16 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 25, 17 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 26, 15 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 27, 16 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 28, 17 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 29, 14 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 29, 15 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 29, 16 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "ExerciseMuscleGroups",
                keyColumns: new[] { "ExerciseId", "MuscleGroupId" },
                keyValues: new object[] { 29, 17 });

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroupTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroupTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroupTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroupTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroupTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "public",
                table: "MuscleGroupTypes",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
