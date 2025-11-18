using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ExamActionController
    {
        private ExamData data;
        private Display display;

        public ExamActionController()
        {
            data = new ExamData();
            display = new Display();
        }

        public void Run()
        {
            data.ExamHour = display.ReadInt("Час на изпита: ");
            data.ExamMinute = display.ReadInt("Минути на изпита: ");
            data.ArrivalHour = display.ReadInt("Час на пристигане: ");
            data.ArrivalMinute = display.ReadInt("Минути на пристигане: ");

            int examTime = data.ExamHour * 60 + data.ExamMinute;
            int arrivalTime = data.ArrivalHour * 60 + data.ArrivalMinute;
            int diff = arrivalTime - examTime;

            if (diff > 0)
            {
                display.ShowStatus("Late");
            }
            else if (diff >= -30)
            {
                display.ShowStatus("On time");
            }
            else
            {
                display.ShowStatus("Early");
            }

            if (diff != 0)
            {
                int absDiff = Math.Abs(diff);
                int hours = absDiff / 60;
                int minutes = absDiff % 60;

                if (hours > 0)
                {
                    string formatted = $"{hours}:{minutes:D2}";
                    if (diff < 0)
                        display.ShowDifference($"{formatted} hours before the start");
                    else
                        display.ShowDifference($"{formatted} hours after the start");
                }
                else
                {
                    if (diff < 0)
                        display.ShowDifference($"{minutes} minutes before the start");
                    else
                        display.ShowDifference($"{minutes} minutes after the start");
                }
            }
        }
    }
}
