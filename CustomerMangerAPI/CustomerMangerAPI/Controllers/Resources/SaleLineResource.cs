using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMangerAPI.Controllers.Resources
{
    public class SaleLineResource
    {
       
        public int saleLineId { get; set; }
        public int quantity { get; set; }
        
        public int totalQuantity { get; set; }

        // public ICollection<SaleLineResource> saleLines { get; set; }
        //public SaleLineResource()
        //{
        //  saleLines = new Collection<SaleLineResource>();
        //}
        public int productId { get; set; }
        public int saleId { get; set; }
    }
}
