using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class Calculation
    {
        public long Id { get; set; }
        [Required]
        public long Number { get; set; }
        [Required]
        public string? Name { get; set; }
        
    }
}