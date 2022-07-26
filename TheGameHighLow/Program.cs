using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGameHighLow
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Привет! Хочешь сыграть в больше-меньше?");
            Random rnd = new Random();
            Console.WriteLine("Загадываю число");
            int rChislo = rnd.Next(0, 100);
            Console.WriteLine("Я загадала число от 0 до 100, отгадай его!");
            int hod = 0;
            int chislo;
            do
            {
                chislo = Convert.ToInt32(Console.ReadLine());
                if (chislo > rChislo)
                    Console.WriteLine("Мое число меньше");
                else if (chislo < rChislo)
                    Console.WriteLine("Мое число больше");
                else if (chislo > 100 || chislo < 0)
                    Console.WriteLine("Ваше число выходит за пределы");
                hod++;
            } while (chislo != rChislo);
            if (chislo == rChislo)
                Console.WriteLine("Вы угадали число за " + hod + " кол-во ходов");
            Console.ReadLine();
        }
    }
}