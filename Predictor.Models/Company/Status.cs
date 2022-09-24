using System.ComponentModel.DataAnnotations;

namespace Predictor.Models.Company
{
    public class Status
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string State { get; set; } = null!;

        public IEnumerable<Store> Stores { get; set; } = null!;
    }
}
