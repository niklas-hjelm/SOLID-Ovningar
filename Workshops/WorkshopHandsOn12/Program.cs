using System;
using WorkshopHandsOn12.Units;
using WorkshopHandsOn12.Switches;

namespace WorkshopHandsOn12
{
    class Program
    {
        static void Main(string[] args)
        {

            SwitchProgram.Run();
            ShapeProgram.Run();

            Console.ReadKey();
        }
    }
}
