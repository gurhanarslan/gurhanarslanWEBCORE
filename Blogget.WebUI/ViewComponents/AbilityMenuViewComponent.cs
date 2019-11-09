using Blogget.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogget.WebUI.ViewComponents
{
    public class AbilityMenuViewComponent : ViewComponent
    {
        private IAbilityRepository repository;
        public AbilityMenuViewComponent(IAbilityRepository repo)
        {
            repository = repo;

        }
        public IViewComponentResult Invoke()
        {
            return View(repository.GetAll());
        }


    }
}
