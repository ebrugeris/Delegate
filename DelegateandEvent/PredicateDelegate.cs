using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class PredicateDelegate
    {
        // Predicate delegate: Belirli bir kalori limitinin altında olup olmadığını kontrol eder
        public Predicate<int> IsUnderCalorieLimit;

        public PredicateDelegate()
        {
            // Predicate delegate'e bir metot atıyoruz
            IsUnderCalorieLimit = CheckCalorieLimit;
        }

        // Belirlenen kalori limitine göre kontrol yapılıyor (örneğin 500 kalori)
        private bool CheckCalorieLimit(int calories)
        {
            int calorieLimit = 500; // Kalori limiti
            return calories < calorieLimit;
        }

        // Predicate delegate'i kullanarak öğünlerin kalorisini kontrol etme
        public void ExecuteCalorieCheck(List<int> mealCalories)
        {
            foreach (int calories in mealCalories)
            {
                if (IsUnderCalorieLimit(calories))
                {
                    Console.WriteLine($"{calories} calories: Within the goal.");
                }
                else
                {
                    Console.WriteLine($"{calories} calories: Calorie limit exceeded!");
                }
            }
        }
    }
}
