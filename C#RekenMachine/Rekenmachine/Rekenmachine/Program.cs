namespace Rekenmachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");

            Console.WriteLine("Enter the first number: ");

            string operation = ("Enter operation (+, -, *, /): ");
            double getal1 = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Enter the operator: ");
            string op = Console.ReadLine();
            Console.WriteLine("Enter the second number: ");

            double getal2 = Convert.ToDouble (Console.ReadLine());

            double result;
            if (op == "+")
            {
                result = getal1 + getal2;
                Console.WriteLine("Result is: " + Convert.ToString(result));

            }
            else if (op == "-")
            {
                result = getal1 - getal2;
                Console.WriteLine("Result is: " + Convert.ToString(result));

            }
            else if (op == "*")
            {
                result = getal1 * getal2;
                Console.WriteLine("Result is: " + Convert.ToString(result));

            }
            else if (op == "/")
            {
                if (getal2 != 0)
                {
                    result = getal1 / getal2;
                    Console.WriteLine("Result is: " + Convert.ToString(result));

                }
                else
                {
                    Console.WriteLine("Error: Division by zero!");
                }
            }
            else
            {
                Console.WriteLine("Invalid operation!");
            }

        }
   
    }
}
    

