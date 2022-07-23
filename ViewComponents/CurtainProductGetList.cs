using HanPerde.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HanPerde.ViewComponents
{
    public class CurtainProductGetList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CurtainProductRepository curtainProductRepository = new CurtainProductRepository();
            var curtainProductList = curtainProductRepository.TList();
            return View(curtainProductList);
        }
    }
}
