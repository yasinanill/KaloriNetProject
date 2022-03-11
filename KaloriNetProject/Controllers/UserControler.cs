using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaloriNetProject.Controllers
{
    [AllowAnonymous]
    public class UserControler : Controller
    {

        UserManager um = new UserManager(new EfUserRepository());
        public IActionResult Index()
        {


            return View();
        
        
        }
        public IActionResult UpdateInfo()
        {

            return View();
        } 
        public IActionResult GunlukTakip()
        {

            return View();
        }


    }
}
