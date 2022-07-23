using HanPerde.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HanPerde.ViewComponents
{
    public class AccessoryCategoryGetList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AccessoryCategoryRepository accessoryCategoryRepository = new AccessoryCategoryRepository();
            var acccategoryList = accessoryCategoryRepository.TList();
            return View(acccategoryList);
        }
    }
}
