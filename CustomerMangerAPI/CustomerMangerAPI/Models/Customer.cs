using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMangerAPI.Models
{
   
    public class Customer
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        
        public string name { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string gender { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]//10/10/2019

        public string dateOfBirth { get; set; }
      
        
        public Boolean isActive { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public Customer()
        {
            Sales = new Collection<Sale>();
        }
            //foreign key
            //  public int saleId { get; set; }

            // [ForeignKey("saleId")]
            //public Sale Sale { get; set; }
        }
    //base class for SaleLine
   
    public class Sale
    {
        [Key]
        public int saleId { get; set; }
         public string saleDate { get; set; }
        public int saleNo { get; set; }
     public Customer Customer { get; set; }
        //customerID
        public int id { get; set; }
       
        /// public virtual ICollection<Customer> customers{ get; set; }
        public ICollection<SaleLine> saleLines { get; set; }
      public Sale()
       {
            saleLines = new Collection<SaleLine>();
      }
    }
    
    public class SaleLine
    {
       // [Key]
      //  public int saleLineId { get; set; }
        public int quantity { get; set; }
       // public int unitPrice { get; set; }
        public int totalQuantity { get; set; }
        
        //foreign key Sale


        public Sale Sale { get; set; }
        public int saleId { get; set; }

        //foreign key for product
       
       
        public product product { get; set; }
        public int productId { get; set; }

    }
    //base class for SaleLine
   
    public class product
    {
        [Key]
        public int productId { get; set; }
        public string productName { get; set; }
       public int productCode { get; set; }
        public int unitPrice { get; set; }
        public virtual ICollection<SaleLine> SaleLines { get; set; }
        public product() {
            SaleLines = new Collection<SaleLine>();
        }
       
    }

}
