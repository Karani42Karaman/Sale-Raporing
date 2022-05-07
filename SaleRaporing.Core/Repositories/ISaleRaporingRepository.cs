using System.Collections.Generic;
using System.Threading.Tasks;
using SaleRaporing.Core.Model;


namespace SaleRaporing.Core.Repositories
{
    public interface ISaleRaporingRepository :IRepositoriy<SaleRaporingModel>
    {
        Task<IEnumerable<SaleRaporingModel>> GetAllWithSaleRaporingAsync();
    }
}
