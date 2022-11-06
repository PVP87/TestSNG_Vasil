using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SNG_Tests
{
    public class Test2 : AbstractTest
    {
        public int Number { get; set; }

        public Test2()//конструктор 
        {
            Console.WriteLine("Задание 2: С клавиатуры вводится натуральное число. Найти его наибольшую цифру.\nНапример, введено число 764580. Наибольшая цифра в нем 8.");
        }

        override public void StartMessage()//переопределение абстрактного метода абстрактного класса
        {
            Console.WriteLine();
            Console.WriteLine("Enter a number from 0 to 2147483647");
        }

        public void DefineMaxValueOfNumber(int number)
        {
            if (number >= 0 && number <= 2147483647)
            {
                string s = Convert.ToString(number); //инициализация символа путем преобразования типов по таблице ASCII
                int[] arrNum = new int[s.Length];

                int i = 0;//цикл создания массива типа int
                foreach (var arr in s)
                {
                    arrNum[i] = Convert.ToInt32(arr-48);//-48 так как DEC 49 = char 1
                    i++;
                }

                int maxValue = arrNum.Max();
                Console.WriteLine("max value of your number is: " + maxValue);
            }
            else
                Console.WriteLine("You has entered a wrong value");
        }
    }
}
