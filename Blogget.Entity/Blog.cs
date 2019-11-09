using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blogget.Entity
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string BlogHtml { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Body { get; set; }
        [BindNever]
        public DateTime Date { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public bool IsSlide { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
