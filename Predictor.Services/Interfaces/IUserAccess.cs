using Predictor.Models.Company;

namespace Predictor.Services.Interfaces
{
    public interface IUserAccess
    {
        public Task<User?> GetByLoginAsync(string login);
        public Task<IEnumerable<User>> GetAllUsersAsync();
        public Task AddUserAsync(User user);
        public Task<IEnumerable<Department>> GetDepartmentsAsync();
        public Task<IEnumerable<JobTitle>> GetJobTitlesAsync(Department department);
        public Task<IEnumerable<JobTitle>> GetJobTitlesAsync();
        public Task<IEnumerable<UserRole>> GetUserRolesAsync();
        public Task<bool> TryAddUserAsync(User user);
        public Task DeleteUserAsync(int id);
    }
}
