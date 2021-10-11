using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelO.Models
{
    public class Province
    {
        [Key]
        [Range(1,70)]
        [Display (Name="Province ID")]
        [Required(AllowEmptyStrings = false)]
        public int ProvinceID { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Province Name")]
        public String Name { get; set; }

        public List<Place> Places { get; set; }
    }
}
