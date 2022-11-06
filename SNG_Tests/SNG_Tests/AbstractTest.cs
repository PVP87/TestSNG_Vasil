using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNG_Tests
{
    public abstract class AbstractTest
    {
       virtual public void StartMessage()
        {
            Console.WriteLine();
        }

       virtual public double ChekRightEnter(string s)
        {
            int example;
            bool success = int.TryParse(s, out example);
            if (success)
                return Convert.ToInt32(s);
            return 11111111111;
        }

        virtual public int QuestionAboutStartAgain()
        {
            Console.WriteLine("Press 1, if you want to start again or somthing button to finish.");
            int i = (int)ChekRightEnter(Console.ReadLine());
            Console.WriteLine(new string('-', 80));
            return i;
        }
    }
}
