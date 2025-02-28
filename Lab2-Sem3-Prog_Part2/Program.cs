using System;
using Classes;

namespace Window
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // создаем объекты
            Product p1 = new Product(500, "Apple", new DateOnly(2025, 1, 31));
            Technique p2 = new Technique(39599.99, "Ultra home helper", new DateOnly(2025, 2, 10), "SSE 99", "Bosch");

            Printer p3 = new Printer(7000, "Maxi printer", new DateOnly(2009, 8, 11),
                "AA11", "Huawei", true, ColorModels.CMYK, 40, "A3");
            Scanner p4 = new Scanner(8500, "Classic scanner", new DateOnly(2014, 9, 20), "PPTY30C",
                "Apple", false, ColorModels.Black_and_White, 24);
            PC p5 = new PC(130000, "Player's dream", new DateOnly(2019, 5, 5), "JHJ 3", "Samsung",
                264, 90, OS.Windows, 2, "Intel");
            Tablet p6 = new Tablet(23780, "Student's tablet", new DateOnly(2023, 3, 3), "990AK",
                "Realme", 64, 78, OS.Android, 10, false);

            List<Product> productList = new List<Product> { p1, p2, p3, p4, p5, p6 };
            Console.WriteLine("There're some products in the shop... Let's look at them!\n");
            Console.WriteLine(productList[0].ToString());
            Console.WriteLine(productList[1].ToString());
            Console.WriteLine(productList[2].ToString());
            Console.WriteLine(productList[3].ToString());
            Console.WriteLine(productList[4].ToString());
            Console.WriteLine(productList[5].ToString());

            Console.WriteLine("----------------------\n");

            Console.WriteLine($"\nWorking with {productList[3].name}...");
            Console.WriteLine("\nIs this model actual?");
            Console.WriteLine(productList[3].IfActual());
            Console.WriteLine("\nLet's make a discount 15%\n");
            productList[3].Discount(0.15);
            Console.WriteLine(productList[3].ToString());
            string cusName = "Vasisusaliy Lokhankin";
            Console.WriteLine($"\n{cusName} is trying to buy it..");
            productList[3].Buy(cusName);
            Console.WriteLine($"\n{cusName} is trying to get started with {productList[3].name}...");
            productList[3].GetStarted(false);

            Console.WriteLine("----------------------\n");

            Console.WriteLine($"\nWorking with {productList[5].name}...");
            Console.WriteLine("\nIs this model actual?");
            Console.WriteLine(productList[5].IfActual());
            Console.WriteLine("\nLet's make a discount 5%\n");
            productList[5].Discount(0.05);
            Console.WriteLine(productList[5].ToString());
            string cusName2 = "Ostap Bender";
            Console.WriteLine($"\n{cusName2} is trying to buy it..");
            productList[5].Buy(cusName2);
            Console.WriteLine($"\n{cusName2} is trying to get started with {productList[5].name}...");
            productList[5].GetStarted(true);
            Console.WriteLine($"\n{cusName2} is trying to shut down {productList[5].name}...");
            productList[5].ShutDown(false);
        }
    }
}
