using System.ComponentModel.DataAnnotations;

namespace Predictor.Models.Company
{
    public class Format
    {
        public int Id { get; set; }
        [Required, MaxLength(30)]
        public string Name { get; set; } = null!;

        public IEnumerable<Store> Stores { get; set; } = null!;
    }
}
