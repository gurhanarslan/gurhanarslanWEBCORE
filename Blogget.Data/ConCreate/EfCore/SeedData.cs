using Blogget.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blogget.Data.ConCreate.EfCore
{
   public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            BlogContext context = app.ApplicationServices.GetRequiredService<BlogContext>();

            context.Database.Migrate();

            if (!context.Categories.Any())
            {
                context.AddRange(

                    new Category() { Name = "Category 1" },
                    new Category() { Name = "Category 2" },
                    new Category() { Name = "Category 3" }

                    );
                context.SaveChanges();
            }

            if (!context.Ability.Any())
            {
                context.AddRange(
                    
                    new Ability() { AbilityName = "ASP.NET CORE", },
                    new Ability() { AbilityName = "HTML" },
                    new Ability() { AbilityName = "CSS" },
                    new Ability() { AbilityName = "BOOTSTRAP" },
                    new Ability() { AbilityName = "JQUERY" }



                    );
                context.SaveChanges();
            }


            if (!context.Blogs.Any())
            {
                context.AddRange(

                    new Blog() { Title = "Blog Title 11", Description = "Blog Desription 1", Body = "Blog Body", Image = "1.jpg", Date = DateTime.Now.AddDays(-5), IsApproved = true, CategoryId = 3002 },
                    new Blog() { Title = "Blog Title 21", Description = "Blog Desription 1", Body = "Blog Body", Image = "1.jpg", Date = DateTime.Now.AddDays(-6), IsApproved = false, CategoryId = 3002 },
                    new Blog() { Title = "Blog Title 31", Description = "Blog Desription 1", Body = "Blog Body", Image = "1.jpg", Date = DateTime.Now.AddDays(-7), IsApproved = true, CategoryId = 3002 },
                    new Blog() { Title = "Blog Title 41", Description = "Blog Desription 1", Body = "Blog Body", Image = "1.jpg", Date = DateTime.Now.AddDays(-8), IsApproved = true, CategoryId = 3002 },
                    new Blog() { Title = "Blog Title 51", Description = "Blog Desription 1", Body = "Blog Body", Image = "1.jpg", Date = DateTime.Now.AddDays(-9), IsApproved = true, CategoryId = 3002 }

                    );
                context.SaveChanges();

            }
        }
 
    }
}
