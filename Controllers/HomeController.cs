using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ChefsDishes.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ChefsDishes.Controllers
{
    public class HomeController : Controller
    {
        private DishContext dbContext;
        public HomeController(DishContext context)
        {
            dbContext = context;
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Dishes()
        {
            List<Dish> dishes = dbContext.Dishes.Include(dish => dish.Chefwhomade).ToList();
            ViewBag.dishes = dishes;
            return View();
        }
        [HttpGet]
        [Route("chefs")]
        public IActionResult Chefs()
        {
            List<Chef> chefs = dbContext.Chefs.Include(i => i.dish).ToList();
            ViewBag.chefs = chefs;
            return View();
        }
        [HttpGet]
        [Route("adddish")]
        public IActionResult Adddish()
        {
            List<Chef> choices = dbContext.Chefs.ToList();
            ViewBag.Chefschoices = choices;
            return View();
        }
        [HttpPost]
        [Route("dishprocessor")]
        public IActionResult Dishprocessor(Dish newdish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newdish);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            return RedirectToAction("Adddish");
        }
        [HttpGet]
        [Route("addchef")]
        public IActionResult Addchef()
        {
            return View();
        }
        [HttpPost]
        [Route("chefprocessor")]
        public IActionResult Chefprocessor(Chef newchef)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newchef);
                dbContext.SaveChanges();
                return RedirectToAction("Chefs");
            }
            return RedirectToAction("Addchef");
        }
    }
}
