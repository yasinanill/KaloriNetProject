using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Foods
    {[Key]
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public string FoodDescription  { get; set; }
        public bool FoodStatus { get; set; }
        public double FoodCalorie { get; set; }
        public double Foodcarbo { get; set; }
        public double FoodProtein { get; set; }
        public double FoodFat { get; set; }
        public string Foodamount{ get; set; }
        public string FoodImage { get; set; }
  }
}
