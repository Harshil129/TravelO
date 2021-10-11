using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelO.Models
{
    public class Province
    {
        //A public class which holds the public variables and the validations
        [Key]
        [Display (Name="Province ID")]
        [Required(AllowEmptyStrings = false)]
        public int ProvinceID { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Province Name")]
        [MaxLength(100)]
        public String Name { get; set; }

        //Providing the parent-child and child-parent relationship between classes
        public List<Place> Places { get; set; }
    }
}
