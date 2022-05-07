using SaleRaporing.Core;
using SaleRaporing.Core.Repositories;
using SaleReporing.Data.Repositories;
 

using System.Threading.Tasks;

namespace SaleReporing.Data
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly SaleRaporingDBContext _context;

        private SaleRaporingRepository _saleRepository;
        public ISaleRaporingRepository SaleRaporing => _saleRepository ?? new SaleRaporingRepository(_context);

        public UnitOfWork(SaleRaporingDBContext context)
        {
            this._context = context;
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
