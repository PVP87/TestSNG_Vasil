using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNG_Tests
{
    class Test3 : AbstractTest
    {
        int[] arrNumber = new int [20];
        int maxNumberOfArray;
        
        public Test3()
        {
            Console.WriteLine("Задание 3: Создать массив из 20 элементов в диапазоне (случайным образом)  значений от -15 до 14 включительно.\n" +
                              "Определить количество элементов по модулю больших, чем максимальный.");
            Console.WriteLine();
            CreateRandomArray();
            GetModulesOfAllNumbers(arrNumber);
        }
        
        private void CreateRandomArray()
        {
            Random rand = new Random();

            for (int i = 0; i < arrNumber.Length; i++)
                arrNumber[i] = rand.Next(-15, 14);

            Console.WriteLine("Set of random numbers:");
            foreach (var arr in arrNumber)
                Console.Write(arr + "  ");
            Console.WriteLine();

            maxNumberOfArray = arrNumber.Max();
            Console.WriteLine($"Maximal nymber: {maxNumberOfArray}");
        }

        public void DefineAmountOfNumbersWhichBigerThanMaxNumber()
        {
            int amount = 0;

            foreach (var arr in arrNumber)
                if (arr > maxNumberOfArray)
                    amount++;
            Console.WriteLine($"Amount of numbers which biger than Max number by modul: {amount}");
        }

        private void GetModulesOfAllNumbers(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0)
                    array[i] = -array[i];
            
            Console.WriteLine("Moduls of random numbers:");
            foreach (var arr in arrNumber)
                Console.Write(arr + "  ");
            Console.WriteLine();
        }
    }
}
