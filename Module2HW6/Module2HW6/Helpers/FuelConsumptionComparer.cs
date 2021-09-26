using System.Collections;
using Module2HW6.Models;

namespace Module2HW6.Helpers
{
    public class FuelConsumptionComparer : IComparer
    {
        public int Compare(object obj1, object obj2)
        {
            var car1 = obj1 as Car;
            var car2 = obj2 as Car;

            if (car1.FuelConsumption > car2.FuelConsumption)
            {
                return 1;
            }
            else if (car1.FuelConsumption < car2.FuelConsumption)
            {
                return -1;
            }

            return 0;
        }
    }
}
