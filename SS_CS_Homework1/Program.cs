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

            Homework1();

            Homework2();

            Homework3();
        }

        /// <summary>
        /// Define integer variables a and b.
        ///Read values a and b from the console and calculate: a+b, a-b, a*b, a/b.
        ///Output results on the console.
        /// </summary>
        public static void Task1()
        {
            if (!Helpers.PromptWithValidationInt("Input a: ", "Can't parse num a", out int a))
            {
                return;
            }

            if (!Helpers.PromptWithValidationInt("Input b: ", "Can't parse num b", out int b))
            {
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

        /// <summary>
        /// Output question “How are you?“. 
        /// Define string variable answer.
        /// Read value answer and output on the console: “You are(answer)". 
        /// </summary>
        public static void Task2()
        {
            Console.WriteLine("How are you?");

            var answer = Helpers.Prompt("Answer: ");

            Console.WriteLine("You are " + answer);

            Console.ReadLine();
        }

        /// <summary>
        /// Read 3 variables of char type. 
        /// Write message: “You enter(first char), (second char), (3 char)”
        /// </summary>
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


        /// <summary>
        /// Enter 2 integer numbers. 
        /// Check if they are both positive – use bool expression
        /// </summary>
        public static void Task4()
        {
            if (!Helpers.PromptWithValidationInt("Enter first number: ", "Can't parse num 1", out int num1))
            {
                return;
            }

            if (!Helpers.PromptWithValidationInt("Enter second number: ", "Can't parse num 2", out int num2))
            {
                return;
            }

            bool bothPositive = num1 > 0 && num2 > 0;
            Console.WriteLine("Are both numbers positive? {0}", bothPositive ? "Yes" : "No");

            Console.ReadLine();
        }


        /// <summary>
        /// Define integer variable a (side of the square). 
        /// Read value from the console and calculate the area and perimeter of a square with length a.
        /// Output results on the console.
        /// </summary>
        public static void Homework1()
        {
            if (!Helpers.PromptWithValidationInt("Enter a side of a square: ", "Can't parse num ", out int a))
            {
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

        /// <summary>
        /// Define string name and integer age. 
        /// Output question "What is your name?";
        /// Read value name and output next question: "How old are you, (name)?". 
        /// Read value age and output whole information
        /// </summary>
        public static void Homework2()
        {
            var name = Helpers.Prompt("What is your name? ");

            if (!Helpers.PromptWithValidationInt($"How old are you, {name}? ", "Can't parse age", out int age))
            {
                return;
            }

            Console.WriteLine($"Name: {name}; age: {age}");

            Console.ReadLine();
        }

        /// <summary>
        /// Read double number r (radius of a circle).
        /// Calculate the length(l= 2 * pi * r), area(S= pi * r * r), and volume(4/3*pi* r*r* r) of a circle.
        /// </summary>
        public static void Homework3()
        {
            var inputRadius = Helpers.Prompt("Enter radius: ");

            var parsedRadius = double.TryParse(inputRadius, out double radius);

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