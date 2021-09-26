using Module2HW6.Models;

namespace Module2HW6.Services.Abstractions
{
    public interface IPriceService
    {
        public double GetTotalPrice(Car[] cars);
    }
}
