using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary;

namespace UtilityLibraryTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UtilityClass UC = new UtilityClass();

            string result = UC.aboveBelowEqual(new int[] { 1, 4, 5, 33, 74, 6 }, 5);
            Console.WriteLine("AboveBelowEqual Paramets: { 1, 4, 5, 33, 74, 6 }, 5");
            Console.WriteLine("AboveBelowEqual Result: " + result);

            result = UC.aboveBelow(new int[] { 1, 4, 5, 3, 5, 10, 33, 74, 6}, 6);
            Console.WriteLine("\n\nAboveBelow Paramets: { 1, 4, 5, 3, 5, 10, 33, 74, 6}, 6");
            Console.WriteLine("AboveBelow Result: " + result);

            result = UC.stringRotation("MyString", 2);
            Console.WriteLine("\n\nStringRotation Parameters: Mystring, 2");
            Console.WriteLine("StringRotation Results: " + result);

            result = UC.stringRotation("MyString", 12);
            Console.WriteLine("\n\nStringRotation Parameters: MyString, 12");
            Console.WriteLine("StringRotation Results: " + result);

            Console.ReadLine();
        }
    }
}
