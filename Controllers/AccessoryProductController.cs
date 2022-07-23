using HanPerde.Models;
using HanPerde.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace HanPerde.Controllers
{
    [Authorize]
    public class AccessoryProductController : Controller
    {
        Context c = new Context();
        AccessoryProductRepository accessoryProductRepository = new AccessoryProductRepository();
        public IActionResult Index(int page = 1)
        {
            return View(accessoryProductRepository.TList("CategoryAccessory").ToPagedList(page, 10));
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> values = (from x in c.CategoryAccessories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;

            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(AccessoryProduct p)
        {
            accessoryProductRepository.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            accessoryProductRepository.TDelete(new AccessoryProduct { ProductId = id });
            return RedirectToAction("Index");
        }
        public IActionResult ProductGet(int id)
        {
            var x = accessoryProductRepository.TGet(id);
            List<SelectListItem> values = (from y in c.CategoryAccessories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.CategoryName,
                                               Value = y.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            AccessoryProduct pr = new AccessoryProduct()
            {
                ProductId = x.ProductId,
                CategoryId = x.CategoryId,
                ProductName = x.ProductName,
                ProductImageUrl = x.ProductImageUrl
            };

            return View(pr);
        }
        [HttpPost]
        public IActionResult UpdateProduct(AccessoryProduct p)
        {
            var x = accessoryProductRepository.TGet(p.ProductId);
            x.ProductName = p.ProductName;
            x.ProductImageUrl = p.ProductImageUrl;
            x.CategoryId = p.CategoryId;
            accessoryProductRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
