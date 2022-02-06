using Microsoft.AspNetCore.Mvc;
using RIMOTECH.Models;
using RIMOTECH.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RIMOTECH.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MoviesstoreController : ControllerBase
    {
        private IMoviestoreservice _moviestoreservice;

        private DBCONTEXT _dBCONTEXT;

        public MoviesstoreController(
            IMoviestoreservice moviestoreservice, DBCONTEXT dBCONTEXT
            )
        {
            _moviestoreservice = moviestoreservice;
            _dBCONTEXT = dBCONTEXT;
        }

        [HttpGet("{id}")]
        public IEnumerable<Moviestore> Getstoresbycountry(int countrycode)
        {
            var stores = new List<Moviestore>();
            if (countrycode != 0)
            {
                stores = _moviestoreservice.Get(countrycode);
            }

            return (IEnumerable<Moviestore>)Ok(stores);
        }



















        // GET: api/<MoviesstoreController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MoviesstoreController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MoviesstoreController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MoviesstoreController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MoviesstoreController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }



    }
}
