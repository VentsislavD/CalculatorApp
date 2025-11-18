using PasswordGeneratorMVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class PasswordActionController
    {
        private PasswordData data;
        private Display display;

        public PasswordActionController()
        {
            data = new PasswordData();
            display = new Display();
        }

        public void Run()
        {
            data.N = display.ReadInt("Въведете n: ");
            data.L = display.ReadInt("Въведете l: ");

            GeneratePasswords();
        }

        private void GeneratePasswords()
        {
            for (int a = 1; a <= data.N; a++)
            {
                for (int b = 1; b <= data.N; b++)
                {
                    for (char c = 'a'; c < 'a' + data.L; c++)
                    {
                        for (char d = 'a'; d < 'a' + data.L; d++)
                        {
                            for (int e = 1; e <= data.N; e++)
                            {
                                if (e > a && e > b)
                                {
                                    string password = $"{a}{b}{c}{d}{e}";
                                    display.ShowPassword(password);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
