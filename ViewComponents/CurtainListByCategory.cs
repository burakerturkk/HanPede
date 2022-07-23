using HanPerde.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HanPerde.ViewComponents
{
    public class CurtainListByCategory : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
           
            CurtainProductRepository curtainProductRepository = new CurtainProductRepository();
            var curtainProductList = curtainProductRepository.List(x=>x.CategoryId==id);
            return View(curtainProductList);
        }
    }
}
