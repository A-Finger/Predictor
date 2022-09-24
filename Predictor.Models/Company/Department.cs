using System.ComponentModel.DataAnnotations;

namespace Predictor.Models.Company
{
    public class Department
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; } = null!;
        public IEnumerable<JobTitle> JobTitles { get; set; } = null!;

        public Department() { }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
