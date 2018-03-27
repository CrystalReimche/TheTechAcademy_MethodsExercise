using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MethodsExercise
{
    public class Math
    {
        public int AddTwoNumbers(string userInput)
        {
            int num2 = RandomNumber();
            int result;
            if (int.TryParse(userInput.ToString(), out int num1))
            {
                result = num1 + num2;
                Console.WriteLine("Adding your number and a random number, please wait...");
                Thread.Sleep(1000);
                Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
            }
            else
                throw new FormatException("There was a problem!");

            return result;
        }

        public int MultiplyTwoNumbers(string num1)
        {
            int num2 = RandomNumber();
            int result;
            if (int.TryParse(num1.ToString(), out int num))
            {
                result = num * num2;
                Console.WriteLine("Multiplying your number and a random number, please wait...");
                Thread.Sleep(1000);
                Console.WriteLine("{0} * {1} = {2}", num, num2, result);
            }
            else
                throw new FormatException("There was a problem!");

            return result;
        }

        public double DivideTwoNumbers(string num1)
        {
            double num2 = RandomNumber();
            double result;
            if (double.TryParse(num1.ToString(), out double num))
            {
                result = num / num2;
                Console.WriteLine("Dividing your number and a random number, please wait...");
                Thread.Sleep(1000);
                Console.WriteLine("{0} / {1} = {2:F2}", num, num2, result);
            }
            else
                throw new FormatException("There was a problem!");

            return result;
        }

        public static int RandomNumber()
        {
            Random random = new Random();

            int randNum = random.Next(2, 102);

            return randNum;
        }
    }
}
