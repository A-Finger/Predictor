using System.ComponentModel.DataAnnotations;

namespace Predictor.Models.Company
{
    public class UserRole
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Value { get; set; } = null!;

        public UserRole() { }
        public UserRole(int id, string userRole)
        {
            Id = id;
            Value = userRole;
        }

        public IEnumerable<User> Users { get; set; } = null!;
    }
}