namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool z)
        {
            if (z == true)
            {
                return (x + y != 1) ? $"{x + y} dollars" : $"{x + y} dollar";
            }
            else
            {
                return $"{x + y}";
            }
        }
            static void Main(string[] args)
            {
            Console.WriteLine(Add(1, 2)); // int Add()
            Console.WriteLine(Add(1.7m, 3.5m)); // decimal Add()
            Console.WriteLine(Add(1, 2, true)); // Add(true)
            Console.WriteLine(Add(1, 2, false)); // Add(false)
            Console.WriteLine(Add(1, 0, true)); // Add(1 dollar)
        }
    }
    }

