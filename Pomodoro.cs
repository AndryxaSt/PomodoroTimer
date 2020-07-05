using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace PomodoroTimer
{
    class Pomodoro
    {
        double quantity;
        double loop;
        double duration;

        public void Start()
        {
            if (loop < quantity)
            {
                Work();
            }
        }
        async private void Work()
        {
            Console.WriteLine(DateTime.Now + " Start Work");
            Console.Title = "Work";

            await Task.Delay(delay: TimeSpan.FromMinutes(duration));
            Console.Beep(500, 1000);
            Rest();
        }

        async private void Rest()
        {
            Console.WriteLine(DateTime.Now + " Start Rest");
            Console.Title = "Rest";
            Console.WriteLine();

            loop++;
            await Task.Delay(TimeSpan.FromMinutes((loop % 4 == 0) ? duration : duration/5));
            Console.Beep(500, 350);
            Console.Beep(500, 350);
            Start();
        }

        public Pomodoro(double quantity, double duration)
        {
            this.duration = duration;
            this.quantity = quantity;
            Console.WriteLine($"{quantity} циклов по {duration + duration / 5} минут каждый");
        }



    }
}
