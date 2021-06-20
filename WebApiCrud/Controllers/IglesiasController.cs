using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCrud.Clases;
using WebApiCrud.Context;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IglesiasController : ControllerBase
    {
        private readonly DatabaseContext Context;
        public IglesiasController(DatabaseContext context)
        {
         this.Context = context;
        }

        // GET: api/<IglesiasController>
        [HttpGet]
        public IEnumerable<Iglesias> Get()
        {
            return Context.iglesias.ToList();
        }

        // GET api/<IglesiasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IglesiasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IglesiasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IglesiasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
