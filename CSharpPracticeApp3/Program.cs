using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeApp3
{
    class Program
    {
        static void Main(string[] args)
        {//Write a program and ask the user to enter the width 
         //and height of an image. Then tell if the image is landscape or portrait.

            double height;
            double width;

            Console.WriteLine("Please enter the height of the image: ");
            while (double.TryParse(Console.ReadLine(), out height) == false || height < 0)
            {
                Console.WriteLine("Sorry, try again.  Please enter the height of the image:");
            }
            
            Console.WriteLine("Please enter the width of the image: ");
            while (double.TryParse(Console.ReadLine(), out width) == false || width < 0)
            {
                Console.WriteLine("Sorry, try again.  Please enter the width of the image:");
            }

            var result = (width > height) ? "Landscape" : "Portrait";

            Console.WriteLine("The picture is "+ result + " oriented.");
        }
    }
}
