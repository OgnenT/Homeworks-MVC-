using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.WebApp.ModelDemo.Models.Domain;
using SEDC.WebApp.ModelDemo.Models.ViewModels;

namespace SEDC.WebApp.ModelDemo.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            var allPizzas = StaticDb.Menu;
            var allStores = StaticDb.Stores.Select(s => new StoreVM()
            {
                Id = s.Id,
                Name = s.Name,
                City = s.City,
                Menu = allPizzas
            }).ToList();
            return View(allStores);
        }
        public IActionResult StoreDetails(int id)
        {
            var allPizzas = StaticDb.Menu;

            var store = StaticDb.Stores.SingleOrDefault(s => s.Id == id);
            var storeVM = new StoreVM()
            {
                Id = store.Id,
                City = store.City,
                Name = store.Name,
                Menu = allPizzas
            };

            return View(storeVM);
        }
        public IActionResult DeleteStore(int id)
        {
            var deleteById = StaticDb.Stores.SingleOrDefault(s => s.Id == id);
            StaticDb.Stores.Remove(deleteById);
            return RedirectToAction("Index");
        }
    }
}
