using HanPerde.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HanPerde.ViewComponents
{
    public class AccessoryListByCategory : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {

            AccessoryProductRepository accessoryProductRepository = new AccessoryProductRepository();
            var accessoryProductList = accessoryProductRepository.List(x => x.CategoryId == id);
            return View(accessoryProductList);
        }
    }
}
