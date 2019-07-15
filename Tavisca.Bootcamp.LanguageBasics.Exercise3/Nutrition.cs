using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise3
{
    public class Nutrition
    {
        public int Protein { get;  }
        public int Carb { get; }
        public int Fat { get;  }
        public int IndexTracker { get; }
        public int Calories
        {
            get
            {
                return CalculateCalories();
            }
        }

        
        public Nutrition(int protein, int carbs, int fat, int indexTracker)
        {
            this.IndexTracker = indexTracker;
            this.Protein = protein;
            this.Carb = carbs;
            this.Fat = fat;

        }

        private int CalculateCalories()
        {
            return (5 * this.Protein) + (5 * this.Carb) + (9 * this.Fat);
        }
    }
}
