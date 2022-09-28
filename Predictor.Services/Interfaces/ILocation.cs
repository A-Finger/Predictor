using Predictor.Models.Geodata;

namespace Predictor.Services.Interfaces
{
    public interface ILocation
    {
        Task<List<District>> GetAllDistrictAsync();
        Task<List<Region>> GetAllRegionsAsync();
        Task<List<City>> GetAllCitiesAsync();
    }
}
