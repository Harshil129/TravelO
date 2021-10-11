using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelO.Models
{
    public class Place
    {
        [Key]
        [Required()]
        [Range (0,9999)]
        [Display(Name = "Place ID")]
        public int PlaceID { get; set; }

        public int ProvinceID { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Place Name")]
        public String Name { get; set; }

        [MinLength(10), MaxLength(999)]
        public String Description { get; set; }

        [MinLength(2), MaxLength(999)]
        public String Activities { get; set; }     

        [Required(AllowEmptyStrings = false)]
        [MinLength(2), MaxLength(999)]
        public String Restaurants { get; set; }

        [Required]
        [MinLength(2), MaxLength(50)]
        public String PerfectTimeToVisit { get; set; }

        public String Photo { get; set; }

        public Province Province { get; set; }

        public List<ToDoList> ToDoLists { get; set; }

        public List<Cost> Costs { get; set; }
    }
}
