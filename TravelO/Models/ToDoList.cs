using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelO.Models
{
    public class ToDoList
    {
        //A public class which holds the public variables and the validations
        [Key]
        [Required()]
        [Range(0, 9999)]
        [Display(Name = "List ID")]
        public int ListID { get; set; }

        public int PlaceID { get; set; }

        public String UserID { get; set; }

        [Required()]
        [MinLength(2), MaxLength(999)]
        public String Activities { get; set; }

        [Required()]
        [MinLength(2), MaxLength(999)]
        public String Cuisines { get; set; }

        [Required()]
        [MinLength(2), MaxLength(999)]
        public String PlacesToVisit { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2), MaxLength(40)]
        public String FirstName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(2), MaxLength(40)]
        public String LastName { get; set; }

        //Providing the parent-child and child-parent relationship between classes
        public Place Place { get; set; }
    }
}
