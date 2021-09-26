using Module2HW6.Enums;

namespace Module2HW6.Models
{
    public class Car
    {
        public CarBrand Brand { get; init; }
        public string Model { get; init; }
        public double FuelConsumption { get; init; }
        public double Price { get; init; }
        public int YearOfIssue { get; init; }
    }
}
