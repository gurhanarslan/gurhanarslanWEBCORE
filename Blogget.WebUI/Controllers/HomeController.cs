using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blogget.WebUI.Models;
using Blogget.Data.Abstract;

namespace Blogget.WebUI.Controllers
{
    public class HomeController : Controller
    {

        private IBlogRepository blogRepository;

        public HomeController(IBlogRepository repository)
        {
            blogRepository = repository;
        }


        public IActionResult Index(int? id,string q)
        {
            var query = blogRepository.GetAll().Where(i => i.IsApproved);
            if (id != null)
            {
                query = query.Where(i => i.CategoryId == id);
            }

            if (!string.IsNullOrEmpty(q))
            {
                query = query.Where(i => i.Title.Contains(q) || i.Description.Contains(q) || i.Body.Contains(q));
            }


            return View(query.OrderByDescending(i => i.Date));
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult deneme()
        {
            return View();
        }

    }
}
