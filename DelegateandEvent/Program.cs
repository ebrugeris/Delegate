using System;
using System.Collections.Generic;
using static Delegate.MulticastDelagate;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            // GreetingMessages sınıfından bir örnek oluştur
            MulticastDelagate greetingMessages = new MulticastDelagate();

            // Multicast delegate'i kullanarak selamlama mesajlarını gösteriyoruz
            greetingMessages.ExecuteGreetings("Ali");  // Çıktı: Hello, Ali! Goodbye, Ali!




            // FuncDelegate sınıfından bir örnek oluştur
            FuncDelegate idealWeightDelegate = new FuncDelegate();

            // Func delegate'i kullanarak ideal ağırlığı hesaplıyoruz
            idealWeightDelegate.ExecuteIdealWeightDelegate(170, 30);  // Çıktı: Ideal weight for height 170 cm and age 30 is: 57 kg




            // PredicateDelegate sınıfından bir örnek oluştur
            PredicateDelegate calorieChecker = new PredicateDelegate();

            // Öğün kalorilerini bir liste halinde tanımlıyoruz
            List<int> mealCalories = new List<int> { 450, 600, 350, 700 };

            // Predicate delegate'i kullanarak kalori kontrolü yapıyoruz
            calorieChecker.ExecuteCalorieCheck(mealCalories);




            // ActionDelegate sınıfından bir örnek oluştur
            ActionDelegate healthReminders = new ActionDelegate();

            // Action delegate'leri kullanarak hatırlatma mesajlarını gösteriyoruz
            healthReminders.ExecuteHealthReminders();
        }
    }
}
