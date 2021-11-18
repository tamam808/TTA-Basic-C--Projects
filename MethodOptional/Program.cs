using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptional
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please type in your first number.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in your optional number here. If you do not include a number, it will default to 4.");
            try
            {
                string userNum2 = Console.ReadLine();
                if (userNum2 != "")
                {
                    int optionalNum = Convert.ToInt32(userNum2);
                    int response = math.OptionalMath(userNum, optionalNum);
                    Console.WriteLine(userNum + " multiplied by " + optionalNum + " equals: " + response);
                    Console.ReadLine();
                }
                else
                {
                    int response = math.OptionalMath(userNum);
                    Console.WriteLine(userNum + " multiplied by 4 equals: " + response);
                    Console.ReadLine();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type in a valid input");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            } 
        }
    }
}
