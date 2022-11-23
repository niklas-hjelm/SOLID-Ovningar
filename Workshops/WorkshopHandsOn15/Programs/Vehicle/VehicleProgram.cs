using System;
using WorkshopHandsOn15.Decorators;
using WorkshopHandsOn15.Vehicles;

namespace WorkshopHandsOn15
{
    class VehicleProgram
    {
        public static void Run()
        {
            // Basic vehicle
            IVehicle car = VolvoV70.Create();

            Console.WriteLine("Volvo V70 base price are : {0} Kr", car.Price);

            // Special offer
            car = VehicleOfferDecorator.Create(VolvoV70.Create(), 25, "25 % discount");
            Console.WriteLine("Volvo V70 price with 25 % discount are : {0} Kr", car.Price);

            car = VehicleOfferDecorator.Create(VolvoV70.Create(), 10, "10 % discount");
            Console.WriteLine("Volvo V70 price with 10 % discount are : {0} Kr", car.Price);

            car = VehicleOfferDecorator.Create(car, 15, "15 % extra discount");
            Console.WriteLine("Volvo V70 price with 15 % extra discount are : {0} Kr", car.Price);

            Console.ReadKey();
        }
    }
}
