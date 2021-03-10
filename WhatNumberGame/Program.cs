using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer;

            do
            {
                //переменная для хранения загаданного числа (целое число)
                int number;
                //переменная для хранения числа введенного пользователем (целое число)
                int userNumber;
                int score = 0;

                //переменная (объект) для генерации случайных чисел
                Random random = new Random();

                //помещаем в переменную number случайное число
                number = random.Next(0, 10 + 1);

                //вывод сообщения
                Console.WriteLine("Загадано число от 0 до 10");
                Console.Write("Угадайте это число: ");

                do
                {
                    //Увеличение счета на 1
                    score++;

                    //считываем с консоли строку и преобразуем ее в число
                    userNumber = int.Parse(Console.ReadLine());

                    if (userNumber != number)
                    {
                        if (userNumber > number)
                        {
                            Console.WriteLine("Загаданное число меньше, чем введенное");
                        }
                        else
                        {
                            Console.WriteLine("Загаданное число больше, чем введенное");
                        }
                        Console.Write("Попробуйте еще раз: ");
                    }
                } while (userNumber != number);

                Console.WriteLine($"Вы победили с {score} попытки");

                Console.WriteLine("Хотите сыграть еще?");
                userAnswer = Console.ReadLine();
            } while (userAnswer!="Нет");
        }
    }
}
