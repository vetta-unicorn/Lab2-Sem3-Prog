using Classes;
using System;
namespace TestProject2
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethodProduct()
        {
            double price = 10;
            string name = "A";
            DateOnly date = new DateOnly(2005, 1, 1);
            Product pr = new Product(price, name, date);
            Assert.AreEqual(price, pr.price);
            Assert.AreEqual(name, pr.name);
            Assert.AreEqual(date, pr.dateMade);

            double disc = 0.2;
            price = price * (1 - disc);
            pr.Discount(disc);
            Assert.AreEqual(price, pr.price);

            Assert.AreEqual(false, pr.IfActual());
        }

        [TestMethod]
        public void TestMethodTechnique()
        {
            double price = 10;
            string name = "A";
            DateOnly date = new DateOnly(2024, 5, 8);
            string model = "B";
            string brand = "C";
            Technique tech = new Technique(price, name, date, model, brand);
            Assert.AreEqual(price, tech.price);
            Assert.AreEqual(name, tech.name);
            Assert.AreEqual(date, tech.dateMade);
            Assert.AreEqual(model, tech.model);
            Assert.AreEqual(brand, tech.brand);
        }

        [TestMethod]
        public void TestMethodPrinter()
        {
            double price = 10;
            string name = "A";
            DateOnly date = new DateOnly(2024, 5, 8);
            string model = "B";
            string brand = "C";
            bool ifWireless = true;
            ColorModels colorModel = ColorModels.HSV;
            double printSpeed = 22.4;
            string paperSize = "A5";
            Printer pr = new Printer(price, name, date, model, brand, 
                ifWireless, colorModel, printSpeed, paperSize);
            Assert.AreEqual(price, pr.price);
            Assert.AreEqual(name, pr.name);
            Assert.AreEqual(date, pr.dateMade);
            Assert.AreEqual(model, pr.model);
            Assert.AreEqual(brand, pr.brand);
            Assert.AreEqual(ifWireless, pr.ifWireless);
            Assert.AreEqual(colorModel, pr.colorModel);
            Assert.AreEqual(printSpeed, pr.printSpeed);
            Assert.AreEqual(paperSize, pr.paperSize);
        }

        [TestMethod]
        public void TestMethodScanner()
        {
            double price = 1000.999;
            string name = "A2";
            DateOnly date = new DateOnly(2016, 9, 30);
            string model = "B2";
            string brand = "C2";
            bool ifWireless = true;
            ColorModels colorModel = ColorModels.RGB;
            int colorDepth = 0;
            Scanner sc = new Scanner(price, name, date, model, brand,
                ifWireless, colorModel, colorDepth);
            Assert.AreEqual(price, sc.price);
            Assert.AreEqual(name, sc.name);
            Assert.AreEqual(date, sc.dateMade);
            Assert.AreEqual(model, sc.model);
            Assert.AreEqual(brand, sc.brand);
            Assert.AreEqual(ifWireless, sc.ifWireless);
            Assert.AreEqual(colorModel, sc.colorModel);
            Assert.AreEqual(colorDepth, sc.colorDepth);
        }

        [TestMethod]
        public void TestMethodPC()
        {
            double price = 1234567;
            string name = "Hey";
            DateOnly date = new DateOnly(1990, 2, 28);
            string model = "L";
            string brand = "L";
            double memory = 0;
            double CPU_performance = 2;
            OS os = OS.IOS;
            int coreNumber = 4;
            string processorName = "IIIIIIII";
            PC pc = new PC(price, name, date, model, brand, memory, CPU_performance, os, coreNumber, processorName);
            Assert.AreEqual(price, pc.price);
            Assert.AreEqual(name, pc.name);
            Assert.AreEqual(date, pc.dateMade);
            Assert.AreEqual(memory, pc.memory);
            Assert.AreEqual(CPU_performance, pc.CPU_performance);
            Assert.AreEqual(os, pc.os);
            Assert.AreEqual(coreNumber, pc.coreNumber);
            Assert.AreEqual(processorName, pc.processorName);
        }

        [TestMethod]
        public void TestMethodTablet()
        {
            double price = 1234567;
            string name = "Hey";
            DateOnly date = new DateOnly(1990, 2, 28);
            string model = "L";
            string brand = "L";
            double memory = 0;
            double CPU_performance = 2;
            OS os = OS.IOS;
            double screenDiag = 2222.99999;
            bool ifHasCamera = true;
            Tablet tb = new Tablet(price, name, date, model, brand, memory,
                CPU_performance, os, screenDiag, ifHasCamera);
            Assert.AreEqual(price, tb.price);
            Assert.AreEqual(name, tb.name);
            Assert.AreEqual(date, tb.dateMade);
            Assert.AreEqual(memory, tb.memory);
            Assert.AreEqual(CPU_performance, tb.CPU_performance);
            Assert.AreEqual(os, tb.os);
            Assert.AreEqual(screenDiag, tb.screenDiag);
            Assert.AreEqual(ifHasCamera, tb.ifHasCamera);

            Assert.AreEqual(false, tb.IfActual());
        }
    }
}
