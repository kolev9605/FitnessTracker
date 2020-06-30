using Amazon;

namespace FitnessTracker.Application.Constants
{
    public static class AwsConstants
    {
        public static readonly string JsonsBucketName = "fitness-tracker-jsons";

        public static readonly string ExercisesJsonKey = "exercises.json";

        public static readonly string MuscleGroupssonKey = "muscle-groups.json";

        public static readonly RegionEndpoint AppRegion = RegionEndpoint.EUWest2;
    }
}
