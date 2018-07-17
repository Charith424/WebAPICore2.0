using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi.Core2.Models
{
    public class PointOfInterestCreationDTO
    {
        [Required(ErrorMessage ="You should provide a name")]
        [MaxLength(50)]
        public String Name { get; set; }
        [MaxLength(200)]
        public String Description { get; set; }
    }
}
