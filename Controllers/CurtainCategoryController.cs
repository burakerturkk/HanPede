using HanPerde.Models;
using HanPerde.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HanPerde.Controllers
{
    [Authorize]
    public class CurtainCategoryController : Controller
    {
        CurtainCategoryRepository curtainCategoryRepository = new CurtainCategoryRepository();
        public IActionResult Index()
        {

            return View(curtainCategoryRepository.TList());
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(CategoryCurtain p)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            curtainCategoryRepository.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult CategoryGet(int id)
        {
            var x = curtainCategoryRepository.TGet(id);
            CategoryCurtain ct = new CategoryCurtain()
            {
                CategoryName = x.CategoryName,
                CategoryId = x.CategoryId
            };
            return View(ct);

        }
        [HttpPost]
        public IActionResult CategoryUpdate(CategoryCurtain p)
        {
            var x = curtainCategoryRepository.TGet(p.CategoryId);
            x.CategoryName = p.CategoryName;
            x.Active = true;
            curtainCategoryRepository.TUpdate(x);
            return RedirectToAction("Index");
        }

        public IActionResult CategoryDelete(int id)
        {
            var x = curtainCategoryRepository.TGet(id);
            x.Active = false;
            curtainCategoryRepository.TDelete(x);
            return RedirectToAction("Index");


        }
    }
}
