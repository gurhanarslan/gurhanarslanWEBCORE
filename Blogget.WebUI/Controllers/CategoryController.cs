using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogget.Data.Abstract;
using Blogget.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Blogget.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository repository)
        {
            categoryRepository = repository;
        }


        public IActionResult Index()
        {
 
        return View(categoryRepository.GetAll());
        }
        [HttpGet]
        public IActionResult Create() => View();


        [HttpPost]
        public IActionResult Create(Category blog)
        {
            categoryRepository.AddCategory(blog);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Uptade(int id)
        {
            
            return View(categoryRepository.GetById(id));
        }
        [HttpPost]
        public IActionResult Uptade(Category category)
        {
            categoryRepository.UptadeCategory(category);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            categoryRepository.DeleteCategory(id);
            return RedirectToAction("Index");
        }
    }
}