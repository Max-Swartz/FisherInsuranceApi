using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FisherInsuranceApi.Controllers
{
    [Route("api/life/quotes")]
    public class LifeController : Controller
    {
            // GET: /<controller>/
            public IActionResult Index()
            {
                return View();
            }
            // POST api/life/quotes
            [HttpPost]
            public IActionResult Post([FromBody]string value)
            {
                return Created("", value);
            }
            // GET api/life/quotes/5
            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                return Ok("the id is: " + id);
            }
            //PUT api/life/qoutes/id
            [HttpPut("{id}")]
            public IActionResult put(int id, [FromBody]string value)
            {
                return NoContent();
            }
            //DELETE api/life/quotes/id
            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                return Ok();
            }
        
    }
}
