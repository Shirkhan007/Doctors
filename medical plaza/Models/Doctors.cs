using System.ComponentModel.DataAnnotations;

namespace medical_plaza.Models
{
    public class Doctors
    {
        public  int Id { get; set; }
        public string? ImageUrl { get; set; }
        [Required (ErrorMessage ="Duzgun daxil edin:")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
