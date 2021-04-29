using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> newBoxes = new List<Box>();

            decimal totalPrice = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] productParts = line.Split();

                string serialNumber = productParts[0];
                string itemName = productParts[1];
                int quantity = int.Parse(productParts[2]);
                decimal price = decimal.Parse(productParts[3]);

                totalPrice = quantity * price;

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.ItemName = itemName;
                box.ItemQuantity = quantity;
                box.PriceForABox = price;
                box.TotalPrice = totalPrice;

                newBoxes.Add(box);
            }

            List<Box> sortedBox = newBoxes.OrderBy(boxes => boxes.TotalPrice).ToList();

            sortedBox.Reverse();

            foreach (Box box in sortedBox)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.ItemName} - ${box.PriceForABox:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.TotalPrice:F2}");

            }
        }

        class Box
        {
            public string SerialNumber { get; set; }
            public string ItemName { get; set; }
            public int ItemQuantity { get; set; }
            public decimal PriceForABox { get; set; }
            public decimal TotalPrice { get; set; }
        }
    }
}