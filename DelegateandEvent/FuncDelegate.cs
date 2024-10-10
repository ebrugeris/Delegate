using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class FuncDelegate
    {
        // Func delegate tanımı: Boy ve yaş parametre alır ve ideal ağırlığı döndürür
        public Func<double, int, double> CalculateIdealWeight;

        public FuncDelegate()
        {
            // Func delegate'e bir metot atıyoruz
            CalculateIdealWeight = GetIdealWeight;
        }

        // Metot: Boy ve yaş bilgisi ile ideal ağırlığı hesaplıyor
        public double GetIdealWeight(double height, int age)
        {
            // Basit bir hesaplama: Boy (cm) - 100 + (Yaş / 10)
            double idealWeight = height - 100 + (age / 10.0);
            return idealWeight;
        }

        // Func delegate'i kullanarak ideal ağırlığı hesaplama örneği
        public void ExecuteIdealWeightDelegate(double height, int age)
        {
            double idealWeight = CalculateIdealWeight(height, age);
            Console.WriteLine($"Ideal weight for height {height} cm and age {age} is: {idealWeight} kg");
        }
    }
}
