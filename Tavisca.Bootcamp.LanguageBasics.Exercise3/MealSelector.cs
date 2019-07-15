using System;
using System.Linq;
using System.Collections.Generic;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise3
{
    public static class MealSelector
    {
        public static int[] SelectMeals(int[] proteins, int[] carbs, int[] fat, string[] dietPlans)
        {
            var nutritions = GetNutritions(proteins, carbs, fat);
            var results = new int[dietPlans.Length];
            for (int dietCounter = 0; dietCounter < dietPlans.Length; dietCounter++)
            {
                var diet = dietPlans[dietCounter];
             

                if (string.IsNullOrWhiteSpace(diet))
                {
                    results[dietCounter] = 0;
                }
                else
                {
                  var index=  GetIndexForDietPlan(nutritions, results, dietCounter, diet);
                    results[dietCounter] = index;
                }



            }
            return results;
        }

        private static int GetIndexForDietPlan(Nutrition[] nutritions, int[] results, int dietCounter, string diet)
        {
            var indexTrack = new List<int>();
            var nutritionArray = nutritions;
            for (var dietFactor = 0; dietFactor < diet.Length; dietFactor++)
            {
                var parameter = diet[dietFactor].ToString();
                Nutrition[] indexes = GetNutrionForDiet(nutritionArray, parameter);
                if (indexes.Length == 1)
                {
                    indexTrack.Add(indexes[0].IndexTracker);
                    break;
                }
                else
                {
                    nutritionArray = new Nutrition[indexes.Length];
                    nutritionArray = indexes;
                }
                if (dietFactor == diet.Length - 1)
                {
                    indexTrack.AddRange(indexes.Select(x => x.IndexTracker));
                }
            }
            return indexTrack.Min();
        }

        private static Nutrition[] GetNutrionForDiet(Nutrition[] nutritionArray, string parameter)
        {
            var counter = IndexCounterFactory.GetIndexCounter(parameter);
            var indexes = counter.GetNutritions(nutritionArray, parameter);
            return indexes;
        }

        //convert all arrays to list /array of nutrition class
        private static Nutrition[] GetNutritions(int[] proteins, int[] carbs, int[] fat)
        {
            var nutritions = new Nutrition[proteins.Length];
            
            for (int counter = 0; counter < proteins.Length; counter++)
            {
                nutritions[counter] = new Nutrition(proteins[counter], carbs[counter], fat[counter], counter);
            }

            return nutritions;
        }
    }
}
