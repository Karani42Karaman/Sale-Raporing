using System;
using System.ComponentModel.DataAnnotations.Schema;
 

namespace SaleRaporing.Core.Model
{
    [Table("SaleRaporing")]
    public  class SaleRaporingModel
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string Customer { get; set; }
        public int TotalProductSold { get; set; }
        
        public int TotalPrice { get; set; }        

        public DateTime DateOfSale { get; set; }

        public DateTime DateOfRegistration { get; set; }
    }
}
