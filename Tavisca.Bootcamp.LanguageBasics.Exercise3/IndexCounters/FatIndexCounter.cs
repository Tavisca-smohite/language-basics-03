using System.Collections.Generic;
using System.Linq;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise3
{
    public class FatIndexCounter : INutritionSelector
    {

        Nutrition[] INutritionSelector.GetNutritions(Nutrition[] nutritions, string parameter)
        {

            var result = new List<Nutrition>();
            if (parameter.Equals("F"))
            {
                var maxFats = nutritions.Select(x => x.Fat).ToArray().Max();
                var data = nutritions.Where(nutrition => nutrition.Calories == maxFats);

                result.AddRange(data);
            }
            else
            {
                var minFats = nutritions.Select(x => x.Fat).ToArray().Min();
                var data = nutritions.Where(nutrition => nutrition.Calories == minFats);
                result.AddRange(data);
            
            }
            return result.ToArray();



        }

    }
}
