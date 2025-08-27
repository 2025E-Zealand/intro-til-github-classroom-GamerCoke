using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class Demo
    {
        private double number;
        private int factor;
        private bool checker;
        private string name;

        public Demo(double num, int fac, bool chec, string nam)
        {
            number = num;
            factor = fac;
            checker = chec;
            name = nam;
        }

        public void printOutForm()
        {
            string message = "";
            if (checker)
            {
                bool tempBool = (number * factor) % 2 == 0;
                message = $"Number is whole: {tempBool}\n";
            }
            Console.WriteLine($"{name}\n{number} times {factor} is equal to: {number * factor} \n{message}");
        }
    }
}
