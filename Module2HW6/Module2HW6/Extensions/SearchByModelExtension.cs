using Module2HW6.Models;

namespace Module2HW6.Extensions
{
    public static class SearchByModelExtension
    {
        public static Car SearchByModel(this Car[] cars, string model)
        {
            Car foundCar = null;
            for (var i = 0; i < cars.Length; i++)
            {
                if (cars[i].Model == model || cars[i].Model.ToLower() == model)
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
