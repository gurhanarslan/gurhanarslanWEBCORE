using Blogget.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blogget.Data.Abstract
{
    public interface IAbilityRepository
    {
        Ability GetById(int abilityid);
        IQueryable<Ability> GetAll();
        void AddAbility(Ability blog);
        void UptadeAbility(Ability blog);
        void DeleteAbility(int abilityid);
    }
}
