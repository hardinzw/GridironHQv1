using System.ComponentModel.DataAnnotations;

namespace GridironHQv1.Entities
{
    public class Stadium
    {
        public int? Capacity { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public decimal? GeoLat { get; set; }
        public decimal? GeoLong { get; set; }
        public string? Name { get; set; }
        public string? PlayingSurface { get; set; }
        [Required]
        public int StadiumID { get; set; }
        public string? State { get; set; }
        public string? Type { get; set; }
    }
}
