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
                var data = nutritions.Where(nutrition => nutrition.Calories == maxCalories);
              
                result.AddRange(data);
            }
            else
            {
                var minCalories = nutritions.Select(x => x.Calories).ToArray().Min();
                var data = nutritions.Where(nutrition => nutrition.Calories == minCalories);
                result.AddRange(data);
            }
            return result.ToArray();



        }

    }
}
