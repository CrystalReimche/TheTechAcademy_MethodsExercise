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
            int num1;
            int num2 = RandomNumber();
            int result;
            if (int.TryParse(userInput.ToString(), out num1))
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
            int result = int.Parse(num1) * RandomNumber();
            Console.WriteLine("Multiplying your number and a random number, please wait...");
            Thread.Sleep(1000);
            Console.WriteLine("{0} * {1} = {2}", num1, RandomNumber(), result);

            return result;
        }

        public int DivideTwoNumbers(string num1)
        {
            int result = int.Parse(num1) / RandomNumber();
            Console.WriteLine("Dividing your number and a random number, please wait...");
            Thread.Sleep(1000);
            Console.WriteLine("{0} / {1} = {2}", num1, RandomNumber(), result);

            return result;
        }

        public static int RandomNumber()
        {
            Random random = new Random();

            int randNum = random.Next(0, 1001);

            return randNum;
        }
    }
}
