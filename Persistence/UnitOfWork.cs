using System.Threading.Tasks;
using carsdealer.Core;

namespace carsdealer.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CarsDealerDbContext context;
        public UnitOfWork(CarsDealerDbContext context)
        {
            this.context = context;

        }
        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}