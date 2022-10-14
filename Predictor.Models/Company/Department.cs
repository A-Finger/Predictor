using Predictor.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predictor.Models.Company
{
    public class Department : IUpperId
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; } = null!;
        public int UpperId { get; set; }
        [ForeignKey(nameof(UpperId))]
        public Department OverDepartment { get; set; } = null!;
        public IEnumerable<JobTitle> JobTitles { get; set; } = null!;
        public IEnumerable<Department> Departments { get; set; } = null!;
        public Department() { }
        public Department(int id, string name, Department overDepartment)
        {
            Id = id;
            Name = name;
            UpperId = overDepartment.Id;
            OverDepartment = overDepartment;
        }
    }
}
