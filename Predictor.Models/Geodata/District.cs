using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predictor.Models.Geodata
{
    public class District
	{
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; } = null!;
        public int Population { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public int RegionId { get; set; }

        [ForeignKey(nameof(RegionId))]
        public Region Region { get; set; } = null!;
        public IEnumerable<City> Cities { get; set; } = null!;

        public District() { }
        public District(int id, string districtName, int population, double? latitude, double? longitude, Region region)
        {
            Id = id;
            Name = districtName;
            Population = population;
            Latitude = latitude;
            Longitude = longitude;
            RegionId = region.Id;
            Region = region;
        }
    }
}
