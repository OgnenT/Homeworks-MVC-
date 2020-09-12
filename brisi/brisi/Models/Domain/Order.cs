using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace brisi.Models.Domain
{
    public class Order
    {
            public int Id { get; set; }
            public User User { get; set; }
            public string Pizza { get; set; }
            public double Price { get; set; }
        }
    }
