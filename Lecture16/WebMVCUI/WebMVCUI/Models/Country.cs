using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVCUI.Models
{
    public class Country
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public String Name { get; set; }
        public virtual List<City> Cities { get; set; }

    }
}