using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    /* класс принтер производный от класса техника, 
     который так же реализует интерфейс IScan*/
    public class Printer : Technique, IScan
    {
        public bool ifWireless { get; set; }

        public ColorModels colorModel { get; set; }

        public double printSpeed {  get; set; }
        public string paperSize {  get; set; }

        public Printer(double _price, string _name, DateOnly _date, string _model, string _brand,
            bool _ifWireless, ColorModels _colorModel, double _printSpeed, string _paperSize) : 
            base(_price, _name, _date, _model, _brand)
        {
            ifWireless = _ifWireless;
            colorModel = _colorModel;
            printSpeed = _printSpeed;
            paperSize = _paperSize;
        }

        public override string ToString()
        {
            return $"Class Printer\nName: {name}\nPrice: {price}\nManufactoring date: {dateMade}\n" +
                $"Model: {model}\nBrand: {brand}\nIf it's wireless: {ifWireless}\nColor model: {colorModel}\n" +
                $"Print speed: {printSpeed}\nPaper size: {paperSize}\n";
        }

    }
}
