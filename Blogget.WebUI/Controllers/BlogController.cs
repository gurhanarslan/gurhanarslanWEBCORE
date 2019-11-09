using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Blogget.Data.Abstract;
using Blogget.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blogget.WebUI.Controllers
{
    public class BlogController : Controller
    {

        private IBlogRepository repository;
        private ICategoryRepository categoryRepository;
        public BlogController(IBlogRepository repo, ICategoryRepository categoryRepo)
        {
            repository = repo;
            categoryRepository = categoryRepo;
        }



        public IActionResult Index(string q)
        {
        



            return View(repository.GetAll());
        }

        [HttpGet]
        public IActionResult Create() {

           

            ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "CategoryId", "Name");
            return View();
        } 


        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            blog.Date = DateTime.Now;
            if (ModelState.IsValid)
            {
                repository.AddBlog(blog);
                return RedirectToAction("Index");
            }
           
             return View(blog);
        }

        public IActionResult Delete(int id)
        {
            repository.DeleteBlog(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Uptade(int id)
        {

            ViewBag.Categories = new SelectList(categoryRepository.GetAll(), "CategoryId", "Name");
            return View(repository.GetById(id));
        }
        [HttpPost]
        public async Task<IActionResult> Uptade(Blog blog, IFormFile file)
        {

            blog.Date = DateTime.Now;
            if (ModelState.IsValid)
            {

                if (file != null)
                {


                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    blog.Image = file.FileName;
                }
                repository.UptadeBlog(blog);
                    return RedirectToAction("Index");
              
            }

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id,string title)
        {
            return View(repository.GetById(id));
        }


    }
}