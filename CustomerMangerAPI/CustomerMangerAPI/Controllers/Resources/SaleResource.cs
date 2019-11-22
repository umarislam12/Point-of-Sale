using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMangerAPI.Controllers.Resources
{
    public class SaleResource
    {
    
        public int saleId { get; set; }
        public string saleDate { get; set; }
        public int saleNo { get; set; }
        public int id { get; set; }
        //Removing inverse relationship to the customer class because we don't wanna loop in our json objects
        public ICollection<int> saleLines { get; set; }
        public SaleResource()
        {
            saleLines = new Collection<int>();
       }
    }
}
