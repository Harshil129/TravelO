using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelO.Models
{
    // A public class which holds the public variables and the validations
    public class Cost
    {
        [Key]
        [Required]
        public int CostID { get; set; }
        [Range(0.01,99999)]
        [DisplayFormat(DataFormatString = "{0:c}")]

        public decimal ActivitiesCost { get; set; }
                
        [Range(0.01, 99999)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal FoodCost { get; set; }

        [Range(0.01, 99999)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal AccomodationCost { get; set; }

        [Range(0.01, 99999)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal AverageTotalCost { get; set; }

        //Providing the parent-child and child-parent relationship between classes
        public ToDoList ToDoList { get; set; }
        public Place Place { get; set; }
    }
}
