using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CustomerMangerAPI.Controllers.Resources;
using CustomerMangerAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomerMangerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly CustomerContext contex;
        private readonly IMapper mapper;

        public ProductsController(CustomerContext contex, IMapper mapper)
        {
            this.contex = contex;
            this.mapper = mapper;
        }

    

        //public IMapper Mapper { get; }

        [HttpGet("/api/Products")]
        public async Task<IEnumerable<ProductResource>> GetProducts()
        {
           var products=  await contex.product.Include(s => s.SaleLines).ToListAsync();
            return mapper.Map<List<product>, List<ProductResource>>(products);
        }
    }
}