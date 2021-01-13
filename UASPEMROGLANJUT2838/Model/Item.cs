using System;
using System.Collections.Generic;
using System.Text;

namespace UASPEMROGLANJUT2838.Controller
{
    public class Item
    {
        public string item { get; set; }
        public double price { get; set; }

        public Item(string item, double price)
        {
            this.item = item;
            this.price = price;
        }
    }
}
