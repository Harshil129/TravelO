using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelO.Models
{
    public class Cost
    {
        [Key]
        [Required]
        [Range(1,999)]
        public int CostID { get; set; }
        [Range(0.01,99999)]

        public decimal ActivitiesCost { get; set; }
                
        [Range(0.01, 99999)]
        public decimal FoodCost { get; set; }

        [Range(0.01, 99999)]
        public decimal AccomodationCost { get; set; }

        [Range(0.01, 99999)]
        public decimal AverageTotalCost { get; set; }

        public ToDoList ToDoList { get; set; }
        public Place Place { get; set; }
    }
}
