using Predictor.Models.Geodata;
using System.ComponentModel.DataAnnotations.Schema;

namespace Predictor.Models.Company
{
    public class Store
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Address { get; set; } = null!;
        public int CityId { get; set; }
        public int StatusId { get; set; }
        public int LocationTypeId { get; set; }
        public int RetailTypeId { get; set; }
        public int RetailBrandId { get; set; }
        public int FormatId { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }

        [ForeignKey(nameof(CityId))]
        public City City { get; set; } = null!;
        [ForeignKey(nameof(StatusId))]
        public Status Status { get; set; } = null!;
        [ForeignKey(nameof(LocationTypeId))]
        public LocationType LocationType { get; set; } = null!;
        [ForeignKey(nameof(RetailTypeId))]
        public RetailType RetailType { get; set; } = null!;
        [ForeignKey(nameof(RetailBrandId))]
        public RetailBrand RetailBrand { get; set; } = null!;
        [ForeignKey(nameof(FormatId))]
        public Format Format { get; set; } = null!;
    }
}
