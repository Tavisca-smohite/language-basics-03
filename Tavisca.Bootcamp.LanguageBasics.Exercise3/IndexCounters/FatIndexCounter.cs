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
                return nutritions.Where(nutrition => nutrition.Fat == maxFats).ToArray();
                
            }
            else
            {
                var minFats = nutritions.Select(x => x.Fat).ToArray().Min();
                return nutritions.Where(nutrition => nutrition.Fat == minFats).ToArray();
            
            }
            
        }

    }
}
