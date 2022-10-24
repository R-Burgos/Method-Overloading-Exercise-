using System.Collections.Concurrent;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool bool1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return (bool1 == true && num1 + num2 >= 2) ? $"{num1 + num2} dollars" : (bool1 == true && num1 + num2 == 1) ? $"{num1 + num2} dollar" : "You have no money, sorry. :( ";
        }

        public static string Add()  //I wanted to push myself to see if I could method overload with Console.ReadLine inside the method. 
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            bool condition;
            int userInput1;
            int userInput2;
            do
            {
                Console.WriteLine("Please enter your first integer:");
                condition = int.TryParse(Console.ReadLine(), out userInput1);
            }while (!condition);

            Console.WriteLine("Thank you.");

            do
            {
                Console.WriteLine("Please enter your last integer:");
                condition = int.TryParse(Console.ReadLine(), out userInput2);
            } while (!condition);

            Console.WriteLine("Thank you.");
            

            return (userInput1 + userInput2 >= 2) ? $"{userInput1 + userInput2} dollars" : (userInput1 + userInput2 == 1) ? $"{userInput1 + userInput2} dollar" : "You have no money, sorry. :( ";
        }
        static void Main(string[] args)
        {
            int intNum1 = 8;
            int intNum2 = 15;
            decimal dNum1 = 15.99m;
            decimal dNum2 = 16.99m;
            bool myBool = true;

            Console.WriteLine(Add(intNum1, intNum2));
            Console.WriteLine("\n");
            Console.WriteLine(Add(dNum1, dNum2));
            Console.WriteLine("\n");
            Console.WriteLine(Add(intNum1, intNum2, myBool));
            Console.WriteLine("\n");
            Console.WriteLine(Add());
        }
    }
}
