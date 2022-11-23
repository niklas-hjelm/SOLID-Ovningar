using System;
using WorkshopHandsOn15.Vehicles;

namespace WorkshopHandsOn15.Decorators
{
    class VehicleOfferDecorator : VehicleDecorator, IVehicle
    {
        public static IVehicle Create(IVehicle vehicle, int discountPercentage, string offer)
        {
            return new VehicleOfferDecorator(vehicle, discountPercentage, offer);
        }
        private VehicleOfferDecorator(IVehicle vehicle, int discountPercentage, string offer)
            : base(vehicle) 
        {
            DiscountPercentage = discountPercentage;
            Offer = offer;
        }

        protected int DiscountPercentage { get; set; }
        protected string Offer { get; set; }

        public override double Price
        {
            get
            {
                double price = base.Price;
                int percentage = 100 - DiscountPercentage;
                price = Math.Round((price * percentage) / 100, 2);
                return price;
            }
        }
    }
}
