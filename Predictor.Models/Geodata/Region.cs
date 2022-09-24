using System.ComponentModel.DataAnnotations;

namespace Predictor.Models.Geodata
{
    public class Region
	{
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; } = null!;
        public int Population { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }

        public IEnumerable<District> Districts { get; set; } = null!;

        public Region() { }
        public Region(int id, string regionName, int population, double? latitude, double? longitude)
        {
            Id = id;
            Name = regionName;
            Population = population;
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}
