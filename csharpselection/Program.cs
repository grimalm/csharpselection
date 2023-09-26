using System.Reflection;
using System.Reflection.Metadata;

namespace csharpselection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program.fizzbuzz(15);
            Program.vowelorconsonant('u');
            Program.dice();
            Program.ClassifyAngle(50);
            Program.rps();
            Program.sides();
            Program.ticket();
            DateTime birthday = new DateTime(2006, 9, 30);
            bool ok = eligible(birthday);
            if (ok) { Console.WriteLine(true); }
            else { Console.WriteLine(false); }
            
        }
        static string fizzbuzz(double num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "fizzbuzz";
            }
            else if (num % 3 == 0 && num % 5 != 0)
            {
                return "fizz";
            }
            else if (num % 3 != 0 && num % 5 == 0)
            {
                return "buzz";
            }
            else
            {
                string num1 = Convert.ToString(num);
                return num1;
            }
        }
        static bool vowelorconsonant(char letter)
        {
            switch (Char.ToLower(letter) )
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                default:
                    return false;
            }
            
            bool result = vowelorconsonant(letter);
            if (result)
            {
                return true;
            }
            else { return false; }
        }
        static string dice()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 6);
            int num2 = rnd.Next(1, 6);
            int num3 = rnd.Next(1, 6);

            if (num1 == num2 && num2 == num3)
            {
                return "three of a kind";
            }
            else if (num1 == num2 || (num2 == num3 || num1 == num3))
            {
                return "you have a pair";
            }
            else
            {
                return "sorry you lose";
            }
        }
        enum AngleType
        {
            acute,
            Right_Angle,
            obtuse,
            straight,
            reflex
        }
        static AngleType ClassifyAngle(int angle)
        {
            if (angle < 90)
            {
                return AngleType.acute;
            }
            else if (angle == 90)
            {
                return AngleType.Right_Angle;
            }
            else if (angle > 90 && angle < 180)
            {
                return AngleType.obtuse;
            }
            else if (angle == 180)
            {
                return AngleType.straight;
            }
            else { return AngleType.reflex; }
        }

        enum RockPaperScissors
        {
            rock,
            paper,
            scissors
        }
        static RockPaperScissors rps()
        {
            Console.WriteLine("rock, paper or scissors?");
            string User1 = Console.ReadLine();
            Random rnd = new Random();
            int choice = rnd.Next(0, 2);
            RockPaperScissors tst = (RockPaperScissors)choice;

            if (User1 == "rock" && choice == 0 || User1 == "paper" && choice == 1 || User1 == "scissors" && choice == 2)
            {
                Console.WriteLine("draw");
            }
            else if (User1 == "rock" && choice == 1 || User1 == "paper" && choice == 2 || User1 == "scissors" && choice == 0)
            {
                Console.WriteLine("lost");
            }
            else { Console.WriteLine("win");  }
            return tst;
        }
        enum Triangle
        {
            equilateral,
            isosceles,
            scalene
        }
        static Triangle sides()
        {
            Console.WriteLine("enter a side length 1");
            string User = Console.ReadLine();
            Console.WriteLine("enter a side length 2");
            string User2 = Console.ReadLine();
            Console.WriteLine("enter a side length 3"); 
            string User3 = Console.ReadLine();

            double side1 = Convert.ToDouble(User);
            double side2 = Convert.ToDouble(User2);
            double side3 = Convert.ToDouble(User3);

            if (User == User2 && User == User3)
            {
                return Triangle.equilateral;
            }
            else if (User == User2 && User != User3 || User == User3 && User != User2 || User2 == User3 && User2 != User)
            {
                return Triangle.isosceles;
            }
            else { return Triangle.scalene; }
        }
        static double ticket()
        {
            Console.WriteLine("enter ticket price");
            if(!double.TryParse(Console.ReadLine()), out double ticketPrice)
            {
                return 0;
            }
            Console.WriteLine("enter num tickets");
            string num = Console.ReadLine();
            if (!double.TryParse(Console.ReadLine()),out double numtickets)
            {
                return 0;
            }
            double total = ticketPrice * numtickets;
            return total;
            if (total > 0)
            {
                Console.WriteLine(total.ToString());
            }

        }
        static bool eligible(DateTime birthday)
        {
            DateTime current = DateTime.Now;

            int age = current.Year - birthday.Year;
            
            if(current.Month < birthday.Month || current.Month == birthday.Month && current.Day < birthday.Day)
            {
                age--;
            }

            return age >= 18 && age <= 30;
            

            
        }
    }   
}
