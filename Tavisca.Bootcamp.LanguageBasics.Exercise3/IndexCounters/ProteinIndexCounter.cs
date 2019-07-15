using System.Collections.Generic;
using System.Linq;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise3
{
    public class ProteinIndexCounter : INutritionSelector
    {

        Nutrition[] INutritionSelector.GetNutritions(Nutrition[] nutritions, string parameter)
        {

            if (parameter.Equals("P"))
            {
                var maxProtein = nutritions.Select(x => x.Protein).ToArray().Max();
               return  nutritions.Where(nutrition => nutrition.Protein == maxProtein).ToArray();
            }
            else
            {
                var minProtein = nutritions.Select(x => x.Protein).ToArray().Min();
                return nutritions.Where(nutrition => nutrition.Protein == minProtein).ToArray();
            }          
        }

    }
}
