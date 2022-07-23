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
    public class CurtainProductController : Controller
    {
        Context c = new Context();
        CurtainProductRepository curtainProductRepository = new CurtainProductRepository();
        public IActionResult Index(int page = 1)
        {
            return View(curtainProductRepository.TList("CategoryCurtain").ToPagedList(page,10));
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> values = (from x in c.CategoryCurtains.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;

            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(CurtainProduct p)
        {
            curtainProductRepository.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            curtainProductRepository.TDelete(new CurtainProduct { ProductId = id });
            return RedirectToAction("Index");
        }
        public IActionResult ProductGet(int id)
        {
            var x = curtainProductRepository.TGet(id);
            List<SelectListItem> values = (from y in c.CategoryCurtains.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.CategoryName,
                                               Value = y.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            CurtainProduct pr = new CurtainProduct()
            {
                ProductId = x.ProductId,
                CategoryId = x.CategoryId,
                ProductName = x.ProductName,
                ProductImageUrl = x.ProductImageUrl
            };

            return View(pr);
        }
        [HttpPost]
        public IActionResult UpdateProduct(CurtainProduct p)
        {
            var x = curtainProductRepository.TGet(p.ProductId);
            x.ProductName = p.ProductName;
            x.ProductImageUrl = p.ProductImageUrl;
            x.CategoryId = p.CategoryId;
            curtainProductRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
