using System;
using System.Collections;
using Module2HW6.Models;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;
using Module2HW6.Helpers;
using Module2HW6.Services.SearchServices;

namespace Module2HW6
{
    public class App
    {
        private readonly ITaxiStationService _taxiStationService;
        private readonly ITaxiStationProvider _taxiStationProvider;
        private readonly IPriceService _priceService;
        private readonly ISortService _sortService;
        private readonly IComparer _fuelConsumptionComparer;

        public App(ITaxiStationService taxiStationService, ITaxiStationProvider taxiStationProvider, IPriceService priceService, ISortService sortService)
        {
            _taxiStationService = taxiStationService;
            _taxiStationProvider = taxiStationProvider;
            _priceService = priceService;
            _sortService = sortService;
            _fuelConsumptionComparer = new FuelConsumptionComparer();
        }

        public void Start()
        {
            _taxiStationService.AddToSection();
            double totalPrice = _priceService.GetTotalPrice(_taxiStationProvider.TaxiStationCars);
            _sortService.SortCarsByFuelConsumption(_taxiStationProvider.TaxiStationCars);

            Console.WriteLine($"Total price of Taxi station cars: {totalPrice}");
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Search by model");
            Console.WriteLine("2. Search by year of issue");
            var chosenOperation = Convert.ToInt32(Console.ReadLine());
            switch (chosenOperation)
            {
                case 1:
                    var searchByModel = new SearchByModelService();
                    Console.WriteLine("Enter the model you want to search:");
                    var name = Console.ReadLine();
                    GetCarInfo(searchByModel.Search(_taxiStationProvider.TaxiStationCars, name));
                    break;
                case 2:
                    var searchByYearOfIssue = new SearchByYearOfIssue();
                    Console.WriteLine("Enter the year of issue you want to search:");
                    var year = Console.ReadLine();
                    GetCarInfo(searchByYearOfIssue.Search(_taxiStationProvider.TaxiStationCars, year));
                    break;
                default:
                    Console.WriteLine("You have entered wrong number!");
                    break;
            }
        }

        private void GetCarInfo(Car car)
        {
            if (car == null)
            {
                Console.WriteLine("I can't find this car!");
            }
            else
            {
                Console.WriteLine("==================");
                Console.WriteLine($"Brand: {car.Brand}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Fuel consumption: {car.FuelConsumption} l/100km");
                Console.WriteLine($"Year of issue: {car.YearOfIssue}");
                Console.WriteLine($"Price: ${car.Price}");
                Console.WriteLine("==================");
            }
        }
    }
}
