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
    public class AccessoryCategoryController : Controller
    {
        AccessoryCategoryRepository accessoryCategoryRepository = new AccessoryCategoryRepository();
        public IActionResult Index()
        {

            return View(accessoryCategoryRepository.TList());
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(CategoryAccessory p)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            accessoryCategoryRepository.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult CategoryGet(int id)
        {
            var x = accessoryCategoryRepository.TGet(id);
            CategoryAccessory ct = new CategoryAccessory()
            {
                CategoryName = x.CategoryName,
                CategoryId = x.CategoryId
            };
            return View(ct);

        }
        [HttpPost]
        public IActionResult CategoryUpdate(CategoryAccessory p)
        {
            var x = accessoryCategoryRepository.TGet(p.CategoryId);
            x.CategoryName = p.CategoryName;
            x.Active = true;
            accessoryCategoryRepository.TUpdate(x);
            return RedirectToAction("Index");
        }

        public IActionResult CategoryDelete(int id)
        {
            var x = accessoryCategoryRepository.TGet(id);
            x.Active = false;
            accessoryCategoryRepository.TDelete(x);
            return RedirectToAction("Index");


        }
    }
}
