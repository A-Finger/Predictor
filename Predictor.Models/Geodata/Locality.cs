namespace Predictor.Models.Geodata
{
    public class Locality
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public IEnumerable<City> Cities { get; set; } = null!;
    }
}
