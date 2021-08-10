using System;


namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Exercise2();
        }
        static void Exercise1()
        {
            const double MilimetersInOneInch = 25.4;
            Console.WriteLine("Задача 1:\nЗадано значение длины отрезка в метрах и миллиметрах. Найти ее величину в дюймах.\n");
            Console.WriteLine("Введите значение длины отрезка в метрах:");
            double lenghtMeters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение длины отрезка в миллиметрах:");
            double lenghtMillimeters = Convert.ToDouble(Console.ReadLine());
            double lenghtInches = (lenghtMeters * 1000 + lenghtMillimeters) / MilimetersInOneInch;
            Console.WriteLine($"Значение в дюймах = {lenghtInches}");
        }

        static void Exercise2()
        {
            Console.WriteLine("Задача 2:\nЗадана длительность интервала времени в годах, месяцах и днях. Найти его величину в днях.");
            Console.WriteLine("Введите значение в годах");
            long yearsInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение в месяцах");
            long monthesInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение в днях");
            long daysInput = Convert.ToInt32(Console.ReadLine());
            long valueInDays = yearsInput * 365 + monthesInput * 30 + daysInput;
            Console.WriteLine($"Величина в днях {valueInDays}");
        }
    }
}
