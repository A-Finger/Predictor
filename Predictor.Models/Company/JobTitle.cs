using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predictor.Models.Company
{
    public class JobTitle
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Title { get; set; } = null!;
        public int DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        public Department Department { get; set; } = null!;

        public IEnumerable<User> Users { get; set; } = null!;

        public JobTitle() { }
        public JobTitle(int id, string title, Department department)
        {
            Id = id;
            Title = title;
            DepartmentId = department.Id;
            Department = department;
        }

    }
}
