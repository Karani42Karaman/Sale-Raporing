using SaleRaporing.Core.Model;
using SaleRaporing.DataAccess.Model;
using System.Collections.Generic;

namespace SaleRaporing.Models
{
    public class ViewModel
    {

        public IEnumerable<SaleRaporingModel> SaleRaporing { get; set; }
        public IEnumerable<rpacollection> RpaCollection { get; set; }
    }
}
