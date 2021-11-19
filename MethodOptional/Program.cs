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
            //call the class Math and name it here as math
            Math math = new Math();
            Console.WriteLine("Please type in your first number.");
            //save the user's input here as var userNum
            int userNum = Convert.ToInt32(Console.ReadLine());
            //ask the user for a 2nd num. the user may also leave this blank because the
            //method's 2nd parameter is optional
            Console.WriteLine("Type in your optional number here. If you do not include a number, it will default to 4.");
            try
            {
                //save the user's input here as userNum2 and as a string. 
                string userNum2 = Console.ReadLine();
                //this if statement will run if the user types anything that isn't a blank space
                if (userNum2 != "")
                {
                    //because we save the user's 2nd input as a string initially, we have to convert it to an integer
                    int optionalNum = Convert.ToInt32(userNum2);
                    //call the method OptionalMath with the 2 parameters provided, and save the result as int variable response
                    int response = math.OptionalMath(userNum, optionalNum);
                    //return that result to the user
                    Console.WriteLine(userNum + " multiplied by " + optionalNum + " equals: " + response);
                    Console.ReadLine();
                }
                //this else runs if userNum2 is blank
                else
                {
                    //call the OptionalMath method with only 1 parameter, meaning it will do the method with the 2nd parameter
                    //being the default we set which is 4
                    int response = math.OptionalMath(userNum);
                    //return the result to the user
                    Console.WriteLine(userNum + " multiplied by 4 equals: " + response);
                    Console.ReadLine();
                }
            }
            catch (FormatException ex)
            {
                //if the user types in something that isn't valid this will output to the console instead of the program stopping
                Console.WriteLine("Please type in a valid input");
            }
            catch (Exception ex)
            {
                //is there are any other errors besides the formatexception it will display that error message to the console
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            } 
        }
    }
}
