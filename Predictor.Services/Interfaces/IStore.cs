using Predictor.Models.Company;
using Predictor.Models.Geodata;

namespace Predictor.Services.Interfaces
{
    public interface IStore
    {
        public Task<IEnumerable<Store>> GetAllStoresAsync();
        public Task<Store> GetStoreAsync(int id);
        public Task<IEnumerable<Store>> GetStoresBy(City city);
        public Task<IEnumerable<Store>> GetStoresBy(District city);
        public Task<IEnumerable<Store>> GetStoresBy(Region city);
    }
}
