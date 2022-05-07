using Microsoft.EntityFrameworkCore;
using SaleRaporing.Core.Model;
using SaleRaporing.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleReporing.Data.Repositories
{
    public class SaleRaporingRepository : Repository<SaleRaporingModel> , ISaleRaporingRepository  
    {
        public SaleRaporingRepository(SaleRaporingDBContext context) : base(context)
        {
        }

        public async Task<IEnumerable<SaleRaporingModel>> GetAllWithSaleRaporingAsync()
        {
            return await SaleRaporingDBContext.SaleRaporingModel.ToListAsync();
        }



        private SaleRaporingDBContext SaleRaporingDBContext
        {
            get { return Context as SaleRaporingDBContext; }
        }



    }
}
