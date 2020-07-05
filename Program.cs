using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;



namespace PomodoroTimer
{
    class Program
    {


        public static void Main()
        {
            Console.WriteLine("Введите количество циклов");
            Console.WriteLine("Длительность цикла работы");
#pragma warning disable CA1305 // Укажите IFormatProvider
            new Pomodoro(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())).Start() ;
#pragma warning restore CA1305 // Укажите IFormatProvider

            Console.ReadLine();
        }



    }
}
