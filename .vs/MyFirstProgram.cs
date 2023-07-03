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

12.) Hypotenuse Calculator Program 

using System;

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

13.) String Methods

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Bro Code";
            String phoneNumber = "123-456-7890";

            //fullName = fullName.ToUpper();
            //fullName = fullName.ToLower();
            //Console.WriteLine(fullName);

            //phoneNumber = phoneNumber.Replace("-","");
            //Console.WriteLine(phoneNumber);

            //String userName = fullName.Insert(0,"Mr.");
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length);

            String firstName = fullName.Substring(0, 3);
            String lastName = fullName.Substring(4, 4);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            Console.ReadKey();
        }
    }
}


14.) If Statements

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statement = a basic form of decision making\

            https://youtu.be/pSPQnXleaS8

            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("You did not enter your name!");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }

            Console.ReadKey();
        }
    }
}

15.) Switches

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // switch = an efficient alternative to many else if statements

            Console.WriteLine("What day is it today?");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday!");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday!");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday!");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday!");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday!");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday!");
                    break;
                default:
                    Console.WriteLine(day + " is not a day!");
                    break;
            }

            Console.ReadKey();
        }
    }
}

16.) Logical Operators

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // logical operators = Can be used to check if more than 1 condition is true/false

            // && (AND)
            // || (OR)

            Console.WriteLine("What's the temperature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("DO NOT GO OUTSIDE!");
            }


            Console.ReadKey();
        }
    }
}

17.) While Loops

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // while loop = repeats some code while some condition remains true

            https://youtu.be/EyghyKO4BlA

            String name = "";

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }
    }
}

18.) For Loops

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // for loop = repeats some code a FINITE amount of times

            https://youtu.be/h4hY2hho73Q

            // Count up to 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
               
            // Count down from 10
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("HAPPY NEW YEAR!");

            Console.ReadKey();
        }
    }
}

19.) Nested Loops

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // nested loops = loops inside of other loops
            //                Uses vary. Used a lot in sorting algorithms

            Console.Write("How many rows?: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many columns?: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol: ");
            String symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

20.) Number Guessing Game

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing! ... I guess");

            Console.ReadKey();
        }
    }
}

21.) Rock Paper Scissors Game

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }

                Console.Write("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
                
            }

            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }
    }
}



