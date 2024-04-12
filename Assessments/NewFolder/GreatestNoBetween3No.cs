using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.NewFolder
{
    public class GreatestNoBetween3No
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            num1 = 20;
            num2 = 40;
            num3 = 80;
            if(num1>num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine("num1 is greatest");
                }
                else
                {
                    Console.WriteLine("num3 is greatest");
                }
            }
            else if(num1>num3)
            {
                Console.WriteLine("num2 is greatest");
            }
            else
            {
                Console.WriteLine("num3 is greatest");
            }
        }
    }
}
