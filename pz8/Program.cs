namespace pz8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Calculator calculator = new Calculator();
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double res = 0;
            bool isCont = true;
            while (isCont)
            {
                var action = Console.ReadKey();
                Console.WriteLine();
                switch (action.KeyChar)
                {
                    case '+':
                        res = calculator.Add(a, b);
                        Console.WriteLine(res);
                        break;

                    case '-':
                        res = calculator.Sub(a, b);
                        Console.WriteLine(res);
                        break;

                    case '*':
                        res = calculator.Multiply(a, b);
                        Console.WriteLine(res);
                        break;

                    case '/':
                        res = calculator.Divide(a, b);
                        Console.WriteLine(res);
                        break;

                    case '№':
                        res = calculator.Sqrt(a);
                        Console.WriteLine(res);
                        break;

                    case '^':
                        res = calculator.Pow(a,b);
                        Console.WriteLine(res);
                        break;
                }
            }
            //double result1 = a + b;
            //double result2 = a/b;
            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
        }
    }
}