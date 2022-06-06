using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using KaloriNetProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaloriNetProject.Controllers

{
    [AllowAnonymous]
    public class ProductController : Controller
    {

        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product product = _productService.GetProductDetails((int)id);
            if (product == null)
            {
                return NotFound();
            }
            return View(new ProductDetailsModel()
            {
                Product = product,
          
            });
        }

        public IActionResult Index()
        {
            return View(new ProductListModel() {
                Products = _productService.GetList()
            });
        }
    }
}
