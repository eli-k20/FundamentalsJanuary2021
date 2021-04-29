using System;
using System.Collections.Generic;
using System.Text;

namespace _06._StoreBoxes
{
    class Box
    {
        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
