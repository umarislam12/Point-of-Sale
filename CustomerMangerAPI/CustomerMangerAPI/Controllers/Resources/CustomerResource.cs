using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMangerAPI.Controllers.Resources
{
    public class CustomerResource
    {
        public int id { get; set; }
        

        public string name { get; set; }
        
        public string gender { get; set; }
        

        public string dateOfBirth { get; set; }


        public Boolean isActive { get; set; }
        public virtual ICollection<SaleResource> Sales { get; set; }
        public CustomerResource()
        {
            Sales = new Collection<SaleResource>();
        }
    }
}
