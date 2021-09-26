using Module2HW6.Models;

namespace Module2HW6.Services.Abstractions
{
    public interface ISearchService
    {
        public abstract Car Search(Car[] cars, object param);
    }
}
