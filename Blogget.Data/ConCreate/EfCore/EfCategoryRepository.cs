using Blogget.Data.Abstract;
using Blogget.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blogget.Data.ConCreate.EfCore
{
   public class EfCategoryRepository : ICategoryRepository
    {
        private BlogContext context;

        public EfCategoryRepository(BlogContext _context)
        {
            context = _context;
        }



        public void AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void DeleteCategory(int categoryid)
        {
            var item = context.Categories.FirstOrDefault(i => i.CategoryId == categoryid);
            if (context != null)
            {
                context.Categories.Remove(item);
                context.SaveChanges();
            }
        }

        public IQueryable<Category> GetAll()
        {
            return context.Categories;
        }

        public Category GetById(int categoryid)
        {
           return context.Categories.FirstOrDefault(i => i.CategoryId == categoryid);
        }

        public void UptadeCategory(Category category)
        {
            context.Categories.Update(category);
            context.SaveChanges();
        }
    }
}
