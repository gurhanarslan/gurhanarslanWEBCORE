﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Blogget.Entity
{
  public  class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public List<Blog> Blogs { get; set; }


    }
}
