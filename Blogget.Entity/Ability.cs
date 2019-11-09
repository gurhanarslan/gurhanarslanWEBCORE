using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blogget.Entity
{
   public class Ability
    {   [Key]
        public int AlibityId { get; set; }
        public string AbilityName { get; set; }
      
    }
}
