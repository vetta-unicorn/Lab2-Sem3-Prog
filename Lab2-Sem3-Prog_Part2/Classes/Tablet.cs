using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    /* класс планшет производный от класса техника,
       который так же реализует интерфейс IPC*/
    public class Tablet : Technique, IPC
    {
        public double memory { get; set; }
        public double CPU_performance { get; set; }

        public OS os { get; set; }
        public double screenDiag { get; set; }
        public bool ifHasCamera { get; set; }

        public Tablet(double _price, string _name, DateOnly _date, string _model, string _brand,
            double _memory, double _CPU_performance, OS _os, double _screenDiag, bool _ifCamera)
            : base(_price, _name, _date, _model, _brand)
        {
            memory = _memory;
            CPU_performance = _CPU_performance;
            os = _os;
            screenDiag = _screenDiag;
            ifHasCamera = _ifCamera;
        }

        public override string ToString()
        {
            return $"Class Tablet\nName: {name}\nPrice: {price}\nManufacturing date: {dateMade}\n" +
                $"Model: {model}\nBrand: {brand}\nMemory: {memory}\nCPU Performance: {CPU_performance}\n" +
                $"OS: {os}\nSceen diagonal: {screenDiag}\nIf there's a camera: {ifHasCamera}\n";
        }

        public override bool IfActual()
        {
            DateOnly actualDate = new DateOnly(2019, 1, 1);
            if (actualDate.Year > dateMade.Year)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override void Buy(string customerName)
        {
            Console.WriteLine($"{customerName} has successfully bought tablet {name}!");
        }

        public override void ShutDown(bool Flag)
        {
            if (Flag)
            {
                Console.WriteLine("The tablet has successfully shut down");
            }
            else
            {
                Console.WriteLine("Failed to shut up the tablet");
            }
        }

        public override void GetStarted(bool Flag)
        {
            if (Flag)
            {
                Console.WriteLine("The tablet has successfully got started");
            }
            else
            {
                Console.WriteLine("Filed to start the tablet");
            }
        }
    }
}
