using System.ComponentModel.DataAnnotations;

namespace WebMVCUI.Models
{
    public class City
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public int CountryID { get; set; }
        public virtual Country Country{ get; set; }
    }
}