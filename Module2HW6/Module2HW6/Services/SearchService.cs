using Module2HW6.Services.Abstractions;
using Module2HW6.Models;

namespace Module2HW6.Services
{
    public abstract class SearchService : ISearchService
    {
        public abstract Car Search(Car[] cars, object param);
    }
}
