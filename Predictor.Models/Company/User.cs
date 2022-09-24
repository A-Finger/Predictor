using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predictor.Models.Company
{
    [Index(nameof(Login), IsUnique = true)]
    public class User
    {
        public int Id { get; set; }
        [Required, MaxLength(30)]
        public string Login { get; set; } = null!;
        [Required, MaxLength(50)]
        public string FirstName { get; set; } = null!;
        [MaxLength(50)]
        public string? MidleName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; } = null!;
        [MaxLength(20)]
        public string? Phone { get; set; }
        [MaxLength(100)]
        public string? Email { get; set; }
        [Required, MaxLength(16)]
        public string Password { get; set; } = null!;
        public bool IsLockConfirmed { get; set; }
        public bool IsFired { get; set; }
        public int JobTitleId { get; set; }
        public int UserRoleId { get; set; }
        public int LeaderId { get; set; }

        [ForeignKey(nameof(LeaderId))]
        public User Leader { get; set; } = null!;
        [ForeignKey(nameof(UserRoleId))]
        public UserRole UserRole { get; set; } = null!;
        [ForeignKey(nameof(JobTitleId))]
        public JobTitle JobTitle { get; set; } = null!;
        public IEnumerable<User> Users { get; set; } = null!;

        public User() { }
        public User(int id, string login, string firstName, string? midleName, string lastName, string? phone, string? email, string password, bool lockConfirmed, User leader, UserRole userRole, JobTitle jobTitle)
        {
            Id = id;
            Login = login;
            FirstName = firstName;
            MidleName = midleName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Password = password;
            IsLockConfirmed = lockConfirmed;
            JobTitleId = jobTitle.Id;
            UserRoleId = userRole.Id;
            LeaderId = leader.Id;
            Leader = leader;
            UserRole = userRole;
            JobTitle = jobTitle;
        }
    }
}
