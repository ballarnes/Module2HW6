using Module2HW6.Models;

namespace Module2HW6.Services.Abstractions
{
    public interface ISortService
    {
        public void SortCarsByFuelConsumption(Car[] cars);
    }
}
