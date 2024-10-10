using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class MulticastDelagate
    {
        // Kendi delegate'imizi tanımlıyoruz
        public delegate void GreetingDelegate(string name);

            // GreetingDelegate türünde bir multicast delegate tanımlıyoruz
            public GreetingDelegate Greet;

            public MulticastDelagate()
            {
                // Multicast delegate'e metotları ekliyoruz
                Greet += SayHello;
                Greet += SayGoodbye;
            }

            // 'Merhaba' mesajı
            public void SayHello(string name)
            {
                Console.WriteLine($"Hello, {name}!");
            }

            // 'Hoşça kal' mesajı
            public void SayGoodbye(string name)
            {
                Console.WriteLine($"Goodbye, {name}!");
            }

            // Multicast delegate'i çalıştırarak tüm mesajları gösterme
            public void ExecuteGreetings(string name)
            {
                // Delegate'in birleştirdiği tüm metotları çağırıyoruz
                Greet?.Invoke(name);
            }
        }
}
