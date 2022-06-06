using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService

    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }


        public void FoodAdd(Product product)
        {
            _productDal.Create(product);
        }

        public void FoodDelete(Product product)
        {
            _productDal.Delete(product);
        }

        public void FoodUpdate(Product product)
        {
            _productDal.Update(product);
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> GetList()
        {
            return _productDal.GetListAll().ToList();
        }

        public Product GetProductDetails(int id)
        {
             return _productDal.GetProductDetails(id);
        }
        public List<Product> GetPRoductByID(int id)
        {
            return _productDal.GetListAll(x => x.ID == id);

        }


    }
}
