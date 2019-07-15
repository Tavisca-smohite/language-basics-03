using System.Collections.Generic;
using System.Linq;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise3
{
    public class ProteinIndexCounter : INutritionSelector
    {

        Nutrition[] INutritionSelector.GetNutritions(Nutrition[] nutritions, string parameter)
        {

            var result = new List<Nutrition>();
            if (parameter.Equals("P"))
            {
                var maxProtein = nutritions.Select(x => x.Protein).ToArray().Max();
                var data = nutritions.Where(nutrition => nutrition.Calories == maxProtein);
                result.AddRange(data);
            }
            else
            {
                var minProtein = nutritions.Select(x => x.Protein).ToArray().Min();
                var data = nutritions.Where(nutrition => nutrition.Calories == minProtein);
                result.AddRange(data);
            }
            return result.ToArray();



        }

    }
}
