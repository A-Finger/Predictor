using Predictor.Models.Company;
using Predictor.Services.Interfaces;

namespace Predictor.Services.Repositories
{
    public class MockAccountService : IUserAccess
    {
        private readonly List<UserRole> userRoles;
        private readonly List<JobTitle> jobTitles;
        private readonly List<Department> departments;
        private readonly List<User> _users;
        //Constructor
        public MockAccountService()
        {
            userRoles = new()
            {
                new UserRole(1,"Superadmin"),
                new UserRole(2,"Admin"),
                new UserRole(3,"User")
            };
            departments = new()
            {
                new Department(1,"Генеральний директор"),
                new Department(2,"Відділ продажу"),
                new Department(3,"Відділ розвитку"),
                new Department(4,"Відділ з аналітики")
            };
            jobTitles = new()
            {
                new JobTitle(1, "Генеральний директор", departments[0]),//#0
                new JobTitle(2, "Начальник відділку", departments[1]),//#1
                new JobTitle(3, "Менеджер з продажу", departments[1]),//#2
                new JobTitle(4, "Асистент менеджера", departments[1]),//#3
                new JobTitle(5, "Начальник відділу розвитку", departments[2]),//#4
                new JobTitle(6, "Менеджер з розвитку", departments[2]),//#5
                new JobTitle(7, "Юрист", departments[2]),//#6
                new JobTitle(8, "Начальник відділу з аналітики", departments[3]),//#7
                new JobTitle(9, "Провідний аналітик", departments[3]),//#8
                new JobTitle(10, "Математик-програміст", departments[3]),//#9
            };
            _users = new()
            {
                new User(1, "Superadmin", "Супер", "Пупер", "Одмін",
                "+380503200001", "superadmin@admin.com", "superadmin", false,
               new User(), userRoles[0], jobTitles[0])
            };
            #region Відділ продажу
            //index #1 _users[1]
            _users.Add(new User(2, "Admin1", "Іван1", "Іванович", "Іванов",
                "+380503200002", "admin@admin.com", "admin", false,
               _users[0], userRoles[1], jobTitles[1]));
            //index #2 _users[2]
            _users.Add(new User(3, "User1", "Петро1", "Петрович", "Петров",
                "+380503200003", "user@user.com", "user", false,
               _users[1], userRoles[2], jobTitles[2]));
            //index #3 _users[3]
            _users.Add(new User(4, "User2", "Антон1", "Антонович", "Антоненко",
                "+380503200004", "user@user.com", "user", false,
               _users[1], userRoles[2], jobTitles[2]));
            //index #4 _users[4]
            _users.Add(new User(5, "User3", "Андрій1", "Андрійович", "Андрійченко",
                "+380503200005", "user@user.com", "user", false,
               _users[1], userRoles[2], jobTitles[3]));
            #endregion
            #region Відділ розвитку
            //index #5 _users[5]
            _users.Add(new User(6, "Admin2", "Іван2", "Іванович", "Іванов",
                "+380503200006", "admin@admin.com", "admin", false,
               _users[0], userRoles[1], jobTitles[4]));
            //index #6 _users[6]
            _users.Add(new User(7, "User4", "Петро2", "Петрович", "Петров",
                "+380503200007", "user@user.com", "user", false,
               _users[5], userRoles[2], jobTitles[5]));
            //index #7 _users[7]
            _users.Add(new User(8, "User5", "Антон2", "Антонович", "Антоненко",
                "+380503200008", "user@user.com", "user", false,
               _users[5], userRoles[2], jobTitles[5]));
            //index #8 _users[8]
            _users.Add(new User(9, "User6", "Андрій2", "Андрійович", "Андрійченко",
                "+380503200009", "user@user.com", "user", false,
               _users[5], userRoles[2], jobTitles[6]));
            #endregion
            #region Відділ з аналітики
            //index #9 _users[9]
            _users.Add(new User(10, "Admin3", "Іван3", "Іванович", "Іванов",
                "+380503200006", "admin@admin.com", "admin", false,
               _users[0], userRoles[1], jobTitles[7]));
            //index #10 _users[10]
            _users.Add(new User(11, "User7", "Петро3", "Петрович", "Петров",
                "+380503200007", "user@user.com", "user", false,
               _users[9], userRoles[2], jobTitles[8]));
            //index #11 _users[11]
            _users.Add(new User(12, "User8", "Антон3", "Антонович", "Антоненко",
                "+380503200008", "user@user.com", "user", false,
               _users[9], userRoles[2], jobTitles[8]));
            //index #12 _users[12]
            _users.Add(new User(13, "User9", "Андрій3", "Андрійович", "Андрійченко",
                "+380503200009", "user@user.com", "user", false,
               _users[9], userRoles[2], jobTitles[9]));
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
    }
}
