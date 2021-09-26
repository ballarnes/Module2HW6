using Module2HW6.Models;

namespace Module2HW6.Services.Abstractions
{
    public class PriceService : IPriceService
    {
        public double GetTotalPrice(Car[] cars)
        {
            var totalPrice = 0.0;
            foreach (var car in cars)
            {
                totalPrice += car.Price;
            }

            return totalPrice;
        }
    }
}
