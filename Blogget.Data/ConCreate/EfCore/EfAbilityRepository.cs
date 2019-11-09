using Blogget.Data.Abstract;
using Blogget.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blogget.Data.ConCreate.EfCore
{
    public class EfAbilityRepository : IAbilityRepository
    {
        private BlogContext context;
        public EfAbilityRepository(BlogContext _context)
        {
            context = _context;
        }


        public void AddAbility(Ability ability)
        {
            context.Ability.Add(ability);
                context.SaveChanges();
        }

        public void DeleteAbility(int abilityid)
        {
            var abi = context.Ability.FirstOrDefault(i => i.AlibityId == abilityid);
            if(context != null)
            {
                context.Ability.Remove(abi);
                context.SaveChanges();
            }
        }

        public IQueryable<Ability> GetAll()
        {
            return context.Ability;
        }

        public Ability GetById(int abilityid)
        {
            return context.Ability.FirstOrDefault(i => i.AlibityId == abilityid);
        }

        public void UptadeAbility(Ability ability)
        {
            context.Ability.Update(ability);
            context.SaveChanges();
        }
    }
}
