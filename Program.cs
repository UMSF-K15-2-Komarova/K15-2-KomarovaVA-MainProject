using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Git_Hub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2.1. Базовi елементи мови С#. Варiант 9");

            Console.WriteLine("\nЗавдання 1. Введiть цiлi данi: ");
            Console.Write("Сумма вклада - ");
            int summa = int.Parse(Console.ReadLine());
            Console.Write("Процент по вкладу - ");
            int percent = int.Parse(Console.ReadLine());
            int sumagod = summa + (summa * percent) / 100;
            Console.WriteLine("Сума - " + sumagod + " грн.");
            Console.ReadKey();
        }

    }
}
