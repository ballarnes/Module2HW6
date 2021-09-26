using System;
using Module2HW6.Helpers;
using Module2HW6.Models;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class SortService : ISortService
    {
        public void SortCarsByFuelConsumption(Car[] cars)
        {
            Array.Sort(cars, new FuelConsumptionComparer());
        }
    }
}
