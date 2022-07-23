using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HanPerde.Controllers
{
    [AllowAnonymous]
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryDetailsCurtain(int id)
        {
            ViewBag.x = id;
            return View();
        }
        public IActionResult CategoryDetailsAccessory(int id)
        {
            ViewBag.x = id;
            return View();
        }
    }
}
