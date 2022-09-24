using System.ComponentModel.DataAnnotations;

namespace Predictor.Models.Company
{
    public class LocationType
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Type { get; set; } = null!;

        public IEnumerable<Store> Stores { get; set; } = null!;
    }
}
