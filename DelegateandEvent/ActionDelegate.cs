using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class ActionDelegate
    {
        // Action delegate: Geri dönüş değeri olmayan bir metod tanımlıyoruz
        public Action DisplayHydrationReminder;
        public Action DisplayExerciseReminder;
        public Action DisplaySleepReminder;

        public ActionDelegate()
        {
            // Action delegate'lerine ilgili metotları atıyoruz
            DisplayHydrationReminder = HydrationReminder;
            DisplayExerciseReminder = ExerciseReminder;
            DisplaySleepReminder = SleepReminder;
        }

        // Su içme hatırlatma mesajı
        public void HydrationReminder()
        {
            Console.WriteLine("Remember to drink 8 glasses of water today!");
        }

        // Egzersiz hatırlatma mesajı
        public void ExerciseReminder()
        {
            Console.WriteLine("Don't forget to do 30 minutes of exercise today!");
        }

        // Uyku hatırlatma mesajı
        public void SleepReminder()
        {
            Console.WriteLine("Make sure to get 7-8 hours of sleep tonight!");
        }

        // Action delegate'lerini kullanarak hatırlatıcı mesajlarını gösterme
        public void ExecuteHealthReminders()
        {
            DisplayHydrationReminder?.Invoke();
            DisplayExerciseReminder?.Invoke();
            DisplaySleepReminder?.Invoke();
        }

    }
}
