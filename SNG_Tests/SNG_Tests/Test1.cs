using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNG_Tests
{
    public class Test1 : AbstractTest
    {
        public int Number { get; set; }

        public Test1()//конструктор 
        {
            Console.WriteLine("Задание 1: Вводится целое число, обозначающее код символа по таблице ASCII.\nОпределить, это код английской буквы или какой-либо иной символ.");
        }

        override public void StartMessage() 
        {
            Console.WriteLine();
            Console.WriteLine("Enter a number from 0 to 127");
        }

        public void DefineSymbolOfASCII(int number)
        {
            if (number >= 0 && number <= 127)
            {
                char c = Convert.ToChar(number); //инициализация символа путем преобразования типов по таблице ASCII
                if (number >= 65 && number <= 90 || number >= 97 && number <= 122)
                    Console.WriteLine("This is english letter: " + c);
                else
                    Console.WriteLine(c + " - some symbol of ASCII");
            }
            else
                Console.WriteLine("You has entered a wrong value");
        }
    }
}
