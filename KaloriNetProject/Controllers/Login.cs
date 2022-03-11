using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KaloriNetProject.Controllers
{
    [AllowAnonymous]
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
        //public IActionResult Index(Expert e) 
        //{
        //    Context c = new Context();
        //    var datavalue = c.Experts.FirstOrDefault(x => x.ExpertMail == p.WriterMail && x.WriterPasaword == p.WriterPasaword);
        //    if (datavalue != null)
        //    {
        //        var claims = new List<Claim>{

        //            new Claim(ClaimTypes.Name,p.WriterMail)
        //        };

        //        var useridentiny = new ClaimsIdentity(claims, "sa");
        //        ClaimsPrincipal principal = new ClaimsPrincipal(useridentiny);
        //        await HttpContext.SignInAsync(principal);


        //        return RedirectToAction("Index", "Blog");
        //    }
        //    else
        //    {
        //        return View();
        //    }
    }
}
