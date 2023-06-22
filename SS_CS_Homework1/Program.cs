namespace SS_CS_Homework1
{
    public class Program
    {
        public static void Main(string[] consoleArguments)
        {
            Task1();

            Task2();

            Task3();

            Task4();

            Task5();

            Task6();

            Task7();
        }

        public static void Task1()
        {
            int a, b;

            Console.Write("Input a: ");
            var inputA = Console.ReadLine();

            var parsedA = int.TryParse(inputA, out a);

            if (!parsedA)
            {
                Console.WriteLine("Can't parse num a");
                return;
            }

            Console.Write("Input b: ");
            var inputB = Console.ReadLine();

            var parsedB = int.TryParse(inputB, out b);

            if (!parsedB)
            {
                Console.WriteLine("Can't parse num b");
                return;
            }

            int sum = Sum(a, b);
            Console.WriteLine("The result of {1}+{2} is: {0}", sum, a, b);

            int subtr = Subtract(a, b);
            Console.WriteLine($"The result of {a}-{b} is: {subtr}");

            int mult = Multiply(a, b);
            Console.WriteLine("The result of {1}*{2} is: {0}", mult, a, b);

            if (b != 0)
            {
                int div = Divide(a, b);
                Console.WriteLine("The result of {1}/{2} is: {0}", div, a, b);
            }
            else Console.WriteLine("You can't divide by 0");

            Console.ReadLine();
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2) => num1 - num2;

        public static int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public static int Divide(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }

        public static void Task2()
        {
            Console.WriteLine("How are you?");
            Console.Write("Answer: ");
            string answer = Console.ReadLine();
            Console.WriteLine("You are " + answer);

            Console.ReadLine();
        }

        public static void Task3()
        {
            Console.Write("Enter 1st character: ");
            var key1 = Console.ReadKey();
            char symbol1 = key1.KeyChar;

            Console.WriteLine();

            Console.Write("Enter 2nd character: ");
            var key2 = Console.ReadKey();
            char symbol2 = key2.KeyChar;

            Console.WriteLine();

            Console.Write("Enter 3rd character: ");
            var key3 = Console.ReadKey();
            char symbol3 = key3.KeyChar;

            Console.WriteLine();

            Console.WriteLine("You entered {0}, {1}, {2}", symbol1, symbol2, symbol3);

            Console.ReadLine();
        }

        public static void Task4()
        {
            int num1, num2;
            Console.Write("Enter first number: ");
            var input1 = Console.ReadLine();

            var parsed1 = int.TryParse(input1, out num1);

            if (!parsed1)
            {
                Console.WriteLine("Can't parse num 1");
                return;
            }

            Console.Write("Enter second number: ");
            var input2 = Console.ReadLine();

            var parsed2 = int.TryParse(input2, out num2);

            if (!parsed2)
            {
                Console.WriteLine("Can't parse num 2");
                return;
            }

            bool bothPositive = num1 > 0 && num2 > 0;
            Console.WriteLine("Are both numbers positive? {0}", bothPositive ? "Yes" : "No");

            Console.ReadLine();
        }

        public static void Task5()
        {
            int a;

            Console.Write("Enter a side of a square: ");
            var inputA = Console.ReadLine();

            var parsedA = int.TryParse(inputA, out a);

            if (!parsedA)
            {
                Console.WriteLine("Can't parse num");
                return;
            }

            var perimeter = Perimeter(a);
            var area = AreaOfSquare(a);
            Console.WriteLine($"The perimeter is: {perimeter}; the area is: {area}");

            Console.ReadLine();
        }

        public static int Perimeter(int side)
        {
            return 4 * side;
        }

        public static int AreaOfSquare(int side)
        {
            return side * side;
        }

        public static void Task6()
        {
            string name;
            int age;
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.Write($"How old are you, {name}? ");

            var inputAge = Console.ReadLine();

            var parsedAge = int.TryParse(inputAge, out age);

            if (!parsedAge)
            {
                Console.WriteLine("Can't parse age");
                return;
            }

            Console.WriteLine($"Name: {name}; age: {age}");

            Console.ReadLine();
        }

        public static void Task7()
        {
            double radius;
            Console.Write("Enter radius: ");

            var inputRadius = Console.ReadLine();

            var parsedRadius = double.TryParse(inputRadius, out radius);

            if (!parsedRadius)
            {
                Console.WriteLine("Can't parse radius");
                return;
            }

            double length = CircleLength(radius);
            double area = CircleArea(radius);
            double volume = CircleVolume(radius);

            Console.WriteLine($"Length: {length}; area: {area}; volume: {volume}");

            Console.ReadLine();
        }

        public static double CircleLength(double radius)
        {
            return 2 * radius * Math.PI;
        }

        public static double CircleArea(double radius)
        {
            return radius * radius * Math.PI;
        }

        public static double CircleVolume(double radius)
        {
            return radius * radius * radius * Math.PI * 4 / 3;
        }
    }

}