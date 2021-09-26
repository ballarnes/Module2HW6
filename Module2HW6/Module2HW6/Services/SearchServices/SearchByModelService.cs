using Module2HW6.Models;
using Module2HW6.Services.Abstractions;
using Module2HW6.Extensions;

namespace Module2HW6.Services.SearchServices
{
    public class SearchByModelService : SearchService, ISearchService
    {
        public override Car Search(Car[] cars, object param)
        {
            Car foundCar = cars.SearchByModel(param.ToString());
            return foundCar;
        }
    }
}
