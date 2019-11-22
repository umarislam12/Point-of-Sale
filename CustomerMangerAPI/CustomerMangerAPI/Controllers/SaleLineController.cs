using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CustomerMangerAPI.Controllers.Resources;
using CustomerMangerAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace CustomerMangerAPI.Controllers
//{
//    [Route("api/[controller]")]
    //public class SaleLineController : Controller
    //{
        //private readonly CustomerContext _context;

        //public readonly IMapper mapper;
        //public SaleLineController(CustomerContext context, IMapper mapper)
        //{
            //_context = context;
          //  this.mapper = mapper;
        //}

        // GET: api/SaleLine
        //[HttpGet]
       //public async Task<ActionResult<IEnumerable<SaleLineResource>>> GetSaleLineList()
       //{
           //var products = await _context.SaleLine.Include(p => p.product).ToListAsync();
        //.Include(s => s.saleLineId).ToListAsync();
         //  return mapper.Map<List<SaleLine>, List<SaleLineResource>>(products);
       // }

        // GET: api/saleLine/5
       // [HttpGet("{saleLineId}")]
        //public async Task<ActionResult<SaleLine>> GetProduct(int saleLineId)
        //{
          //  var saleline = await _context.SaleLine.FindAsync(saleLineId);

//            if (saleline == null)
  //          {
    //            return NotFound();
      //      }
        //    {
          //      return saleline;
            //}
        //}


        // POST: api/saleLine
//        [HttpPost]
      //  public async Task<ActionResult<SaleLine>> PostProduct(SaleLine saleline)
        //{
          //  _context.SaleLine.Add(saleline);
           // await _context.SaveChangesAsync();

            //return CreatedAtAction("GetProductList", new { id = saleline.saleLineId }, saleline);
        //}


        // PUT: api/SaleLine/5
  //      [HttpPut("{saleLineId}")]
    //    public async Task<IActionResult> PutSaleLine(int salelineid, SaleLine saleline)
      //  {
        //    if (salelineid!= saleline.saleLineId)
          //  {
            //    return BadRequest();
            //}

            //_context.Entry(saleline).State = EntityState.Modified;

            //try
            //{
              //  await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
              //  if (!saleLineExists(salelineid))
                //{
                  //  return NotFound();
                //}
                //else
                //{
                  //  throw;
                //}
            //}

            //return NoContent();
       // }


        // DELETE: api/SaleLine/5
     //   [HttpDelete("{saleLineId}")]
        //public async Task<ActionResult<SaleLine>> DeleteProduct(int saleLineId)
        //{
          //  var saleline = await _context.SaleLine.FindAsync(saleLineId);
            //if (saleline == null)
            //{
              //  return NotFound();
            //}

//            _context.SaleLine.Remove(saleline);
  //          await _context.SaveChangesAsync();

    //        return saleline;
      //  }
        //private bool saleLineExists(int saleLineId)
        //{
          //  return _context.SaleLine.Any(e => e.saleLineId == saleLineId);
        //}
    //}
//}
