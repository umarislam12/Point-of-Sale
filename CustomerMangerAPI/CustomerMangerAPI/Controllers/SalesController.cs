using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CustomerMangerAPI.Models;
using AutoMapper;
using CustomerMangerAPI.Controllers.Resources;

namespace CustomerMangerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly CustomerContext _context;
        private readonly IMapper mapper;

        public SalesController(CustomerContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: api/Sales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SaleResource>>> GetSale()
        {
            var sale= await _context.Sale.Include(s => s.saleLines).ToListAsync();
            return mapper.Map<List<Sale>, List<SaleResource>>(sale);
        }

        // GET: api/Sales/5
        [HttpGet("{id}")]
         public async Task<ActionResult<Sale>> GetSale(int id)
        {
            var sale = await _context.Sale.FindAsync(id);

            if (sale == null)
            {
                return NotFound();
            }

            return sale;
        }

        // PUT: api/Sales/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSale(int id, Sale sale)
        {
            if (id != sale.saleId)
            {
                return BadRequest();
            }

            _context.Entry(sale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Sales
        [HttpPost]
        public async Task<IActionResult> PostSale([FromBody]SaleResource saleResource)
        {
         
           var sale= mapper.Map<SaleResource, Sale>(saleResource);
            _context.Sale.Add(sale);
            await _context.SaveChangesAsync();
            var result = mapper.Map<Sale, SaleResource>(sale);
            return Ok(result);

            //_context.Sale.Add(sale);
            //await _context.SaveChangesAsync();

           // return CreatedAtAction("GetSale", new { id = sale.saleId }, sale);
        }

        // DELETE: api/Sales/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Sale>> DeleteSale(int id)
        {
            var sale = await _context.Sale.FindAsync(id);
            if (sale == null)
            {
                return NotFound();
            }

            _context.Sale.Remove(sale);
            await _context.SaveChangesAsync();

            return sale;
        }

        private bool SaleExists(int id)
        {
            return _context.Sale.Any(e => e.saleId == id);
        }
    }
}
