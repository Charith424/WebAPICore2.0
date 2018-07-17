using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi.Core2.Controllers
{
    [Produces("application/json")]
    [Route("api/Cities")]
    public class CitiesController:Controller
    {
        [HttpGet()]
        public IActionResult GetCities()
        {
            var Cities = CitiesDataStore.current.Cities;
            if (Cities == null) {
                return NotFound();
            }
            return Ok(CitiesDataStore.current.Cities);
        //    return new JsonResult(new List<object>()
        //    {
        //       new{id=1,Name="Colombo"},
        //       new{id=2,Name="Kandy"}

        //});

        }

        [HttpGet("{id}")]
        public IActionResult getCity(int id)
        {
            var City = CitiesDataStore.current.Cities.FirstOrDefault(c => c.Id == id);
            if(City== null)
            {
                return NotFound();
            }

            return Ok(City);
        

        }


    }
}
