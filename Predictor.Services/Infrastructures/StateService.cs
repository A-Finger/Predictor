using Predictor.Models.Geodata;
using Predictor.Services.Interfaces;

namespace Predictor.Services.Infrastructures
{
    public class StateService : IStateService
    {
        private Region _region = null!;
        private District _district = null!;
        private City _city = null!;
        private Locality _locality = null!;

        private List<Region> _regions = null!;
        private List<District> _districts = null!;
        private List<City> _cities = null!;
        private List<Locality> _localities = null!;


        public List<Region> Regions
        {
            get => _regions;
            set
            {
                _regions = value;
                NotifyStateChanged();
            }
        }
        public List<District> Districts
        {
            get => _districts;
            set
            {
                _districts = value;
                NotifyStateChanged();
            }
        }
        public List<City> Cities
        {
            get => _cities;
            set
            {
                _cities = value;
                NotifyStateChanged();
            }
        }
        public List<Locality> Localities
        {
            get => _localities;
            set
            {
                _localities = value;
                NotifyStateChanged();
            }
        }

        public Region Region
        {
            get => _region;
            set
            {
                _region = value;
                NotifyStateChanged();
            }
        }
        public District District
        {
            get => _district;
            set
            {
                _district = value;
                NotifyStateChanged();
            }
        }
        public City City
        {
            get => _city;
            set
            {
                _city = value;
                NotifyStateChanged();
            }
        }
        public Locality Locality
        {
            get => _locality;
            set
            {
                _locality = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
