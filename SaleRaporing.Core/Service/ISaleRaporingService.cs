using SaleRaporing.Core.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaleRaporing.Core.Service
{
    public interface ISaleRaporingService
    {

        Task<IEnumerable<SaleRaporingModel>> GetSaleRaporingModels();
        Task<SaleRaporingModel> GetSaleRaporingById(int id);
        Task<SaleRaporingModel> CreateSaleRaporing(SaleRaporingModel SaleRaporing);
        Task UpdateSaleRaporing(SaleRaporingModel SaleRaporingToBeUpdated, SaleRaporingModel SaleRaporing);
        Task DeleteSaleRaporing(SaleRaporingModel SaleRaporing);
    }
}
