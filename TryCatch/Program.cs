using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 15, 32, 8, 77, 21 };
            try
            {
                Console.WriteLine("Enter a positive number.");
                int userNum = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numbers)
                {
                    int dividedBy = number / userNum;
                    string newNum = number + " divided by " + userNum + " equals: " + dividedBy;
                    Console.WriteLine(newNum);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("You must enter a number");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The program will now carry on.");
                Console.ReadLine();
            }
        }
    }
}
