using HanPerde.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HanPerde.ViewComponents
{
    public class AccessoryProductGetList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AccessoryProductRepository accessoryProductRepository = new AccessoryProductRepository();
            var accessoryProductList = accessoryProductRepository.TList();
            return View(accessoryProductList);
        }

    }
}
