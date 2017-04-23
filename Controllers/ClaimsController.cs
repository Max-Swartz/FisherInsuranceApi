using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FisherInsuranceApi.Controllers
{
    [Route("api/claims/claims")]
    public class ClaimsController : Controller
    {
            // GET: /<controller>/
            public IActionResult Index()
            {
                return View();
            }
            // POST api/claims/claims
            [HttpPost]
            public IActionResult Post([FromBody]string value)
            {
                return Created("", value);
            }
            // GET api/claims/claims/5
            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                return Ok("the id is: " + id);
            }
            //PUT api/claims/claims/id
            [HttpPut("{id}")]
            public IActionResult put(int id, [FromBody]string value)
            {
                return NoContent();
            }
            //DELETE api/claims/claims/id
            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                return Ok();
            }
        }
    }
}
