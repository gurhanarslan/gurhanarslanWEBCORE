using Blogget.Data.Abstract;
using Blogget.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blogget.Data.ConCreate.EfCore
{
  public  class EfBlogRepository : IBlogRepository
    {
        private BlogContext context;

        public EfBlogRepository(BlogContext _context)
        {
            context = _context;
        }


        public void AddBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
        }

        public void DeleteBlog(int blogid)
        {
            var entity = context.Blogs.FirstOrDefault(i => i.BlogId == blogid);
            if(context != null)
            {
                context.Blogs.Remove(entity);
                context.SaveChanges();
            }
        }

        public IQueryable<Blog> GetAll()
        {
            return context.Blogs;
        }

        public Blog GetById(int blogid)
        {
            return context.Blogs.FirstOrDefault(i => i.BlogId == blogid);
        }

        public Blog GetByTitle(string blogtitle)
        {
            return context.Blogs.FirstOrDefault(i => i.Title == blogtitle);
        }

        public void UptadeBlog(Blog blog)
        {
            context.Blogs.Update(blog);
                context.SaveChanges();
        }
    }
}
