using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predictor.Models.Geodata
{
    public class City
	{
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; } = null!;
        public int Population { get; set; }
        public int LocalityId { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public int DistrictId { get; set; }

        [ForeignKey(nameof(DistrictId))]
        public District District { get; set; } = null!;
        [ForeignKey(nameof(LocalityId))]
        public Locality Locality { get; set; } = null!;

        public City() { }
        public City(int id, string cityName, int population, double? latitude, double? longitude, District district, Locality typeOfLocality)
        {
            Id = id;
            Name = cityName;
            Population = population;
            Longitude = longitude;
            Latitude = latitude;
            DistrictId = district.Id;
            District = district;
            LocalityId = typeOfLocality.Id;
            Locality = typeOfLocality;
        }
    }
}
