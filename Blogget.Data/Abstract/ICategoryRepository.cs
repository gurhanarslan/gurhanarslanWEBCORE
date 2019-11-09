using Blogget.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blogget.Data.Abstract
{
    public interface ICategoryRepository
    {

        Category GetById(int categoryid);
        IQueryable<Category> GetAll();
        void AddCategory(Category category);
        void UptadeCategory(Category category);
        void DeleteCategory(int categoryid);


    }
}
