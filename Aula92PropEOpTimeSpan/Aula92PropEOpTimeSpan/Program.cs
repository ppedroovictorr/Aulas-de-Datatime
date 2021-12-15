using System;
using System.Globalization;

namespace Aula92PropEOpTimeSpan {
    class Program {
        static void Main(string[] args) {

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);



            //-----------------------------------------
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            //-----------------------------------------
            TimeSpan t4 = new TimeSpan(1, 30, 10);
            TimeSpan t5 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t4.Add(t5);
            TimeSpan dif = t4.Subtract(t5);
            TimeSpan mult = t5.Multiply(2.0);
            TimeSpan div = t5.Divide(2.0);

            //-----------------------------------------
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine("-------------------------------");
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("------------------------------");
            Console.WriteLine("TotalDays: " + t.TotalDays); // imprime o total correspondente as fraçoes de tempo
            Console.WriteLine("TotalHours: " + t.TotalHours); // imprime o total correspondente as fraçoes de tempo
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes); // imprime o total correspondente as fraçoes de tempo
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds); // imprime o total correspondente as fraçoes de tempo
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds); // imprime o total correspondente as fraçoes de tempo
            Console.WriteLine("------------------------------");
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);






        }
    }
}
