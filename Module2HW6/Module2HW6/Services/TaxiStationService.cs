using System;
using System.Collections.Generic;
using System.Linq;
using Module2HW6.Services.Abstractions;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Models;

namespace Module2HW6.Services
{
    public class TaxiStationService : ITaxiStationService
    {
        private readonly ICarProvider _carProvider;
        private readonly ITaxiStationProvider _taxiStationProvider;
        private readonly int _maxCarsInTaxiStation;

        public TaxiStationService(ICarProvider carProvider, ITaxiStationProvider taxiStationProvider)
        {
            _carProvider = carProvider;
            _taxiStationProvider = taxiStationProvider;
            _maxCarsInTaxiStation = 20;
        }

        public void AddToSection()
        {
            Car[] cars = new Car[_maxCarsInTaxiStation];
            for (var i = 0; i < cars.Length; i++)
            {
                cars[i] = _carProvider.Cars[new Random().Next(0, 6)];
                _taxiStationProvider.TaxiStationCars = cars;
            }
        }
    }
}
