using System;

class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        string destination = "";
        string place = "";
        double spentMoney = 0;

        if (budget <= 100)
        {
            destination = "Bulgaria";

            if (season == "summer")
            {
                place = "Camp";
                spentMoney = budget * 0.30;
            }
            else
            {
                place = "Hotel";
                spentMoney = budget * 0.70;
            }
        }
        else if (budget <= 1000)
        {
            destination = "Balkans";

            if (season == "summer")
            {
                place = "Camp";
                spentMoney = budget * 0.40;
            }
            else
            {
                place = "Hotel";
                spentMoney = budget * 0.80;
            }
        }
        else
        {
            destination = "Europe";
            place = "Hotel";
            spentMoney = budget * 0.90;
        }

        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{place} - {spentMoney:F2}");
    }
}
