using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApi.Core2.Models;

namespace WepApi.Core2
{
    public class CitiesDataStore
    {
        public static CitiesDataStore current { get; } = new CitiesDataStore();
        public List<CitieDTO> Cities { get; set; }
        public CitiesDataStore()
        {
            
            //init Cites Data
            Cities = new List<CitieDTO>()
            {
                new CitieDTO
                {
                    Id=1,
                    Name = "Colombo",
                    Description ="Colombo Area",
                },
                new CitieDTO
                {
                    Id=2,
                    Name = "Kandy",
                    Description ="Kandy Area",
                },
                 new CitieDTO
                {
                    Id=3,
                    Name = "Maharagama",
                    Description ="Maharagama Area",
                },

            };

        }
    }
}
