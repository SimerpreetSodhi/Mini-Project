using System;
using System.Transactions;

namespace ConsoleApp2
{
   class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int Num1, Num2, output;
            char option;
            Console.WriteLine("Enter the First Number: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Main Menu");
            Console.WriteLine("1.Addition ");
            Console.WriteLine("2.Subtraction ");
            Console.WriteLine("3.Multiplication ");
            Console.WriteLine("4.Division ");
            Console.WriteLine("Enter the option from the list to perform the task");
            option = Convert.ToChar(Console.ReadLine());
            switch (option)
            {
                case '1':
                    output = Num1 + Num2;
                    Console.WriteLine("The result of Addition is :{0} ", output);
                    break;
                case '2':
                    output = Num1 - Num2;
                    Console.WriteLine("The result of Subtraction is :{0} ", output);
                    break;
                case '3':
                    output = Num1 * Num2;
                    Console.WriteLine("The result of Multiplication is :{0} ", output);
                    break;
                case '4':
                    output = Num1 / Num2;
                    Console.WriteLine("The result of Division is : {0} ", output);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.ReadLine();
        }



    
        
        }
  



}

