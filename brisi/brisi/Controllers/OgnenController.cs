using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using brisi.Models.Domain;
using brisi.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace brisi.Controllers
{
    public class OgnenController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["Title"] = "Proba Ognen - Index";

            //User person = new User() { FirstName = "Ognen", LastName = "Temelkovski", Address = "St. Kliment Ohridski", Phone = 077622499 };
            //Order order = new Order() { Id = 1, User = person, Pizza = "Pepperoni", Price = 6 };

            //return View(order);

            //------------------------------------------
            //var allBuddies = MyDb.Buddies;
            //var allBuddiesVM = allBuddies.Select(buddy => new BuddyVM()
            //{
            //    FullName = buddy.FullName,
            //    Mail = buddy.Mail,
            //    ImgUrl = buddy.ImgUrl
            //}).ToList();

            //return View(allBuddiesVM);
            //------------------------------------------
            var myBase = MyDb.Buddies;
            return View(myBase);

        }

        //[HttpGet("BuddyDetails/{id:int}")]
        public IActionResult BuddyDetails(int id)
        {
            var buddyDetailDomain = MyDb.Buddies.SingleOrDefault(b => b.Id == id);
            //BuddyVM buddyDetailVM = new BuddyVM()
            //{
            //    Id = buddyDetailDomain.Id,
            //    FullName = buddyDetailDomain.FullName,
            //    ImgUrl = buddyDetailDomain.ImgUrl,
            //    Mail = buddyDetailDomain.Mail
            //};

            return View(buddyDetailDomain);
        }
        //public IActionResult Detal(int id)
        //{
        //    //var detal = MyDb.Buddies.Where(b => b.Id == id);
        //    return RedirectToAction("BuddyDetails/{id}");
        //}


        public IActionResult Details()
        {
            User person = new User() { FirstName = "Ognen", LastName = "Temelkovski", Address = "St. Kliment Ohridski", Phone = 077622499 };
            Order order = new Order() { Id = 1, User = person, Pizza = "Pepperoni", Price = 6 };
            OrderDetailsVM orderDetailsVM = new OrderDetailsVM()
            {
                Id = order.Id,
                FullName = $"{person.FirstName} {person.LastName}",
                Address = person.Address,
                Contact = person.Phone,
                Pizza = order.Pizza,
                Price = order.Price,
                isDelivered = true
            };
            ViewBag.DetailsOrderName = orderDetailsVM.FullName;
            return View(orderDetailsVM);
        }
        public IActionResult GoBack()
        {
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var buddyDetailDomain = MyDb.Buddies.SingleOrDefault(b => b.Id == id);
            return View(buddyDetailDomain);
        }
        [HttpPost]
        [Route("delete/{id:int}")]
        public IActionResult DeleteById(int id)
        {
            var deleteBuddy = MyDb.Buddies.FirstOrDefault(b => b.Id == id);
            MyDb.Buddies.Remove(deleteBuddy);
            return RedirectToAction("Index");
        }

    }
}
