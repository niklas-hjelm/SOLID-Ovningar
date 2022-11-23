using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopHandsOn33.LawnMowers;
using WorkshopHandsOn33.Warehouse;

namespace WorkshopHandsOn33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "--------------------------------------------------------------------------------------";

            IStock stock = Stock.Create();

            IAutoMower a1 = AutoMower.Create("Husqvarna");
            IAutoMower a2 = AutoMower.Create("Gardena");
            IAutoMower a3 = AutoMower.Create("Stiga");
            IAutoMower a4 = AutoMower.Create("Lyfco");

            IRidingLawnMower r1 = RidingLawnMower.Create("Stiga", true);
            IRidingLawnMower r2 = RidingLawnMower.Create("Husqvarna", false);
            IRidingLawnMower r3 = RidingLawnMower.Create("MTD", true);

            stock.Add(new List<ILawnMower>() { a1, a2, a3, a4, r1, r2, r3 });

            Console.WriteLine(stock.PrintStock());
            Console.WriteLine(line);

            Console.WriteLine(stock.PrintStock(r1.GetType()));
            Console.WriteLine(line);

            Console.WriteLine(stock.PrintStock(a1.GetType()));
            Console.WriteLine(line);

            stock.Remove(a3);

            Console.WriteLine(stock.PrintStock(a1.GetType()));
            Console.WriteLine(line);

            a3.SetHours(8);
            a3.SetStartTime("08:00");
            a3.Start();

            Console.WriteLine(a3.ToString());
            Console.WriteLine(line);

            a3.Stop();
            Console.WriteLine("The article number of a3 is " + a3.ArtNr);
            Console.WriteLine(line);

            stock.Remove(new List<ILawnMower>() { a1, a4, r3 });
            Console.WriteLine(line);

            Console.WriteLine(stock.PrintStock());

            Console.ReadKey();
        }
    }
}
