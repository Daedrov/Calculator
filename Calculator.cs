using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNum;
            int secondNum;
            string operation;
            int answer = 0;
          

            Console.WriteLine("Welcome to the calculator!");
            Console.Write("Please type your first number: ");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please type your operation: ");
            operation = Console.ReadLine();

            Console.Write("Please type your second number: ");
            secondNum = Convert.ToInt32(Console.ReadLine());


            
              switch (operation)
            {
                case "/":
                    answer = firstNum / secondNum;
                    break;
                case "*":
                    answer = firstNum * secondNum;
                    break;
                case "+":
                    answer = firstNum + secondNum;
                    break;
                case "-":
                    answer = firstNum - secondNum;
                    break;
                default:
                    Console.WriteLine("Default case");
                    answer = 0;
                    break;
            }

            Console.WriteLine(answer);
            Console.ReadLine();
            








        }

           
    }
}
