using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window
{
    public static class ArrayExtentions
    {
        public static bool hasSymbol(this ArrayClass a, char symbol)
        {
            string arrayString = a.getAsString();
            foreach (char item in arrayString)
            {
                if (item == symbol)
                    return true;
            }
            return false;
        }


    }

    public static class NegativeNumberDeleter
    {
        public static ArrayClass deleteNegativeValues(this ArrayClass arr)
        {
            int[] newArray = arr.array;
            newArray = newArray.Where(val => val >= 0).ToArray();
            arr.array = newArray;
            return arr;
        }

    }
}
