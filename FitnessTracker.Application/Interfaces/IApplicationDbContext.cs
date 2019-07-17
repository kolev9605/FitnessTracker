using System.Threading;
using System.Threading.Tasks;

namespace FitnessTracker.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
