using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi.Core2.Models
{
    public class CitieDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NumberOfPointsOfInterested
        {
            get
            {
                return pointofInterest.Count;
            }
        }

        public ICollection<PointOfInterestDTO> pointofInterest { get; } = new List<PointOfInterestDTO>() {
            new PointOfInterestDTO
                {
                    Id = 1,
                    Name = "Colombo Int",
                    Description = "Colombo Area",
                },
                new PointOfInterestDTO
                {
                    Id = 2,
                    Name = "Kandy Int",
                    Description = "Kandy Area",
                },
                 new PointOfInterestDTO
                 {
                     Id = 3,
                     Name = "Maharagama Int",
                     Description = "Maharagama Area",
                 }
        };
    }
}
