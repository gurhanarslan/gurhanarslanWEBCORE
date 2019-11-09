using Blogget.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogget.WebUI.ViewComponents
{
    public class WebSharingViewComponent : ViewComponent
    {
        private IBlogRepository repository;
        public WebSharingViewComponent(IBlogRepository repo)
        {
            repository = repo;
        }


        public IViewComponentResult Invoke(int? id, bool IsSlide)
        {
            var viewname = "";
            if (IsSlide)
            {
                viewname = "Green";
            }
            else
            {
                viewname = "Red";
            }


            var Query = repository.GetAll();
            if (id != null)
            {
                Query = Query.Where(i => i.CategoryId == id);
            }
            return View(Query);
        
          
           
        }
    }
}
