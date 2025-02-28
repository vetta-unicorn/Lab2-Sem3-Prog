using Window;
using System;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethodArray()
        {
            ArrayClass a1 = new ArrayClass();
            ArrayClass a2 = new ArrayClass();
            int[] array = new int[] { 0 };
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(a1.array[i], array[i]);
            }

            string st = "0 ";
            Assert.AreEqual(a1.getAsString(), st);

            a1.array = new int[] { 1, 2, 3 };
            a2.array = new int[] { -1, 1, -1 };
            int[] array2 = new int[] { -1, 2, -3 };
            ArrayClass a3 = new ArrayClass();
            a3 = a1 * a2;
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(a3.array[i], array2[i]);
            }

            bool Flag = a1 != a2;
            Assert.AreEqual(Flag, true);

            bool Flag2 = a1 == a2;
            Assert.AreEqual(Flag2, true);

            ArrayClass a4 = new ArrayClass();
            a4.array = new int[] { 0, -2, 3, -1, 0, 1 };
            bool Flag3 = a4 > a1;
            Assert.AreEqual(Flag3, true);

            bool Flag4 = a4 < a2;
            Assert.AreEqual(Flag4, false);

            int[] array3 = new int[] { 0, 3, 0, 1 };
            a4 = a4.deleteNegativeValues();
            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(a4.array[i], array3[i]);
            }

            Assert.AreEqual(true, a4.hasSymbol('0'));
        }
    }
}
