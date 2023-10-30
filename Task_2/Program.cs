namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter 'X' for MathOperations object 'a' (or 'exit' to quit): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                if (!double.TryParse(input, out double a))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.Write("Enter 'Y' for MathOperations object 'a': ");
                if (!double.TryParse(Console.ReadLine(), out double b))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.Write("Enter 'X' for MathOperations object 'b': ");
                if (!double.TryParse(Console.ReadLine(), out double c))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.Write("Enter 'Y' for MathOperations object 'b': ");
                if (!double.TryParse(Console.ReadLine(), out double d))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                MathOperations obj1 = new MathOperations(a, b);
                MathOperations obj2 = new MathOperations(c, d);

                MathOperations sum = obj1 + obj2;
                MathOperations difference = obj1 - obj2;
                MathOperations product = obj1 * obj2;
                MathOperations quotient = obj1 / obj2;

                Console.WriteLine($"Sum: a = {sum.X}, b = {sum.Y}");
                Console.WriteLine($"Difference: a = {difference.X}, b = {difference.Y}");
                Console.WriteLine($"Product: a = {product.X}, b = {product.Y}");
                Console.WriteLine($"Quotient: a = {quotient.X}, b = {quotient.Y}");
            }
        }
    }
}