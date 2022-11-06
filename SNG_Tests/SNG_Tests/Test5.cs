using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNG_Tests
{
    class Test5
    {
        
        public Test5()
        {
            Console.WriteLine("Задание 5: Пользователь последовательно вводит с клавиатуры числа в консоль.\n" +
                              "Как только пользователь ввел «пустую строку» вывести на экран сумму введенных чисел и завершить работу программы.");
        }

        public void AmountInputsToConsole()
        {
            Console.WriteLine("Enter anything number throw ENTER.");
            string variable = ChekValue();
            
            int i = 0;
            if (variable != "error")
            {
                while (variable != null && variable != "error")
                {
                    variable = ChekValue();
                    i++;
                }
                if (variable != "error")
                    Console.WriteLine("Common amount of inputs: " + i);
                else
                    Console.WriteLine("You has entered a wrong value.");
            }
            else
                Console.WriteLine("You has entered a wrong value.");
        }

        private string ChekValue()
        {
            string variable = Console.ReadLine();
            double example;
            bool success = double.TryParse(variable, out example);
            if (success)
                return variable;
            if (String.IsNullOrEmpty(variable))
                return null;
            return "error";
        }

        virtual public int QuestionAboutStartAgain()
        {
            Console.WriteLine("Press 1, if you want to start again or somthing button to finish.");
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                return i;
            }
            catch { }
            finally
            {
                Console.WriteLine(new string('-', 80));
            }
            return 0;
        }
    }
}
