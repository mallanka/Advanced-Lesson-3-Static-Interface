﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_3_Static_Interface
{
    public partial class Practice
    {
        /// <summary>
        /// AL3-P1/3. Создать класс UniqueItem c числовым полем Id. 
        /// Каждый раз, когда создается новый экземпляр данного класса, 
        /// его идентификатор должен увеличиваться на 1 относительно последнего созданного. 
        /// Приложение должно поддерживать возможность начать идентификаторы с любого числа. 
        /// </summary>
        public static void AL3_P1_3()
        {
        }

        /// <summary>
        /// AL3-P2/3. Отредактировать консольное приложение Printer. 
        /// Заменить базовый абстрактный класс на интерфейс.
        /// </summary>
        public static void AL3_P2_3()
        {

        }


        /// <summary>
        /// AL3-P3/3. Создайте обобщенный метод GuessType<T>(T item), 
        /// который будет принимать переменную обобщенного типа и выводить на консоль, 
        /// что это за тип был передан.
        /// </summary>
        public static void AL3_P3_3()
        {
        }

        static public void GuessType<T>(T item)             //AL3-P3/3. GuessType
        {
            switch (item)
            {
                case string x:
                    Console.WriteLine($"it is a string of {x.Length} symbols");
                    break;
                case int x:
                    Console.WriteLine("you entered a positive integer");
                    break;
                case decimal x:
                    decimal temp = x - Math.Truncate(x);
                    int count = 0;
                    while (temp > 0)
                    {
                        temp *= 10;
                        temp = temp - Math.Truncate(temp);
                        count++;
                    }
                    Console.WriteLine($"you entered a floating-point number with {count} digits after point");
                    break;
                case DateTime x:
                    Console.WriteLine($"you entered the time {x}");
                    break;
                default:
                    Console.WriteLine("i don't know what did you enter");
                    break;
            }
        }
    }    
}
