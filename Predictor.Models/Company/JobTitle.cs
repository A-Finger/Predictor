using Predictor.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predictor.Models.Company
{
    public class JobTitle : IUpperId
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; } = null!;
        public int DepartmentId { get; set; }
        public int UpperId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public Department Department { get; set; } = null!;
        [ForeignKey(nameof(UpperId))]
        public JobTitle Head { get; set; } = null!;
        public IEnumerable<User> Users { get; set; } = null!;
        public IEnumerable<JobTitle> JobTitles { get; set; } = null!;

        public JobTitle() { }
        public JobTitle(int id, string title, Department department, JobTitle head)
        {
            Id = id;
            Name = title;
            DepartmentId = department.Id;
            Department = department;
            UpperId = head.Id;
            Head = head;
        }

    }
}
