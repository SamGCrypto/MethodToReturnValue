using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        //
        //Written by Samuel Gorcyca
        //Date: 11/30/2020
        //CIT 110
        //

        static void Main(string[] args)
        {
            //initialize the answer
            int answer;
            //output answer variable via the addition method
            answer = additionTest();
            //print statement
            Console.WriteLine($"The answer to the addition problem is {answer}.");
            Console.ReadKey();
        }
        //
        //Simple addition method to return
        //
        static int additionTest()
        {
            int answer;
            string userResponse;
            Console.WriteLine("Enter in the first number.");
            userResponse = Console.ReadLine();
            int.TryParse(userResponse, out int a);
            Console.WriteLine("Enter in the second number.");
            userResponse = Console.ReadLine();
            int.TryParse(userResponse, out int b);
            answer = a + b;
            return answer;
        }
    }
}
