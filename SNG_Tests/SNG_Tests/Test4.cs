using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNG_Tests
{
    class Test4 : AbstractTest
    {
        public int Number { get; set; }
        public Test4()
        {
            Console.WriteLine("Задание 4: Написать функцию, которая определяет количество разрядов введенного целого числа.");
        }

        override public void StartMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Enter a number from -2147483647 to 2147483647");
        }

        public void GetAmountOfNumberRanks(int number)
        {
            if (number >= -2147483647 && number <= 2147483647)
            {
                if (number < 0)
                    number = -number;
                
                int i = 0;
                while (number > 0)
                {
                    number = number / 10;
                    i++;
                }
                Console.WriteLine("Amount of ranks your number: " + i);
            }
            else
                Console.WriteLine("You has entered a wrong value");
        }
    }
}
