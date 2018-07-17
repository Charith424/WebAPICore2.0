using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using WepApi.Core2.Models;

namespace WepApi.Core2.Controllers
{
    [Produces("application/json")]
    [Route("api/Cities")]
    public class PointOfInterestController:Controller
    {
        [HttpGet("{cityId}/PoindOfInterest")]
        public IActionResult getPoindOfInterest(int cityId) {
            var city = CitiesDataStore.current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            {
                return NotFound();

            }
            return Ok(city.pointofInterest);
        }

        [HttpGet("{cityId}/PoindOfInterest/{id}")]
        public IActionResult getPoindOfInterest(int cityId,int id)
        {
            var city = CitiesDataStore.current.Cities.FirstOrDefault(c => c.Id == cityId);
            if (city == null)
            {
                return NotFound();

            }
            if (city.NumberOfPointsOfInterested == 0 )
            {
                return NotFound();

            }
            return Ok(city.pointofInterest);
        }
       
        [HttpPost("{{cityId}/PoindOfInterest/}")]
        public IActionResult CreatePointOfInterest(int cityId,[FromBody] PointOfInterestCreationDTO pointofInterest)
        {
            if (pointofInterest == null)
            {
                return BadRequest();
            }
            var city = CitiesDataStore.current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (city == null)
            {
                return NotFound();
            }
            var MaxPoindOfInterestId = CitiesDataStore.current.Cities.SelectMany(c => c.pointofInterest).Max(p => p.Id);

            var finalPointOfDTO = new PointOfInterestDTO()
            {
                Id = ++MaxPoindOfInterestId,
                Name= pointofInterest.Name,
                Description = pointofInterest.Description

            };
            city.pointofInterest.Add(finalPointOfDTO);
            return Ok(); 
        }
    }
}
