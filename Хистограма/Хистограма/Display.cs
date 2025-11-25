using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histograma

{
    public class Display
    {
        public int ReadInt(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Input cannot be empty.");

            if (!int.TryParse(input.Trim(), out int value))
                throw new ArgumentException($"Invalid integer input: '{input}'.");

            return value;
        }

        public double ReadDouble(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Input cannot be empty.");

            if (!double.TryParse(input.Trim().Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double value))
            {
                if (!double.TryParse(input.Trim(), out value))
                    throw new ArgumentException($"Invalid floating-point input: '{input}'.");
            }

            return value;
        }

        public void ShowPercentage(double percent)
        {
            Console.WriteLine($"{percent:F2}%");
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
