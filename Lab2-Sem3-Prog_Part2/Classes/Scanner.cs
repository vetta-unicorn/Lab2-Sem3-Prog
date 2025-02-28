using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    /* класс сканнер производный от класса техника, 
     который так же реализует интерфейс IScan
     Бесплодный!*/
    public sealed class Scanner : Technique, IScan
    {
        public bool ifWireless { get; set; }

        public ColorModels colorModel { get; set; }
        public int colorDepth { get; set; }

        public Scanner(double _price, string _name, DateOnly _date, string _model, string _brand,
            bool _ifWireless, ColorModels _colorModel, int _colorDepth) 
            : base(_price, _name, _date, _model, _brand)
        {
            ifWireless = _ifWireless;
            colorModel = _colorModel;
            colorDepth = _colorDepth;
        }

        public override string ToString()
        {
            return $"Class Scanner\nName: {name}\nPrice: {price}\nManufactoring date: {dateMade}\n" +
                $"Model: {model}\nBrand: {brand}\nIf it's wireless: {ifWireless}\nColor model: {colorModel}\n" +
                $"Color Depth: {colorDepth}\n";
        }
    }
}
