using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaloriNetProject.Controllers
{

    [AllowAnonymous]
    public class AnaSayfa : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult QUESTIONS()
        {
            return PartialView();
        }
        public PartialViewResult Hakkimizda()
        {
            return PartialView();
        }
        public PartialViewResult iletisim()
        {
            return PartialView();
        }
        public PartialViewResult Uzmanlar()
        {
            return PartialView();
        }
    }
}
