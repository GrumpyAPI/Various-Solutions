using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split();

                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal price = decimal.Parse(tokens[3]);

                Item item = new Item()
                {
                    Name = itemName,
                    Price = price
                };

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = item,
                    Quantity = itemQuantity,
                    BoxPrice = itemQuantity * price
                };

                boxes.Add(box);
                line = Console.ReadLine();
            }

            List<Box> orderedBoxes = boxes.OrderByDescending(x => x.BoxPrice).ToList();

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}\n-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}\n-- ${box.BoxPrice:F2}");
            }
        }
    }
}
