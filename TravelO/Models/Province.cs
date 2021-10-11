using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelO.Models
{
    public class Province
    {
        [Range(1,70)]
        [Display (Name="Province ID")]
        [Required(AllowEmptyStrings = false)]
        public int ProvinceID { get; set; }

        [Required(AllowEmptyStrings = false)]
        public String Name { get; set; }
    }
}
