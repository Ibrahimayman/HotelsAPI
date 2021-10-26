using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CreateCountryDto
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country name is too long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Short country name is too long")]
        public string ShortName { get; set; }
    }


    public class CountryDto : CreateCountryDto
    {
        public int Id { get; set; }

        public  IList<HotelDto> Hotels { get; set; }
    }

}
