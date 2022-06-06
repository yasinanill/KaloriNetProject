using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public  interface IProductService
    {
        void FoodAdd(Product product);
        void FoodDelete(Product product);
        void FoodUpdate(Product product);
        List<Product> GetList();
        Product GetById(int id);

        Product GetProductDetails(int id);

    }
}
