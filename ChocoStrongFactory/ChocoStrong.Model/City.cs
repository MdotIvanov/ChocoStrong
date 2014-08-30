using System;
using System.ComponentModel.DataAnnotations;

namespace ChocoStrong.Model
{
    public class City
    {
        public int CityId { get; set; }

        [Required]
        public string CityName { get; set; }
    }
}
