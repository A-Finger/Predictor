using Predictor.Models.Company;

namespace Predictor.Services.Interfaces
{
    public interface IUserAccess
    {
        public Task<User?> GetByLoginAsync(string login);
        public Task<IEnumerable<User>> GetAllUsersAsync();
    }
}
