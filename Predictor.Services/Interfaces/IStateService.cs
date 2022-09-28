using Predictor.Models.Geodata;

namespace Predictor.Services.Interfaces
{
    public interface IStateService
    {
        public Region Region { get; set; }
        public District District { get; set; }
        public City City { get; set; }
        public Locality Locality { get; set; }

        public List<Region> Regions { get; set; }
        public List<District> Districts { get; set; }
        public List<City> Cities { get; set; }
        public List<Locality> Localities { get; set; }

        public event Action? OnChange;
    }
}
