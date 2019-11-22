using AutoMapper;
using CustomerMangerAPI.Controllers;
using CustomerMangerAPI.Controllers.Resources;
using CustomerMangerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CustomerMangerAPI.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //Domain to API Resources
            CreateMap<product, ProductResource>();
            CreateMap<SaleLine, SaleLineResource>();
           
            CreateMap<Customer, CustomerResource>();
            CreateMap<Sale, SaleResource>()
                .ForMember(sr => sr.saleLines, opt => opt.MapFrom(s => s.saleLines.Select(sl=>sl.productId  )));
            //Api Resources to domain
            CreateMap<SaleResource, Sale>()
                .ForMember(s => s.saleLines, opt => opt.MapFrom(sr => sr.saleLines.Select(id => new SaleLine {productId=id })));

        }

    }
}
