using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PassengerManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        // GET: api/<PassengersController>
        [HttpGet]
        // public IEnumerable<string> Get()
        //{
        //  return new string[] { "value1", "value2" };
        //}
        public IEnumerable<PassengerModel> Get()
        {
            PassengerModel passengermodel1 = new PassengerModel();
            PassengerModel passengermodel2 = new PassengerModel();



            passengermodel1.PId = 1;
            passengermodel1.PassengerName = "Sam";
            passengermodel1.PAdd = "Chennai";

            passengermodel2.PId = 2;
            passengermodel2.PassengerName = "John";
            passengermodel2.PAdd = "Bangalore";

            List<PassengerModel> passengerlist = new List<PassengerModel>();
            passengerlist.Add(passengermodel1);
            passengerlist.Add(passengermodel2);


            return passengerlist;
        }



    
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<ProductsController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<ProductsController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ProductsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
}

    