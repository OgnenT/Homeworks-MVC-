using Microsoft.AspNetCore.Mvc;
using SEDC.WebApp.ModelDemo.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.WebApp.ModelDemo.Models.ViewModels
{
    public class StoreVM
    {
        //[HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public List<Pizza> Menu { get; set; }
    }
}
