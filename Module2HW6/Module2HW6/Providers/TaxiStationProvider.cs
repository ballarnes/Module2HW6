using Module2HW6.Models;
using Module2HW6.Providers.Abstractions;

namespace Module2HW6.Providers
{
    public class TaxiStationProvider : ITaxiStationProvider
    {
        public Car[] TaxiStationCars { get; set; }
    }
}
