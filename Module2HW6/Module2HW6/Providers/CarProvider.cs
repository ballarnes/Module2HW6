using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Enums;
using Module2HW6.Models;
using Module2HW6.Models.ClosedBodyType.Coupe.ExecutiveCoupe;
using Module2HW6.Models.ClosedBodyType.Coupe.SportsCoupe;
using Module2HW6.Models.ClosedBodyType.Minivan;
using Module2HW6.Models.ClosedBodyType.Sedan;
using Module2HW6.Models.OpenBodyType.Cabriolet;
using Module2HW6.Models.OpenBodyType.Spider;
using Module2HW6.Providers.Abstractions;

namespace Module2HW6.Providers
{
    public class CarProvider : ICarProvider
    {
        public CarProvider()
        {
            Cars = new Car[]
            {
                new ExecutiveCoupe { Brand = CarBrand.BMW, Model = "M4", FuelConsumption = 8.7, IsHaveSunRoof = true, TypeOfBackRow = TypeOfBackRow.Absent, TypeOfCoupe = TypeOfCoupe.CombiCoupe, YearOfIssue = 2020, Price = 45000 },
                new SportsCoupe { Brand = CarBrand.Honda, Model = "Civic Si", FuelConsumption = 8.2, IsHaveSunRoof = true, IsParticipatesInRaces = true, TypeOfCoupe = TypeOfCoupe.TwoDoorCoupe, YearOfIssue = 2017, Price = 23900 },
                new Minivan { Brand = CarBrand.Volkwagen, Model = "Transporter T6", FuelConsumption = 7.8, IsHaveSunRoof = true, NumberOfPassengeSeats = 9, YearOfIssue = 2016, Price = 17900 },
                new Minivan { Brand = CarBrand.Volkwagen, Model = "Transporter T5", FuelConsumption = 7.7, IsHaveSunRoof = false, NumberOfPassengeSeats = 89, YearOfIssue = 2015, Price = 15500 },
                new Sedan { Brand = CarBrand.Opel, Model = "Insignia", FuelConsumption = 6.9, IsHaveSunRoof = true, ClassOfSedan = ClassOfSedan.DClass, YearOfIssue = 2015, Price = 13000 },
                new Sedan { Brand = CarBrand.Hyundai, Model = "Accent", FuelConsumption = 7.3, IsHaveSunRoof = true, ClassOfSedan = ClassOfSedan.DClass, YearOfIssue = 2013, Price = 8400 },
                new Sedan { Brand = CarBrand.Toyota, Model = "Camry", FuelConsumption = 8.0, IsHaveSunRoof = true, ClassOfSedan = ClassOfSedan.EClass, YearOfIssue = 2015, Price = 19900 },
                new Cabriolet { Brand = CarBrand.Porsche, Model = "911 GTS", FuelConsumption = 9.5, IsHaveFoldingRoof = false, TypeOfCabriolet = TypeOfCabriolet.Targa, YearOfIssue = 2010, Price = 59250 },
                new Spider { Brand = CarBrand.Porsche, Model = "918", FuelConsumption = 9.2, IsHaveFoldingRoof = true, RoofFabric = "Sonnenland", YearOfIssue = 2018, Price = 98300 }
            };
        }

        public Car[] Cars { get; }
    }
}
