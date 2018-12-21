using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsDishes
{
    public class Chef
    {
        public int chefid{get;set;}
        [Required]
        [MinLength(3)]
        public string firstname{get;set;}
        [Required]
        [MinLength(4)]
        public string lastname{get;set;}
        [Required]

        public DateTime birthday{get;set;}
        public List<Dish> dish{get;set;}
    }
}