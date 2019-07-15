using System;
using System.Text;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise3
{
    public class IndexCounterFactory
    {
        public static INutritionSelector GetIndexCounter(string parameter)
        {
            switch (parameter.ToLower())
            {
                case "p":
                    return new ProteinIndexCounter();

                case "c":
                    return new CarbIndexCounter();
                case "f":
                    return new FatIndexCounter();
                case "t":
                    return new CalorieIndexCounter();
                default:
                    throw new Exception("Unexpected chanracter provided in a request");
            }
        }
    }
}
