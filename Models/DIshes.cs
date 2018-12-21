using System.ComponentModel.DataAnnotations;
namespace ChefsDishes
{
    public class Dish
    {
        public int dishid{get;set;}
        [Required]
        public string name{get;set;}
        [Required]
        [MinLength(5)]
        public string description{get;set;}
        [Required]
        public int tastiness{get;set;}
        [Required]
        public int calories{get;set;}
        public int chefid{get;set;}
        public Chef Chefwhomade{get;set;}
    }
}