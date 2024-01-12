// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   /\\    ");
            Console.WriteLine("  /  \\   ");
            Console.WriteLine(" /    \\  ");
            Console.WriteLine("/______\\ ");

            string characterName = "George";
            int characterAge;
            characterAge = 70;
            string name = "name";

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine($"He was {characterAge} years old");

            characterName = "Mike";

            Console.WriteLine("He really liked the {1} {0}", characterName, name);
            Console.WriteLine("He didn't like being {0}", characterAge);

            string phrase = "string words";
            char grade = 'A';
            int age = 3;
            float number0 = 3.2F;
            double number1 = 3.3;
            decimal number2 = 345.32M;

            bool falseVal = false;
            bool trueVal = true;

            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("wor"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.Substring(7));
            Console.WriteLine(phrase.Substring(7, 3));

            Console.WriteLine("\\      /\\      /      /\\      |      ----|----   |----  |---\\ ");
            Console.WriteLine(" \\    /  \\    /      /  \\     |          |       |      |___/  ");
            Console.WriteLine("  \\  /    \\  /      /----\\    |          |       |----  |\\    ");
            Console.WriteLine("   \\/      \\/      /      \\   |_____     |       |____  | \\   ");

            var num = 60;

            Console.WriteLine(num + 56);

            num++;

            Console.Write("Enter your name: ");
            string words = Console.ReadLine();
            Console.Write("Enter your age: ");
            string agePerson = Console.ReadLine();
            Console.WriteLine($"Hello {words} you are {agePerson}");

            // build basic calculator

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            // arrays

            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(ints[5]); // index array

            ints[5] = 10;

            string[] strings = new string[5];
            strings[0] = "Stuff1";
            strings[1] = "Stuff2";

            // run method

            SayHi();
            HelloUser("Walter");
            HelloUserAdvanced("Walter", 27);

            Console.WriteLine(cube(3));

            // if statements

            bool boolval1 = true;
            bool boolval2 = true;

            if (boolval1 && boolval2)
            {
                Console.WriteLine("It's both true");
            }
            else if (boolval1 && !boolval2)
            {
                Console.WriteLine("only 1 is true");
            }
            else if (!boolval1 && boolval2)
            {
                Console.WriteLine("only 2 is true");
            }
            else
            {
                Console.WriteLine("Neither is true");
            }

            // comparison if statements

            Console.WriteLine(GetMax(2, 10));
            Console.WriteLine(GetMax(1, 2, 3));

            // four function calculator

            Console.Write("Enter a number: ");
            double cal1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double cal2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(AdvanceCalculator(cal1, cal2, op));

            // Switch statements

            Console.WriteLine(GetDay(5));

            // While loop

            int index = 1;

            while(index <= 5)
            {
                Console.Write($"{index} ");
                index++;
            }
            Console.WriteLine();

            // Do while loop

            int index2 = 6;

            do
            {
                Console.Write($"{index2} ");
                index2++;
            } while (index2 <= 5);

            Console.WriteLine();

            // Guessing game with while loop with guess limit

            string secretWord = "giraffe";
            string guess = "";
            int guesslimit = 3;

            while (guess != secretWord || guesslimit == 0)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                guesslimit--;
            }
            Console.WriteLine("You win!");

            // Guessing game with do-while loop

            string guess2;

            do
            {
                Console.Write("Enter guess: ");
                guess2 = Console.ReadLine();
            } while (guess2 != secretWord);
            Console.WriteLine("You win!");

            // for loop

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i} ");
            }

            // loop through array

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.Write($"{luckyNumbers[i]} ");
            }

            // 2D arrays

            int[,] numberGrid = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Console.WriteLine(numberGrid[0, 0]);

            int[,] myArray = new int[2, 3];

            myArray[1, 1] = 4;

            // Exception handling

            try
            {
                Console.Write("Enter a number: ");
                int num3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int num4 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num3 / num4);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine('\n');
            }

            // use base constructors

            Book book1 = new Book();

            book1.title = "Harry Potter";
            book1.title = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();

            book2.title = "Lord of the Rings";
            book2.title = "Tolkien";
            book2.pages = 700;

            Console.WriteLine(book2.author);

            // Using better constructors

            Book book3 = new Book("Het Gouden Ei", "Harry Mulish",360);

            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam","Art",3.6);

            // class/object methods

            Console.WriteLine(student1.hasHonors());
            Console.WriteLine(student2.hasHonors());

            // Getters and setters

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            // Static class attributes

            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine(Song.songCount); // print static attribute

            // Static methods and classes

            Console.WriteLine(Math.Sqrt(144));

            Usefulltools.SayHi("Walter");

            // inheritance

            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();


            Console.ReadLine();
        }

        // methods

        static double GetPow(double baseNum, double powNum)
        {
            //double result = Math.Pow(baseNum, powNum); // using math function
            double result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }


            return result;
        }


        static string GetDay(int dayNum)
        {
            string dayName;

            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day number";
                    break;
            }

            return dayName;
        }

        static double AdvanceCalculator(double num1, double num2, string ope)
        {
            double result;

            if (ope == "*")
            {
                result = num1 * num2;
            }
            else if (ope == "/")
            {
                result = num1 / num2;
            }
            else if (ope == "+")
            {
                result = num1 + num2;
            }
            else if (ope == "-") 
            {
                result = num1 - num2;
            }
            else
            {
                Console.WriteLine("Invalid Operator");
                return 0.0;
            }

            return result;
        }


        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            int num4;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            num4 = num1 >= num2 ? num1 : num2;
            result = num4 >= num3 ? num4 : num3;

            return result;
        }

        static int GetMax(int num1, int num2)
        {
            int result;

            //if (num1 > num2)
            //{
            //    result = num1;
            //}
            //else
            //{
            //    result = num2;
            //}

            // single line if statement

            result = num1 > num2 ? num1 : num2;

            return result;
        }

        static void SayHi()
        {
            Console.WriteLine("Say Hi");
        }

        static void HelloUser(string name)
        {
            Console.WriteLine($"Hello user: {name}");
        }

        static void HelloUserAdvanced(string name,int age)
        {
            Console.WriteLine($"Hello user: {name} you are {age}");
        }

        static double cube(double x) 
        {
            return Math.Pow(x, 3);
        }
    }
}