using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // производный класс техника от класса продукт
    public class Technique : Product
    {
        public string model {  get; set; }
        public string brand {  get; set; }


        public Technique(double _price, string _name, DateOnly _date, string _model, string _brand) 
            : base(_price, _name, _date)
        {
            brand = _brand;
            model = _model;
        }

        public override string ToString()
        {
            return $"Class Technique\nName: {name}\nPrice: {price}\nManufacturing date: {dateMade}\n" +
                $"Model: {model}\nBrand: {brand}\n";
        }

    }
}
