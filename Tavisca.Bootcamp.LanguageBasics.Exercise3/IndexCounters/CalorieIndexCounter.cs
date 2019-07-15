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

                for (var i = 0; i < nutritions.Length; i++)
                {
                    if (nutritions[i].Calories == maxCalories)
                        result.Add(nutritions[i]);
                }

            }
            else
            {
                var minCalories = nutritions.Select(x => x.Calories).ToArray().Min();
                for (var i = 0; i < nutritions.Length; i++)
                {
                    if (nutritions[i].Calories == minCalories)
                        result.Add(nutritions[i]);
                }
            }
            return result.ToArray();



        }

    }
}
