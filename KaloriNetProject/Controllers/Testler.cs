using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaloriNetProject.Controllers
{
        [AllowAnonymous]
    public class Testler : Controller
    {


        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult KaloriHesap(int age,int boy,int kilo)
        {
            int sonuc = age + boy;
            ViewBag.snc = sonuc;

            return View();
        }
        public IActionResult BKIHesap()
        {

           


            return View();
        }
        public PartialViewResult deneme()
        {

            return PartialView();
        }
        public IActionResult IdealKiloHesap()
        {


            return View();
        }
        public IActionResult VKIHesap()
        {


            return View();
        }

    }
}
