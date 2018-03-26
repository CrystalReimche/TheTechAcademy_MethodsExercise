using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            Math add = new Math();

            add.AddTwoNumbers(userInput);
            add.MultiplyTwoNumbers(userInput);
            add.DivideTwoNumbers(userInput);


            Console.ReadKey();
        }
    }
}
