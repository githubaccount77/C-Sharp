using System;
//
/*
 * 1.) Console Log

 This is printing to console in C#

namespace MyFirstProgram
{
  
  class Program
    { 

    static void Main(string[] args)
    { 
      Console.WriteLine("I like Pizza!");
    }
  }
}

2.) Output

//
/* This is Output in C#
using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey!");
            Console.WriteLine("Hello!");

            //This is a comment
            /*
             * this
             * is
             * a
             * multiline
             * comment
             * 
             * 
             * 
             */
//
/*
Console.WriteLine("BroCode");

Console.ReadKey();
}
}
}
 
3.)   Variables

    using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; // declaration
            x = 123; // initialization

            int y = 321; // declaration + initialization

            int z = x + y;

            int age = 21; // whole integer
            double height = 300.5; // decimal number
            bool alive = false; //true or false
            char symbol = '@'; // single character
            String name = "Bro"; // a series of characters

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is: " + symbol);

            String userName = symbol + name;

            Console.WriteLine("Your username is: " + userName);

            Console.ReadKey();
        }
    }
}

4.) Constants π

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // constants  = immutable values which are known at compile time
            //              and do not change for the life of the program

            const double pi = 3.14;

            //pi = 420; //can't change this constant

            Console.WriteLine(pi);

            Console.ReadKey();
        }
    }
}


5.) Constraints π

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // constants  = immutable values which are known at compile time
            //              and do not change for the life of the program

            const double pi = 3.14;

            //pi = 420; //can't change this constant

            Console.WriteLine(pi);

            Console.ReadKey();
        }
    }
}

6.) Type-casting

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // type casting = Converting a value to a different data type
            //                Useful when we accept user input (string)
            //                Different data types can do different things

            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c);

            int e = 321;
            String f = Convert.ToString(e);

            String g = "$";
            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(b.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(h.GetType());
            Console.WriteLine(j.GetType());

            Console.ReadKey();
        }
    }
}


7.) User input

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your age?");
            String name = Console.ReadLine();

            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old");

            Console.ReadKey();
        }
    }
}

8.) Arithmetic Operators

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int friends = 5;

            friends = friends + 1;
            //friends += 1;
            //friends++;

            //friends = friends - 1;
            //friends -= 1;
            //friends--;

            //friends = friends * 2;
            //friends *= 2;

            //friends = friends / 2;
            //friends /= 2;

            //int remainder = friends % 2;
            //Console.WriteLine(remainder);

            Console.WriteLine(friends);

            Console.ReadKey();
        }
    }
}

9.) Math Class

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = 3;
            double y = 5;

            double a = Math.Pow(x, 2);
            double b = Math.Sqrt(x);
            double c = Math.Abs(x);
            double d = Math.Round(x);
            double e = Math.Ceiling(x);
            double f = Math.Floor(x);
            double g = Math.Max(x, y);
            double h = Math.Min(x, y);

            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}

11.) Random Numbers

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);

            //double num = random.NextDouble();

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.ReadKey();
        }
    }
}

12.) using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The hypotenuse is: " + c);

            Console.ReadKey();
        }
    }
}

