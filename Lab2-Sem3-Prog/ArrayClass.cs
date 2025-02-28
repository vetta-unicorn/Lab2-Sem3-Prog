using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window
{
    public class ArrayClass
    {
        private int[] _array;
        public int[] array
        {
            set
            {
                _array = value;
            }
            get
            {
                return _array;
            }
        }

        public ArrayClass()
        {
            _array = new int[] { 0 };
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.array);
        }

        public string getAsString()
        {
            string ArrayString = "";
            foreach (var i in this.array)
            {
                ArrayString += Convert.ToString(i) + " ";
            }
            return ArrayString;
        }

        public static ArrayClass operator *(ArrayClass a, ArrayClass b)
        {
            if (a.array == null || b.array == null)
            {
                Console.WriteLine("ERROR: Array null value met. Returning null.");
                return null;
            }

            ArrayClass c = a;

            if (a.array.Length != b.array.Length)
            {
                Console.WriteLine("WARNING: Arrays' lengths do not match.");
            }
            int ArrayLength = Math.Max(a.array.Length, b.array.Length);
            for (int i = 0; i < ArrayLength; i++)
            {
                c.array[i] = a.array[i] * b.array[i];
            }
            return c;

        }

        public static bool operator !=(ArrayClass a, ArrayClass b)
        {
            if (a.GetHashCode() != b.GetHashCode()) return true;
            else if (a.array.Length != b.array.Length) return true;
            else return false;
        }

        public static bool operator ==(ArrayClass a, ArrayClass b)
        {
            if (a.GetHashCode() == b.GetHashCode()) return true;
            else if (a.array.Length == b.array.Length) return true;
            else return false;
        }

        public bool Equals(ArrayClass b)
        {
            if (this.GetHashCode() == b.GetHashCode()) return true;
            else if (this.array.Length == b.array.Length) return true;
            else return false;
        }

        public static bool operator <(ArrayClass a, ArrayClass b)
        {
            return a.array.Length < b.array.Length;
        }

        public static bool operator >(ArrayClass a, ArrayClass b)
        {
            if (a.array.Length > b.array.Length) return true;
            else return false;
        }

        public static bool operator false(ArrayClass a)
        {
            foreach (int item in a.array)
            {
                if (item < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator true(ArrayClass a)
        {
            foreach (int item in a.array)
            {
                if (item < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static explicit operator int(ArrayClass a)
        {
            return a.array.Length;
        }

    }
}
