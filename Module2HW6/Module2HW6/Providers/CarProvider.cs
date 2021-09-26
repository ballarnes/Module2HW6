using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Enums;
using Module2HW6.Models;
using Module2HW6.Models.Minibus;
using Module2HW6.Models.Sedan.Electro;
using Module2HW6.Models.Sedan.Petrol.AutomaticTransmission;
using Module2HW6.Models.Sedan.Petrol.ManualTransmission;
using Module2HW6.Providers.Abstractions;

namespace Module2HW6.Providers
{
    public class CarProvider : ICarProvider
    {
        public CarProvider()
        {
            Cars = new Car[]
            {
                new Minibus { Brand = CarBrand.Volkwagen, Model = "Transporter T6", YearOfIssue = 2016, NumberOfSeatsForPassengers = 9, FuelConsumption = 8.9, Price = 24900 },
                new Minibus { Brand = CarBrand.Volkwagen, Model = "Transporter T5", YearOfIssue = 2014, NumberOfSeatsForPassengers = 8, FuelConsumption = 8, Price = 18200 },
                new Electro { Brand = CarBrand.Nissan, Model = "Leaf", YearOfIssue = 2016, NumberOfDoors = 4, PowerReserve = 150, FuelConsumption = 0, Price = 10800 },
                new Electro { Brand = CarBrand.Tesla, Model = "Model S 60", YearOfIssue = 2013, NumberOfDoors = 4, PowerReserve = 320, FuelConsumption = 0, Price = 23600 },
                new ManualGearbox { Brand = CarBrand.Toyota, Model = "Corolla", YearOfIssue = 2016, NumberOfDoors = 4, TypeOfManualGearbox = TypeOfManualGearbox.SixSpeed, FuelTankVolume = 55, FuelConsumption = 7.2, Price = 10900 },
                new ManualGearbox { Brand = CarBrand.Toyota, Model = "Echo", YearOfIssue = 2002, NumberOfDoors = 2, TypeOfManualGearbox = TypeOfManualGearbox.FiveSpeed, FuelTankVolume = 40, FuelConsumption = 6.1, Price = 4900 },
                new ManualGearbox { Brand = CarBrand.Opel, Model = "Insignia", YearOfIssue = 2009, NumberOfDoors = 4, TypeOfManualGearbox = TypeOfManualGearbox.FiveSpeed, FuelTankVolume = 70, FuelConsumption = 6.5, Price = 10600 },
                new ManualGearbox { Brand = CarBrand.Hyundai, Model = "Elantra", YearOfIssue = 2018, NumberOfDoors = 4, TypeOfManualGearbox = TypeOfManualGearbox.SixSpeed, FuelTankVolume = 50, FuelConsumption = 8, Price = 10900 },
                new AutomaticGearbox { Brand = CarBrand.MercedesBenz, Model = "C 250", YearOfIssue = 2012, NumberOfDoors = 4, TypeOfAutomaticGearbox = TypeOfAutomaticGearbox.Classic, FuelTankVolume = 48, FuelConsumption = 8.7, Price = 13500 },
                new AutomaticGearbox { Brand = CarBrand.Honda, Model = "Accord", YearOfIssue = 2016, NumberOfDoors = 4, TypeOfAutomaticGearbox = TypeOfAutomaticGearbox.Variator, FuelTankVolume = 65, FuelConsumption = 6.7, Price = 14300 },
                new AutomaticGearbox { Brand = CarBrand.Volkwagen, Model = "Jetta", YearOfIssue = 2015, NumberOfDoors = 4, TypeOfAutomaticGearbox = TypeOfAutomaticGearbox.Robotic, FuelTankVolume = 40, FuelConsumption = 6.2, Price = 11480 }
            };
        }

        public Car[] Cars { get; }
    }
}
