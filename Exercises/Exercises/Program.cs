﻿using System;


namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            menuCall();
        }
        static void Exercise1()
        {
            const double MilimetersInOneInch = 25.4;
            Console.WriteLine("\nЗадача 1:\nЗадано значение длины отрезка в метрах и миллиметрах. Найти ее величину в дюймах.\n");
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
            long yearsInput = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введите значение в месяцах");
            long monthesInput = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введите значение в днях");
            long daysInput = Convert.ToInt64(Console.ReadLine());
            long valueInDays = yearsInput * 365 + monthesInput * 30 + daysInput;
            Console.WriteLine($"Величина в днях {valueInDays}");
        }

        static void Switcher(int taskNumber)
        {
            switch (taskNumber)
            {
                case 1:
                    Exercise1();
                    break;
                case 2:
                    Exercise2();
                    break;
                default:
                    {
                        Console.WriteLine("\nНеправильное число\n");
                        break;
                    }
            }
        }

        static void menuCall()
        {
            bool exitProgram = false;
            while (exitProgram == false)
            {
                taskChoice();
                Console.WriteLine("\nВыйти?\n1-Да, 2-Нет, продолжить");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == 1)
                {
                    exitProgram = true;
                }
                else
                {
                    while (userChoice != 1 && userChoice != 2)
                    {
                        Console.WriteLine("\nВведите 1(Выйти) или 2(Продолжить)");
                        userChoice = Convert.ToInt32(Console.ReadLine());
                    }
                    if (userChoice == 1)
                    {
                        exitProgram = true;
                    }
                    else
                    {
                        exitProgram = false;
                    }
                }
            }
        }

        static void taskChoice()
        {
            int taskNumber;
            do
            {
                Console.WriteLine("Выберите задачу, которую хотите решить:\n1-Задача 1 (Длина отрезка)\n2-Задача 2 (Сумма дней)\n");
                taskNumber = Convert.ToInt32(Console.ReadLine());
                Switcher(taskNumber);
            }
            while (taskNumber != 1 && taskNumber != 2);
        }
    }
}
