using block_learn_api.Shared.Domain.Repositories;
using block_learn_api.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace block_learn_api.Shared.Infrastructure.Persistence.EFC.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context) => _context = context;

        public async Task CompleteAsync() => await _context.SaveChangesAsync();
    }
}
