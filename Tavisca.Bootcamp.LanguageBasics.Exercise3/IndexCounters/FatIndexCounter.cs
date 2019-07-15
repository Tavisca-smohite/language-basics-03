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
                for (var i = 0; i < nutritions.Length; i++)
                {
                    if (nutritions[i].Fat == maxFats)
                        result.Add(nutritions[i]);
                }

            }
            else
            {
                var minFats = nutritions.Select(x => x.Fat).ToArray().Min();
                for (var i = 0; i < nutritions.Length; i++)
                {
                    if (nutritions[i].Fat == minFats)
                        result.Add(nutritions[i]);
                }
            }
            return result.ToArray();



        }

    }
}
