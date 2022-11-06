using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNG_Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1:
            Test1 t1 = new Test1();
            int i = 1;
            while (i == 1)
            {
                t1.StartMessage();
                t1.Number = (int)t1.ChekRightEnter(Console.ReadLine());
                t1.DefineSymbolOfASCII(t1.Number);
                i = t1.QuestionAboutStartAgain();
            }

            //задание 2:
            Test2 t2 = new Test2();
            int j = 1;
            while (j == 1)
            {
                t2.StartMessage();
                t2.Number = (int)t2.ChekRightEnter(Console.ReadLine());
                t2.DefineMaxValueOfNumber(t2.Number);
                j = t2.QuestionAboutStartAgain();
            }

            //задание 3:
            int l = 1;
            while (l == 1)
            {
                Test3 t3 = new Test3();
                t3.DefineAmountOfNumbersWhichBigerThanMaxNumber();
                l = t3.QuestionAboutStartAgain();
            }

            //задание 4:
            Test4 t4 = new Test4();
            int t = 1;
            while (t == 1)
            {
                t4.StartMessage();
                t4.Number = (int)t4.ChekRightEnter(Console.ReadLine());
                t4.GetAmountOfNumberRanks(t4.Number);
                t = t4.QuestionAboutStartAgain();
            }

            //задание 5:
            Test5 t5 = new Test5();
            int q = 1;
            while (q == 1)
            {
                t5.AmountInputsToConsole();
                q = t5.QuestionAboutStartAgain();
            }
            Console.ReadKey();
        }
    }
}
