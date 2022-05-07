using SaleRaporing.Core;
using SaleRaporing.Core.Model;
using SaleRaporing.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleRaporing.Service
{
    public class SaleRaporingService : ISaleRaporingService
    {

        private readonly IUnitOfWork _unitOfWork;


        public SaleRaporingService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }




        public async Task<SaleRaporingModel> CreateSaleRaporing(SaleRaporingModel SaleRaporing)
        {
            await _unitOfWork.SaleRaporing.AddAsync(SaleRaporing);
            await _unitOfWork.CommitAsync();
            return SaleRaporing;
        }

        public async Task DeleteSaleRaporing(SaleRaporingModel SaleRaporing)
        {
            _unitOfWork.SaleRaporing.Remove(SaleRaporing);
            await _unitOfWork.CommitAsync();
        }

        public async Task<SaleRaporingModel> GetSaleRaporingById(int id)
        {
            return await _unitOfWork.SaleRaporing.GetByIdAsync(id);

        }

        public async Task<IEnumerable<SaleRaporingModel>> GetSaleRaporingModels()
        {
            return await _unitOfWork.SaleRaporing.GetAllWithSaleRaporingAsync();
        }

        public Task UpdateSaleRaporing(SaleRaporingModel SaleRaporingToBeUpdated, SaleRaporingModel SaleRaporing)
        {
            throw new NotImplementedException();
        }
    }
}
