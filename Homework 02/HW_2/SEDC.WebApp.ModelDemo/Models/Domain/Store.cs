﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.WebApp.ModelDemo.Models.Domain
{
    public class Store
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public List<Pizza> Menu { get; set; }
    }
}
