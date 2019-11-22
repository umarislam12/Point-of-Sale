using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMangerAPI.Controllers.Resources
{
    public class ProductResource
    {
    
        public int productId { get; set; }
        public string productName { get; set; }

        public int unitPrice { get; set; }
        public int productCode { get; set; }
       public virtual ICollection<SaleLineResource> SaleLines { get; set; }
       public ProductResource()
        {
          SaleLines = new Collection<SaleLineResource>();
        }
    }
}
