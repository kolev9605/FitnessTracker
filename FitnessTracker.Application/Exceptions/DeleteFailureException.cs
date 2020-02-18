using System;

namespace FitnessTracker.Application.Exceptions
{
    public class DeleteFailureException : Exception
    {
        public DeleteFailureException(string name, int id, string message)
            : base($"Deletion of entity \"{name}\" ({id}) failed: {message}")
        {
        }

        public DeleteFailureException(string name, string id, string message)
            : base($"Deletion of entity \"{name}\" ({id}) failed: {message}")
        {
        }
    }
}
