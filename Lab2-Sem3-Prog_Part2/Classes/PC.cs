using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    /* класс компьютер производный от класса техника,
       который так же реализует интерфейс IPC*/
    public class PC : Technique, IPC
    {
        public double memory { get; set; }
        public double CPU_performance { get; set; }
        public OS os { get; set; }
        public int coreNumber { get; set; }
        public string processorName { get; set; }

        public PC(double _price, string _name, DateOnly _date, string _model, string _brand,
            double _memory, double _CPU_performance, OS _os, int _coreNumber, string _processorName) 
            : base(_price, _name, _date, _model, _brand)
        {
            memory = _memory;
            CPU_performance = _CPU_performance;
            os = _os;
            coreNumber = _coreNumber;
            processorName = _processorName;
        }

        public override string ToString()
        {
            return $"Class PC\nName: {name}\nPrice: {price}\nManufacturing date: {dateMade}\n" +
                $"Model: {model}\nBrand: {brand}\nMemory: {memory}\nCPU Performance: {CPU_performance}\n" +
                $"OS: {os}\nCore number: {coreNumber}\nProcessor name: {processorName}\n";
        }
    }
}
