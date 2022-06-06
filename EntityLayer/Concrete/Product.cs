using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public  class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public double Calorie { get; set; }
        public double carbo { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public string amount { get; set; }
        public string Image { get; set; }
   
        public List<ProductCategory> productCategories { get; set; }

    }
}
