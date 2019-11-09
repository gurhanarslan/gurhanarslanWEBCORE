using Blogget.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blogget.Data.Abstract
{
    public interface IBlogRepository
    {

        Blog GetById(int blogid);
        Blog GetByTitle(string blogtitle);
        IQueryable<Blog> GetAll();
        void AddBlog(Blog blog);
        void UptadeBlog(Blog blog);
        void DeleteBlog(int blogid);


    }
}
