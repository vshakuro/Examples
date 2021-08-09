using System;


namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Exercise1();
        }
        static void Exercise1()
        {
            Console.WriteLine("Условие:\nЗадано значение длины отрезка в метрах и миллиметрах. Найти ее величину в дюймах.\n");
            Console.WriteLine("Введите значение длины отрезка в метрах:");
            double lenghtMeters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение длины отрезка в миллиметрах:");
            double lenghtMillimeters = Convert.ToDouble(Console.ReadLine());
            double lenghtInches = (lenghtMeters * 1000 + lenghtMillimeters) / 25.4;
            Console.WriteLine($"Значение в дюймах = {lenghtInches}");
        }

        static void Exercise2()
        {

        }
    }
}
