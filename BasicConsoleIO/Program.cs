using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* Basic Console I/O ********");
            GetUserData();
            FormatNumericalData();
            DisplayMessage();

        }

        private static void DisplayMessage()
        {
            // string format to format a string literal
            string userMsg = string.Format("1000000 in hex is: {0:x}", 1000000);

            //you need to reference the PresentationFramework.dll
            //in order to compile this line of code
            System.Windows.MessageBox.Show(userMsg);

        }

        //now make use of some format tags
        private static void FormatNumericalData()
        {
            Console.WriteLine("The value of 9999 in various formats");
            Console.WriteLine("C format {0:C}", 9999);
            Console.WriteLine("d9 format {0:d9}", 9999);
            Console.WriteLine("f3 format {0:f3}", 9999);
            Console.WriteLine("n format {0:n}", 9999);

            //notice that upper or lower for hex
            //determines if the letters are upper or lowercase
            Console.WriteLine("E format{0:E}", 9999);
            Console.WriteLine("e format{0:e}", 9999);
            Console.WriteLine("X format {0:X}", 9999);
            Console.WriteLine("x format {0:x}", 9999);


        }

        private static void GetUserData()
        {
            //get name and age
            Console.WriteLine("Please enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age ");
            string age = Console.ReadLine();

            //chane echo color, just for fun
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            //echo to the console
            Console.WriteLine("Hello {0}! You are {1} Years old"
                ,name,age);

            //restore previous color
            Console.ForegroundColor = prevColor;
        }
    }
}
