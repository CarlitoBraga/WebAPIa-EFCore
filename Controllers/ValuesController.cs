using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPISqlite.Data;

namespace WebAPISqlite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public DataContext Data { get; }

        public ValuesController(DataContext data)
        {
            Data = data;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            
            try{
               var results = await Data.Produtos.ToListAsync();
               return  Ok(results);
            }
            catch(System.Exception)
            {
              return BadRequest();
            }
            
        }

        // GET api/values/"id"
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var results = await Data.Produtos.ToListAsync();
            return Ok(results.FirstOrDefault(x => x.ProdutosId == id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
