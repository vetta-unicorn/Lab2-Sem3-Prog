using System;

namespace Window
{
    public class Program
    {

        public static void Main(string[] args)
        {

            ArrayClass a1 = new ArrayClass();

            ArrayClass a2 = new ArrayClass();
            a2.array = new int[] { 1, 2, 3, 4, 5 };

            ArrayClass a3 = new ArrayClass();
            a3.array = new int[] { -2, 3, 4, -5, 6 };

            ArrayClass a4 = new ArrayClass();
            a4.array = new int[] { 1, 2, 3, 4, 5 };
            a3.array = new int[] { -2, 3, -4, 5, 6 };

            Console.WriteLine($"\nArray 1: {a1.getAsString()}\nArray 2: {a2.getAsString()}\n" +
                $"Array 3: {a3.getAsString()}\nArray 4: {a4.getAsString()}");
            Console.WriteLine("\na1 = a2 * a3");
            a1 = a2 * a3;
            Console.WriteLine("\nUsing 'getAsString' func:'");
            Console.WriteLine(a1.getAsString() + "");

            Console.WriteLine("\nUsing operator 'for':");
            foreach (var item in a1.array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine("\nIf there's symbol '6' in a1:");
            Console.WriteLine(a1.hasSymbol('6'));
            Console.WriteLine("\nIf there's symbol '4' in a1:");
            Console.WriteLine(a1.hasSymbol('4'));

            Console.WriteLine("\nDeleting negative values from a1...");
            a1.deleteNegativeValues();

            Console.WriteLine("\nPrinting a1...");
            foreach (var item in a1.array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nArray size: " + (int)a1);
            Console.WriteLine("\nIf a2 == a4");
            Console.WriteLine(a2 == a4);
            Console.WriteLine("\nIf a2 == a3");
            Console.WriteLine(a2 == a3);
            Console.WriteLine("\nIf a2 > a3");
            Console.WriteLine(a1 > a3);
            Console.WriteLine("\nGetting Hash code of a1...");
            Console.WriteLine(a1.GetHashCode());

        }
    }
}
