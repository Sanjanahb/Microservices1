using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DriversController : ControllerBase
    {
        // GET: api/<ProductsController>
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public IEnumerable<DriverModel> Get()
        {
            DriverModel drivermodel1 = new DriverModel();
            DriverModel drivermodel2 = new DriverModel();

            drivermodel1.DId = 1;
            drivermodel1.DriverName = "Raj";
            drivermodel1.DAdd = "Bangalore";

            drivermodel2.DId = 2;
            drivermodel2.DriverName = "Ram";
            drivermodel2.DAdd = "Pune";




            List<DriverModel> driverlist = new List<DriverModel>();
            driverlist.Add(drivermodel1);
            driverlist.Add(drivermodel2);


            return driverlist;
        }

        // GET api/<ProductsController>/5
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
