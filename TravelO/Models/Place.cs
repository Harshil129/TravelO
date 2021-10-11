using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelO.Models
{
    //A public class which holds the public variables and the validations
    public class Place
    {
        [Key] //[Key] is use for the notation of Primary key
        [Required()]
        [Range (0,9999)]
        [Display(Name = "Place ID")] //the display tag will change the label to the given name
        public int PlaceID { get; set; }

        public int ProvinceID { get; set; }

        [Required(AllowEmptyStrings = false)] //This will not allow any empty strings in the field
        [Display(Name = "Place Name")]
        public String Name { get; set; }

        [MinLength(10), MaxLength(999)] //Providing range of class string
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

        //Providing the parent-child and child-parent relationship between classes
        public Province Province { get; set; }

        public List<ToDoList> ToDoLists { get; set; }

        public List<Cost> Costs { get; set; }
    }
}
