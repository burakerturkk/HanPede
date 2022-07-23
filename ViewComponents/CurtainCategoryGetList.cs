using HanPerde.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HanPerde.ViewComponents
{
    public class CurtainCategoryGetList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CurtainCategoryRepository curtainCategoryRepository = new CurtainCategoryRepository();
            var curtainCategoryList = curtainCategoryRepository.TList();
            return View(curtainCategoryList);

        }
       
    }
}
