using System.Threading.Tasks;

namespace carsdealer.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}