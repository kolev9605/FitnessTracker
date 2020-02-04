using FitnessTracker.Application.Constants;
using FitnessTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FitnessTracker.Persistance.Seeders
{
    public static class ExerciseSeeder
    {
        private static Dictionary<string, Exercise> exercisesByName = new Dictionary<string, Exercise>()
        {
            //Chest
            {
                ExerciseNames.BenchPressName,
                new Exercise {
                    Id = 1,
                    Name = ExerciseNames.BenchPressName,
                }
            },
            {
                ExerciseNames.InclineBenchPressName,
                new Exercise
                {
                    Id = 2,
                    Name = ExerciseNames.InclineBenchPressName,
                }
            },
            {
                ExerciseNames.DeclineBenchPressName,
                new Exercise
                {
                    Id = 3,
                    Name = ExerciseNames.DeclineBenchPressName,
                }
            },
            {
                ExerciseNames.CloseGripBenchPressName,
                new Exercise
                {
                    Id = 4,
                    Name = ExerciseNames.CloseGripBenchPressName,
                }
            },
            {
                ExerciseNames.DumbbellBenchPressName,
                new Exercise
                {
                    Id = 5,
                    Name = ExerciseNames.DumbbellBenchPressName,
                }
            },
            {
                ExerciseNames.DumbbellInclineBenchPressName,
                new Exercise
                {
                    Id = 6,
                    Name = ExerciseNames.DumbbellInclineBenchPressName,
                }
            },
            //Back
            {
                ExerciseNames.BarbellBentOverRowsName,
                new Exercise
                {
                    Id = 7,
                    Name = ExerciseNames.BarbellBentOverRowsName,
                }
            },
            {
                ExerciseNames.OneArmDumbbellRowsName,
                new Exercise
                {
                    Id = 8,
                    Name = ExerciseNames.OneArmDumbbellRowsName,
                }
            },
            {
                ExerciseNames.LatPulldownName,
                new Exercise
                {
                    Id = 9,
                    Name = ExerciseNames.LatPulldownName,
                }
            },
            {
                ExerciseNames.SeatedRowsName,
                new Exercise
                {
                    Id = 10,
                    Name = ExerciseNames.SeatedRowsName,
                }
            },
            {
                ExerciseNames.HyperextensionsName,
                new Exercise
                {
                    Id = 11,
                    Name = ExerciseNames.HyperextensionsName,
                }
            },
            //Shoulders
            {
                ExerciseNames.MilitaryShoulderPressName,
                new Exercise
                {
                    Id = 12,
                    Name = ExerciseNames.MilitaryShoulderPressName,
                }
            },
            {
                ExerciseNames.DumbbellMilitaryShoulderSeatedPressName,
                new Exercise
                {
                    Id = 13,
                    Name = ExerciseNames.DumbbellMilitaryShoulderSeatedPressName,
                }
            },
            {
                ExerciseNames.LateralRaisesName,
                new Exercise
                {
                    Id = 14,
                    Name = ExerciseNames.LateralRaisesName,
                }
            },
            {
                ExerciseNames.BentOverLateralRaisesName,
                new Exercise
                {
                    Id = 15,
                    Name = ExerciseNames.BentOverLateralRaisesName,
                }
            },
            {
                ExerciseNames.FacePullsName,
                new Exercise
                {
                    Id = 16,
                    Name = ExerciseNames.FacePullsName,
                }
            },
            //Triceps
            {
                ExerciseNames.SkullCrushersName,
                new Exercise
                {
                    Id = 17,
                    Name = ExerciseNames.SkullCrushersName,
                }
            },
            {
                ExerciseNames.CableRopeTricepsPushdownName,
                new Exercise
                {
                    Id = 18,
                    Name = ExerciseNames.CableRopeTricepsPushdownName,
                }
            },
            //Biceps
            {
                ExerciseNames.HammerCurlsName,
                new Exercise
                {
                    Id = 19,
                    Name = ExerciseNames.HammerCurlsName,
                }
            },
            {
                ExerciseNames.DumbbellInclineCurlName,
                new Exercise
                {
                    Id = 20,
                    Name = ExerciseNames.DumbbellInclineCurlName,
                }
            },
            //Forearms
            {
                ExerciseNames.ReverseBarbellCurlsName,
                new Exercise
                {
                    Id = 21,
                    Name = ExerciseNames.ReverseBarbellCurlsName,
                }
            },
            {
                ExerciseNames.WristCurlsName,
                new Exercise
                {
                    Id = 22,
                    Name = ExerciseNames.WristCurlsName,
                }
            },
            {
                ExerciseNames.ReverseWristCurlsName,
                new Exercise
                {
                    Id = 23,
                    Name = ExerciseNames.ReverseWristCurlsName,
                }
            },
            //Legs
            {
                ExerciseNames.SquatsName,
                new Exercise
                {
                    Id = 24,
                    Name = ExerciseNames.SquatsName,
                }
            },
            {
                ExerciseNames.DumbbellLungesName,
                new Exercise
                {
                    Id = 25,
                    Name = ExerciseNames.DumbbellLungesName,
                }
            },
            {
                ExerciseNames.LegExtensionsName,
                new Exercise
                {
                    Id = 26,
                    Name = ExerciseNames.LegExtensionsName,
                }
            },
            {
                ExerciseNames.LyingLegCurlsName,
                new Exercise
                {
                    Id = 27,
                    Name = ExerciseNames.LyingLegCurlsName,
                }
            },
            {
                ExerciseNames.SeatedCalfRaiseName,
                new Exercise
                {
                    Id = 28,
                    Name = ExerciseNames.SeatedCalfRaiseName,
                }
            },
            {
                ExerciseNames.LegPressName,
                new Exercise
                {
                    Id = 29,
                    Name = ExerciseNames.LegPressName,
                }
            }
        };

        public static void SeedExercises(this ModelBuilder modelBuilder, Dictionary<string, MuscleGroup> muscleGroupsByName)
        {
            modelBuilder.Entity<Exercise>().HasData(exercisesByName.Select(e => e.Value));

            modelBuilder.Entity<ExerciseMuscleGroup>().HasData(
                //Bench
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.BenchPressName].Id, muscleGroupsByName[MuscleGroups.UpperChestName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.BenchPressName].Id, muscleGroupsByName[MuscleGroups.LowerChestName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.BenchPressName].Id, muscleGroupsByName[MuscleGroups.FrontDeltsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.BenchPressName].Id, muscleGroupsByName[MuscleGroups.TricepsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.BenchPressName].Id, muscleGroupsByName[MuscleGroups.BicepsName].Id, MoverType.Other),
                
                //Incline Bench Press
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.InclineBenchPressName].Id, muscleGroupsByName[MuscleGroups.UpperChestName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.InclineBenchPressName].Id, muscleGroupsByName[MuscleGroups.LowerChestName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.InclineBenchPressName].Id, muscleGroupsByName[MuscleGroups.FrontDeltsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.InclineBenchPressName].Id, muscleGroupsByName[MuscleGroups.TricepsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.InclineBenchPressName].Id, muscleGroupsByName[MuscleGroups.BicepsName].Id, MoverType.Other),

                //Decline Bench Press
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DeclineBenchPressName].Id, muscleGroupsByName[MuscleGroups.LowerChestName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DeclineBenchPressName].Id, muscleGroupsByName[MuscleGroups.UpperChestName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DeclineBenchPressName].Id, muscleGroupsByName[MuscleGroups.FrontDeltsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DeclineBenchPressName].Id, muscleGroupsByName[MuscleGroups.TricepsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DeclineBenchPressName].Id, muscleGroupsByName[MuscleGroups.BicepsName].Id, MoverType.Other),

                //Close-Grip Bench Press
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.CloseGripBenchPressName].Id, muscleGroupsByName[MuscleGroups.TrapsName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.CloseGripBenchPressName].Id, muscleGroupsByName[MuscleGroups.FrontDeltsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.CloseGripBenchPressName].Id, muscleGroupsByName[MuscleGroups.UpperChestName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.CloseGripBenchPressName].Id, muscleGroupsByName[MuscleGroups.LowerChestName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.CloseGripBenchPressName].Id, muscleGroupsByName[MuscleGroups.BicepsName].Id, MoverType.Other),

                //Dumbbell Bench Press
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellBenchPressName].Id, muscleGroupsByName[MuscleGroups.UpperChestName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellBenchPressName].Id, muscleGroupsByName[MuscleGroups.LowerChestName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellBenchPressName].Id, muscleGroupsByName[MuscleGroups.FrontDeltsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellBenchPressName].Id, muscleGroupsByName[MuscleGroups.TricepsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellBenchPressName].Id, muscleGroupsByName[MuscleGroups.BicepsName].Id, MoverType.Other),

                //Dumbbell Incline Bench Press
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellInclineBenchPressName].Id, muscleGroupsByName[MuscleGroups.UpperChestName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellInclineBenchPressName].Id, muscleGroupsByName[MuscleGroups.LowerChestName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellInclineBenchPressName].Id, muscleGroupsByName[MuscleGroups.FrontDeltsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellInclineBenchPressName].Id, muscleGroupsByName[MuscleGroups.TricepsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellInclineBenchPressName].Id, muscleGroupsByName[MuscleGroups.BicepsName].Id, MoverType.Other),

                //Barbell Bent-Over Rows
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.BarbellBentOverRowsName].Id, muscleGroupsByName[MuscleGroups.MiddleBackName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.BarbellBentOverRowsName].Id, muscleGroupsByName[MuscleGroups.LatsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.BarbellBentOverRowsName].Id, muscleGroupsByName[MuscleGroups.BicepsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.BarbellBentOverRowsName].Id, muscleGroupsByName[MuscleGroups.RearDeltsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.BarbellBentOverRowsName].Id, muscleGroupsByName[MuscleGroups.TrapsName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.BarbellBentOverRowsName].Id, muscleGroupsByName[MuscleGroups.UpperChestName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.BarbellBentOverRowsName].Id, muscleGroupsByName[MuscleGroups.LowerChestName].Id, MoverType.Other),

                //One-Arm Dumbbell Rows
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.OneArmDumbbellRowsName].Id, muscleGroupsByName[MuscleGroups.MiddleBackName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.OneArmDumbbellRowsName].Id, muscleGroupsByName[MuscleGroups.LatsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.OneArmDumbbellRowsName].Id, muscleGroupsByName[MuscleGroups.BicepsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.OneArmDumbbellRowsName].Id, muscleGroupsByName[MuscleGroups.RearDeltsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.OneArmDumbbellRowsName].Id, muscleGroupsByName[MuscleGroups.TrapsName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.OneArmDumbbellRowsName].Id, muscleGroupsByName[MuscleGroups.UpperChestName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.OneArmDumbbellRowsName].Id, muscleGroupsByName[MuscleGroups.LowerChestName].Id, MoverType.Other),

                //Lat pulldowns
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.LatPulldownName].Id, muscleGroupsByName[MuscleGroups.LatsName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.LatPulldownName].Id, muscleGroupsByName[MuscleGroups.BicepsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.LatPulldownName].Id, muscleGroupsByName[MuscleGroups.MiddleBackName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.LatPulldownName].Id, muscleGroupsByName[MuscleGroups.RearDeltsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.LatPulldownName].Id, muscleGroupsByName[MuscleGroups.TrapsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.LatPulldownName].Id, muscleGroupsByName[MuscleGroups.TricepsName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.LatPulldownName].Id, muscleGroupsByName[MuscleGroups.UpperChestName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.LatPulldownName].Id, muscleGroupsByName[MuscleGroups.LowerChestName].Id, MoverType.Other),

                //Seated Rows
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SeatedRowsName].Id, muscleGroupsByName[MuscleGroups.MiddleBackName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SeatedRowsName].Id, muscleGroupsByName[MuscleGroups.LatsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SeatedRowsName].Id, muscleGroupsByName[MuscleGroups.BicepsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SeatedRowsName].Id, muscleGroupsByName[MuscleGroups.RearDeltsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SeatedRowsName].Id, muscleGroupsByName[MuscleGroups.TrapsName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SeatedRowsName].Id, muscleGroupsByName[MuscleGroups.UpperChestName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SeatedRowsName].Id, muscleGroupsByName[MuscleGroups.LowerChestName].Id, MoverType.Other),

                //Hyperextensions
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.HyperextensionsName].Id, muscleGroupsByName[MuscleGroups.LowerBackName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.HyperextensionsName].Id, muscleGroupsByName[MuscleGroups.GlutesName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.HyperextensionsName].Id, muscleGroupsByName[MuscleGroups.HamstringsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.HyperextensionsName].Id, muscleGroupsByName[MuscleGroups.AbsName].Id, MoverType.Other),

                //Skull Crushers
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SkullCrushersName].Id, muscleGroupsByName[MuscleGroups.TricepsName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SkullCrushersName].Id, muscleGroupsByName[MuscleGroups.FrontDeltsName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SkullCrushersName].Id, muscleGroupsByName[MuscleGroups.UpperChestName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SkullCrushersName].Id, muscleGroupsByName[MuscleGroups.LowerChestName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SkullCrushersName].Id, muscleGroupsByName[MuscleGroups.RearDeltsName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SkullCrushersName].Id, muscleGroupsByName[MuscleGroups.LatsName].Id, MoverType.Other),

                //Cable Rope Triceps Pushdown
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.CableRopeTricepsPushdownName].Id, muscleGroupsByName[MuscleGroups.TricepsName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.CableRopeTricepsPushdownName].Id, muscleGroupsByName[MuscleGroups.ForearmsName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.CableRopeTricepsPushdownName].Id, muscleGroupsByName[MuscleGroups.LatsName].Id, MoverType.Other),

                //Hammer Curls
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.HammerCurlsName].Id, muscleGroupsByName[MuscleGroups.ForearmsName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.HammerCurlsName].Id, muscleGroupsByName[MuscleGroups.BicepsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.HammerCurlsName].Id, muscleGroupsByName[MuscleGroups.FrontDeltsName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.HammerCurlsName].Id, muscleGroupsByName[MuscleGroups.TrapsName].Id, MoverType.Other),

                //Dumbbell Incline Curls
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellInclineCurlName].Id, muscleGroupsByName[MuscleGroups.BicepsName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellInclineCurlName].Id, muscleGroupsByName[MuscleGroups.ForearmsName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellInclineCurlName].Id, muscleGroupsByName[MuscleGroups.FrontDeltsName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellInclineCurlName].Id, muscleGroupsByName[MuscleGroups.TrapsName].Id, MoverType.Other),

                //Reverse Barbell Curls
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.ReverseBarbellCurlsName].Id, muscleGroupsByName[MuscleGroups.ForearmsName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.ReverseBarbellCurlsName].Id, muscleGroupsByName[MuscleGroups.BicepsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.ReverseBarbellCurlsName].Id, muscleGroupsByName[MuscleGroups.FrontDeltsName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.ReverseBarbellCurlsName].Id, muscleGroupsByName[MuscleGroups.TrapsName].Id, MoverType.Other),

                //Wrist Curls
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.WristCurlsName].Id, muscleGroupsByName[MuscleGroups.ForearmsName].Id, MoverType.Primary),

                //Reverse Wrist Curls
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.ReverseWristCurlsName].Id, muscleGroupsByName[MuscleGroups.ForearmsName].Id, MoverType.Primary),

                //Squats
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SquatsName].Id, muscleGroupsByName[MuscleGroups.QuadricepsName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SquatsName].Id, muscleGroupsByName[MuscleGroups.GlutesName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SquatsName].Id, muscleGroupsByName[MuscleGroups.HamstringsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SquatsName].Id, muscleGroupsByName[MuscleGroups.CalvesName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SquatsName].Id, muscleGroupsByName[MuscleGroups.AbsName].Id, MoverType.Other),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SquatsName].Id, muscleGroupsByName[MuscleGroups.LowerBackName].Id, MoverType.Other),

                //Lunges
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellLungesName].Id, muscleGroupsByName[MuscleGroups.QuadricepsName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellLungesName].Id, muscleGroupsByName[MuscleGroups.GlutesName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellLungesName].Id, muscleGroupsByName[MuscleGroups.HamstringsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.DumbbellLungesName].Id, muscleGroupsByName[MuscleGroups.CalvesName].Id, MoverType.Other),

                //Leg Extensions
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.LegExtensionsName].Id, muscleGroupsByName[MuscleGroups.QuadricepsName].Id, MoverType.Primary),

                //Lying Leg Curls
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.LyingLegCurlsName].Id, muscleGroupsByName[MuscleGroups.HamstringsName].Id, MoverType.Primary),

                //Seated Calf Raises
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.SeatedCalfRaiseName].Id, muscleGroupsByName[MuscleGroups.CalvesName].Id, MoverType.Primary),

                //Leg press
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.LegPressName].Id, muscleGroupsByName[MuscleGroups.QuadricepsName].Id, MoverType.Primary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.LegPressName].Id, muscleGroupsByName[MuscleGroups.GlutesName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.LegPressName].Id, muscleGroupsByName[MuscleGroups.HamstringsName].Id, MoverType.Secondary),
                CreateExerciseMuscleGroup(exercisesByName[ExerciseNames.LegPressName].Id, muscleGroupsByName[MuscleGroups.CalvesName].Id, MoverType.Other)
            );
        }

        private static ExerciseMuscleGroup CreateExerciseMuscleGroup(int exerciseId, int muscleGroupId, MoverType moverType)
        {
            var exerciseMuscleGroup = new ExerciseMuscleGroup
            {
                ExerciseId = exerciseId,
                MuscleGroupId = muscleGroupId,
                MoverType = moverType,
            };

            return exerciseMuscleGroup;
        }
    }
}
