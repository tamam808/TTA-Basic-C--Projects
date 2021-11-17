using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesArray = { "Serena", "Venus", "Robin", "John" };
            Console.Write("Please input a last name: ");
            string lastName = Console.ReadLine();
            for (int i = 0; i < namesArray.Length; i++)
            {
                if (!namesArray[i].Contains(lastName))
                {
                    namesArray.SetValue(namesArray[i] + " " + lastName, i);
                    Console.WriteLine(namesArray[i]);
                }
            }
            Console.ReadLine();

            //the infinite loop
            //while (true)
            //{
            //    Console.WriteLine("It's a jackal!");
            //}

            //how i would fix the infinite loop
            bool infinite = true;
            
            while (infinite)
            {
                Console.WriteLine("It's a jackal");
                Console.ReadLine();
                infinite = false;
            }

            string[] sentenceArray = { "This", "array", "will", "form", "a", "sentence" };
            //for loop using < as the comparison
            for (int j = 0; j < sentenceArray.Length; j++)
            {
                Console.WriteLine(sentenceArray[j]);
            }
            Console.ReadLine();
            //for loop using <= as the comparison but getting the same result and with no errors
            for (int k = 0; k <= sentenceArray.Length - 1; k++)
            {
                Console.WriteLine(sentenceArray[k]);
            }
            Console.ReadLine();

            List<string> names = new List<string>() { "Tony", "Jason", "Barbara", "Kevin", "Lisa", "Peter" };
            Console.WriteLine("Type in a name. If the name is in the list I will tell you what index they are at");
            string inputName = Console.ReadLine();
            string nameIndex = "";

            for (int index = 0; index < names.Count; index++)
            {
                if (inputName == names[index])
                {
                    nameIndex = inputName + " is at index { " + index + " }";
                    break;
                }
                else
                {
                    nameIndex = "That name is not on the list";
                }
            }
            Console.WriteLine(nameIndex);

            //this section of code will ask the user to type in a shape
            //if that shape exists in the list it will return to you which index/indices
            //the shape is located at
            List<string> shapes = new List<string>() { "Circle", "Triangle", "Circle", "Square", "Rectangle", "Triangle", "Rhombus", "Circle" };
            Console.WriteLine("\nType in a shape");
            string userShape = Console.ReadLine();
            string shapeResponse = userShape + " is located at index/indices: ";
            string shapeIndices = "";
            bool shapeBool1 = true;
            int shapeCounter = 0;
            do
            {
                if (userShape == shapes[shapeCounter])
                {
                    shapeIndices = shapeIndices + "{ " + shapeCounter + " }";
                    shapeResponse = shapeResponse + shapeIndices;
                    shapeCounter += 1;
                }
                else if (userShape != shapes[shapeCounter])
                    {
                        shapeCounter += 1;
                    }
                if (shapeCounter == shapes.Count - 1)
                {
                    shapeBool1 = false;
                }

            }
            while (shapeBool1);

            if (shapeIndices == "")
            {
                shapeResponse = "That shape is not on the list";
            }
                
            Console.WriteLine(shapeResponse);
            Console.ReadLine();
           //this section of the code will iterate through the list and display each value
           //and if that shape has come up in the list before or not
            string shapeString = "";
            string shapeYesOrNo;
            
            foreach (string shape in shapes)
            {
                if (shapeString.Contains(shape))
                {
                    shapeYesOrNo = ": yes";
                }
                else
                {
                    shapeYesOrNo = ": no";
                }
                shapeString = shapeString + "\n" + shape;
                shapeString = shapeString + shapeYesOrNo;
                
            }
            Console.WriteLine(shapeString);
            Console.ReadLine();
        }
    } 
}
