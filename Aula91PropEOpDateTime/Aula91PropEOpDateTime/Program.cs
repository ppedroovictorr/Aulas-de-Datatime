using System;

namespace Aula91PropEOpDateTime {
    class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(2021, 12, 14, 10, 30, 58, 275);
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            //---------------------------------------------------------------------------------------------
            string s5 = d.ToString();
            // abaixo criando uma máscara de formatação
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss"); // existem 4 sobrecargas (formatações padrões).
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //---------------------------------------------------------------------------------------------
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);
            DateTime d4 = d.AddDays(7);
            DateTime d5 = new DateTime(2021, 12, 26);
            TimeSpan t = d5.Subtract(d);

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind); // por padrão o tipo é local (tipos: local ou global)
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);  // é um TimeSpan
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(d.ToLongDateString()); // é possível imprimir o valor formatado sem atribuir a outra váriavel
            Console.WriteLine(s1);// imprime a data no formato completo
            Console.WriteLine(s2);// imprime o horário no formato completo (hora, minuto, segundo
            Console.WriteLine(s3); // imprime a data no formato simplificado
            Console.WriteLine(s4); // imprime o horário no formato simplificado (hora e minuto
            Console.WriteLine(s5); // formato padrão - data e horario
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("criando máscara de formatação própria");
            Console.WriteLine(s6); // impressa no  formato personalizado
            Console.WriteLine(s7); // impressa no  formato personalizado
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("criando operações com 'DateTime()'");
            Console.WriteLine("Primeira hora definida (d): "+d);
            Console.WriteLine("d.AddHour(2) - adicionando duas horas: " + d2);
            Console.WriteLine("d.AddMinutes(3) - adicionando três minutos: " + d3);
            Console.WriteLine("d.AddDays(7) - adicionando 1 semana (7 dias): " + d4);
            Console.WriteLine("subtraiu com 'Subtract()' e calculou a diferença entre a data inicial (d) e a final (d5): Oresultado é uma função TimeSpan" );
            Console.WriteLine(t);
            Console.WriteLine("---------------------------------------------");
        }
    }
}
