using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface ICartDal :IGenericDal<Cart>
    {
        Cart GetByUsersId(string userId);
        void DeleteFromCart(int cartId, int productId);
        void ClearCart(string cartId);



    }
}
