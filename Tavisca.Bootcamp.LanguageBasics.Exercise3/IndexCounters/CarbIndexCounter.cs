using System.Collections.Generic;
using System.Linq;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise3
{
    public class CarbIndexCounter : INutritionSelector
    {

        Nutrition[] INutritionSelector.GetNutritions(Nutrition[] nutritions, string parameter)
        {

            var result = new List<Nutrition>();
            if (parameter.Equals("C"))
            {
                
                var maxCarb = nutritions.Select(x => x.Carb).ToArray().Max();
                var data=nutritions.Where(nutrition => nutrition.Carb == maxCarb);
                result.AddRange(data);
            }
            else
            {
                var minCarbs= nutritions.Select(x => x.Carb).ToArray().Min();
                var data = nutritions.Where(nutrition => nutrition.Carb == minCarbs);
                result.AddRange(data);
            }
            return result.ToArray();



        }

    }
}
