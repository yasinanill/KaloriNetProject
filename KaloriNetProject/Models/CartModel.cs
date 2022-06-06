using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriNetProject.Models
{


    public class CartModel
    {
        public int CartID { get; set; }
        public List<CartItemModel> CartItem { get; set; }
        public decimal TotalCalorie()
        {

            return CartItem.Sum(i => i.Calorie * i.Quantity);

        }
        public decimal TotalCarbo()
        {

            return CartItem.Sum(i => (int)i.Carbo * i.Quantity);

        }
        public decimal Totalfat()
        {

            return CartItem.Sum(i => (int)i.Protein * i.Quantity);

        }
        public decimal TotalPRotein()
        {

            return CartItem.Sum(i => (int)i.Fat * i.Quantity);

        }

     
        public decimal YuzdeKaloris()
        {
            var values = (TotalCalorie() * 100 / 2000);
            return (int)values;

        }
        public decimal Yuzdeprotein()
        {
            var values = (TotalPRotein() * 100 / 180);
            return (int)values;

        }
        public decimal Yuzdekarbonhidrat()
        {
            var values = (TotalCarbo() * 100 / 180);
            return (int)values;

        }
        public decimal Yuzdeyag()
        {
            var values = (Totalfat() * 100 / 140);
            return (int)values;

        }




    }
    public  class CartItemModel
    {
        public int CartItemID { get; set; }
        public int ProductID { get; set; }
  
        public string Name { get; set; }
        
        public string imageUrl { get; set; }
        public int Calorie { get; set; }
        public double Carbo { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Fats { get; set; }
        public string amount { get; set; }


        public int Quantity { get; set; }


    }
}
