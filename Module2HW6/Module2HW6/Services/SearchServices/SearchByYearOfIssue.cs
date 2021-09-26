using System;
using Module2HW6.Models;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services.SearchServices
{
    public class SearchByYearOfIssue : SearchService, ISearchService
    {
        public override Car Search(Car[] cars, object yearOfIssue)
        {
            Car foundCar = null;
            for (var i = 0; i < cars.Length; i++)
            {
                if (cars[i].YearOfIssue == Convert.ToInt32(yearOfIssue))
                {
                    foundCar = cars[i];
                    break;
                }
                else
                {
                    i++;
                }
            }

            return foundCar;
        }
    }
}
