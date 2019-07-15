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
                    for (var i = 0; i < nutritions.Length; i++)
                    {
                        if (nutritions[i].Protein == maxProtein)
                        result.Add(nutritions[i]);
                    }

                }
                else 
                {
                    var minProtein = nutritions.Select(x => x.Protein).ToArray().Min();
                    for (var i = 0; i < nutritions.Length; i++)
                    {
                        if (nutritions[i].Protein == minProtein)
                        result.Add(nutritions[i]);
                }
                }
                return result.ToArray();


            
        }
        
    }
}
