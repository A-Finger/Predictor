using Predictor.Models.Company;
using Predictor.Services.Interfaces;

namespace Predictor.Services.Repositories
{
    public class MockAccountService : IUserAccess
    {
        private readonly List<UserRole> _userRoles;
        private readonly List<JobTitle> _jobTitles;
        private readonly List<Department> _departments;
        private readonly List<User> _users;
        //Constructor
        public MockAccountService()
        {
            _userRoles = new()
            {
                new UserRole(1,"Superadmin"),
                new UserRole(2,"Admin"),
                new UserRole(3,"User")
            };
            _departments = new()
            {
                new Department(1,"Головне управління", new Department()),
            };
            _departments.Add(new Department(2, "Департамент операційного управління", _departments[0]));//1
            _departments.Add(new Department(3, "Департамент маркетингу", _departments[0]));//2
            _departments.Add(new Department(4, "Відділ продажу", _departments[1]));//3
            _departments.Add(new Department(5, "Відділ розвитку", _departments[1]));//4
            _departments.Add(new Department(6, "Відділ з аналітики", _departments[1]));//5
            _departments.Add(new Department(7, "Відділ інтернет-маркетингу", _departments[2]));//6
            _jobTitles = new()
            {
                new JobTitle(1, "Генеральний директор", _departments[0], new JobTitle()),//0
            };
            _jobTitles.Add(new JobTitle(2, "Операційний директор", _departments[1],_jobTitles[0]));//1
            _jobTitles.Add(new JobTitle(3, "Директор з маркетингу", _departments[2], _jobTitles[0]));//2
            _jobTitles.Add(new JobTitle(4, "Начальник відділу", _departments[3], _jobTitles[1]));//3
            _jobTitles.Add(new JobTitle(5, "Начальник відділу", _departments[4], _jobTitles[1]));//4
            _jobTitles.Add(new JobTitle(6, "Начальник відділу", _departments[5], _jobTitles[1]));//5
            _jobTitles.Add(new JobTitle(7, "Начальник відділу", _departments[6], _jobTitles[2]));//6
            _jobTitles.Add(new JobTitle(8, "Аналітик", _departments[5], _jobTitles[5]));//7
            _jobTitles.Add(new JobTitle(9, "Математик-програміст", _departments[5], _jobTitles[5]));//8
            _jobTitles.Add(new JobTitle(10, "Асисстент", _departments[5], _jobTitles[5]));//9
            _jobTitles.Add(new JobTitle(11, "Аналітик", _departments[6], _jobTitles[6]));//10
            _jobTitles.Add(new JobTitle(12, "SMM фахівець", _departments[6], _jobTitles[6]));//11
            _jobTitles.Add(new JobTitle(13, "Менеджер з розвитку", _departments[4], _jobTitles[4]));//12
            _jobTitles.Add(new JobTitle(14, "Юрист", _departments[4], _jobTitles[4]));//13
            _jobTitles.Add(new JobTitle(15, "Провідний менеджер з розвитку", _departments[4], _jobTitles[4]));//14
            _jobTitles.Add(new JobTitle(16, "Асистент директора", _departments[3], _jobTitles[3]));//15
            _jobTitles.Add(new JobTitle(16, "Фахівець з інформації", _departments[3], _jobTitles[3]));//15

            _users = new()
            {
                new User(1, "Superadmin", "Марк", "Ісаакович", "Гольцман",
                "+380503200001", "superadmin@admin.com", "superadmin", false,
                _userRoles[0], _jobTitles[0])
            };
            #region Відділ продажу
            //index #1 _users[1]
            _users.Add(new User(2, "Admin1", "Іван1", "Іванович", "Іванов",
                "+380503200002", "admin@admin.com", "admin", false,
                _userRoles[1], _jobTitles[1]));
            //index #2 _users[2]
            _users.Add(new User(3, "User1", "Петро1", "Петрович", "Петров",
                "+380503200003", "user@user.com", "user", false,
                _userRoles[2], _jobTitles[2]));
            //index #3 _users[3]
            _users.Add(new User(4, "User2", "Антон1", "Антонович", "Антоненко",
                "+380503200004", "user@user.com", "user", false,
                _userRoles[2], _jobTitles[2]));
            //index #4 _users[4]
            _users.Add(new User(5, "User3", "Андрій1", "Андрійович", "Андрійченко",
                "+380503200005", "user@user.com", "user", false,
                _userRoles[2], _jobTitles[3]));
            #endregion
            #region Відділ розвитку
            //index #5 _users[5]
            _users.Add(new User(6, "Admin2", "Іван2", "Іванович", "Іванов",
                "+380503200006", "admin@admin.com", "admin", false,
                _userRoles[1], _jobTitles[4]));
            //index #6 _users[6]
            _users.Add(new User(7, "User4", "Петро2", "Петрович", "Петров",
                "+380503200007", "user@user.com", "user", false,
                _userRoles[2], _jobTitles[5]));
            //index #7 _users[7]
            _users.Add(new User(8, "User5", "Антон2", "Антонович", "Антоненко",
                "+380503200008", "user@user.com", "user", false,
                _userRoles[2], _jobTitles[5]));
            //index #8 _users[8]
            _users.Add(new User(9, "User6", "Андрій2", "Андрійович", "Андрійченко",
                "+380503200009", "user@user.com", "user", false,
                _userRoles[2], _jobTitles[6]));
            #endregion
            #region Відділ з аналітики
            //index #9 _users[9]
            _users.Add(new User(10, "Admin3", "Іван3", "Іванович", "Іванов",
                "+380503200006", "admin@admin.com", "admin", false,
                _userRoles[1], _jobTitles[7]));
            //index #10 _users[10]
            _users.Add(new User(11, "User7", "Петро3", "Петрович", "Петров",
                "+380503200007", "user@user.com", "user", false,
                _userRoles[2], _jobTitles[8]));
            //index #11 _users[11]
            _users.Add(new User(12, "User8", "Антон3", "Антонович", "Антоненко",
                "+380503200008", "user@user.com", "user", false,
                _userRoles[2], _jobTitles[8]));
            //index #12 _users[12]
            _users.Add(new User(13, "User9", "Андрій3", "Андрійович", "Андрійченко",
                "+380503200009", "user@user.com", "user", false,
                _userRoles[2], _jobTitles[9]));
            #endregion
        }
        public async Task<User?> GetByLoginAsync(string login)
        {
            return await Task.Run(
                () => _users.FirstOrDefault(x => x.Login == login)
            );
        }
        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await Task.Run(() => _users);
        }
        public async Task AddUserAsync(User user)
        {
            await Task.Run(() => _users.Add(user));
        }
        public async Task<IEnumerable<Department>> GetDepartmentsAsync()
        {
            return await Task.Run(() => _departments);
        }

        public async Task<IEnumerable<JobTitle>> GetJobTitlesAsync(Department department)
        {
            return await Task.Run(() => _jobTitles.FindAll(x => x.Department == department));
        }

        public async Task<IEnumerable<JobTitle>> GetJobTitlesAsync()
        {
            return await Task.Run(() => _jobTitles);
        }

        public async Task<IEnumerable<UserRole>> GetUserRolesAsync()
        {
            return await Task.Run(() => _userRoles);
        }

        public async Task<bool> TryAddUserAsync(User user)
        {
            return await Task.Run(() =>
            {
                _users.Add(user);
                return true;
            });
        }

        public async Task DeleteUserAsync(int id)
        {
            await Task.Run(() =>
            {
                var user = _users.FirstOrDefault(x => x.Id == id);
                if (user is not null)
                    _users.Remove(user);
            });
        }
    }
}
