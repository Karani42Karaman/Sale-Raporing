using SaleRaporing.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace SaleRaporing.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ISaleRaporingRepository SaleRaporing { get; }
        Task<int> CommitAsync();
    }
}
