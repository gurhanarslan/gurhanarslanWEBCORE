using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogget.Data.Abstract;
using Blogget.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Blogget.WebUI.Controllers
{
    public class AbilityController : Controller
    {
        private IAbilityRepository abilityRepository;

        public AbilityController(IAbilityRepository repository)
        {
            abilityRepository = repository;
        }


        public IActionResult Index()
        {
 
        return View(abilityRepository.GetAll());
        }
        [HttpGet]
        public IActionResult Create() => View();


        [HttpPost]
        public IActionResult Create(Ability ability)
        {
            abilityRepository.AddAbility(ability);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Uptade(int id)
        {
            
            return View(abilityRepository.GetById(id));
        }
        [HttpPost]
        public IActionResult Uptade(Ability ability)
        {
            abilityRepository.UptadeAbility(ability);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            abilityRepository.DeleteAbility(id);
            return RedirectToAction("Index");
        }
    }
}