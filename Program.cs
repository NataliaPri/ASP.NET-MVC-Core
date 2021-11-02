using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        public sealed class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public string quantity { get; set; }
        }

    public interface Basket
        {
            IReadOnlyList<Product> GetAll();
        }


    }
    };
