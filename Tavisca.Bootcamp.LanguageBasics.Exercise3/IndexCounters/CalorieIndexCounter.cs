using System.Collections.Generic;
using System.Linq;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise3
{
    public class CalorieIndexCounter : INutritionSelector
    {

        Nutrition[] INutritionSelector.GetNutritions(Nutrition[] nutritions, string parameter)
        {

            var result = new List<Nutrition>();
            if (parameter.Equals("T"))
            {
                var maxCalories = nutritions.Select(x => x.Calories).ToArray().Max();
                return nutritions.Where(nutrition => nutrition.Calories == maxCalories).ToArray();
              
            }
            else
            {
                var minCalories = nutritions.Select(x => x.Calories).ToArray().Min();
               return nutritions.Where(nutrition => nutrition.Calories == minCalories).ToArray();
            }



        }

    }
}
