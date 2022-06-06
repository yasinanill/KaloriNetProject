using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
 public   class Cart
    {
        public int ID { get; set; }
        public string UserId { get; set; }
        public List<CartItem> CartItems  { get; set; }





    }
}
