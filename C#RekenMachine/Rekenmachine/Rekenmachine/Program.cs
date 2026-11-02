namespace Rekenmachine
{
    internal class Program
    {
        static double Berekening(double getal1, double getal2, string op)
        {
            double result = 0;

            if (op == "+")
            {
                result = getal1 + getal2;
            }
            else if (op == "-")
            {
                result = getal1 - getal2;
            }
            else if (op == "*")
            {
                result = getal1 * getal2;
            }
            else if (op == "/")
            {
                if (getal2 != 0)
                {
                    result = getal1 / getal2;
                }
                else
                {
                    Console.WriteLine("Error: Division by 0!!!");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Invalid input!!!");
                return 0;
            }

            return result;
        }

        static void Main(string[] args)
        {
            bool doorgaan = true;

            while (doorgaan)
            {
                Console.WriteLine("Simple Calculator");

                Console.WriteLine("Enter the first number: ");
                double getal1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the operator (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.WriteLine("Enter the second number: ");
                double getal2 = Convert.ToDouble(Console.ReadLine());

                double result = Berekening(getal1, getal2, op);

                Console.WriteLine("Result is: " + result);

                Console.WriteLine("Do you want to calculate again? (yes/no)");
                string keuze = Console.ReadLine();

                if (keuze == "no")
                {
                    doorgaan = false;
                    Console.WriteLine("Farewell, mathmetician!");
                }
            }
        }
    }
}