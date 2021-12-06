using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?"); 
            try
            {
                byte age = Convert.ToByte(Console.ReadLine());
                if (age == 0) throw new OverflowException();
                int currentYear = DateTime.Now.Year;
                int yearBorn = currentYear - (int)age;
                Console.WriteLine($"You are {age} years old so you were born in {yearBorn}.");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Your input included a letter/letters. Please input numbers only.");
                Console.ReadLine();
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your number was negative or zero. Please input positive numbers only.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something you have entered has caused an unexpected error to occur. Please try again later");
                Console.ReadLine();
                return;
            }
        }
    }
}
