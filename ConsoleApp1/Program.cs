namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to calculator program!");

            int num1;
            Console.WriteLine("Please enter your Frist Number.");
            num1 = Convert.ToInt32(Console.ReadLine());

            int num2;
            Console.WriteLine("Please enter your Second Number.");
            num2 = Convert.ToInt32(Console.ReadLine());


            char operation;
            Console.WriteLine("Please Enter Your Operation between this options (+ ,- , *, / ).");
            operation = Convert.ToChar(Console.Read());

            if (operation == '+')
                Console.WriteLine(num1 + num2);
            else if (operation == '-')
                Console.WriteLine(num1 - num2);
            else if (operation == '*')
                Console.WriteLine(num1 * num2);
            else if (operation == '/')
            {
                int mx = int.Max(num1, num2);
                int mn = int.Min(num1, num2);
                Console.WriteLine(mx / mn);
            }

        }
    }
}
