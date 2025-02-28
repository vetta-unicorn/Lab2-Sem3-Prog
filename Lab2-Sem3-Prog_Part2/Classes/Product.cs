using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Window;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Classes
{
    // базовый класс, от которого будут наследоваться все остальные
    public class Product
    {
        private double _price;
        public double price {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    _price = 0; 
                }
                else
                {
                    _price = value; 
                }
            }
        }
        public string name { get; set; }

        public DateOnly dateMade { get; set; }

        public Product(double __price, string _name, DateOnly _date)
        {
            _price = __price;
            name = _name;
            dateMade = _date;
        }

        public override string ToString()
        {
            return $"Class Product\nName: {name}\nPrice: {price}\nManufacturing date: {dateMade}\n"; 
        }

        // метод создания скидки на товар
        public void Discount(double discount)
        {
            price = price * (1 - discount);
        }

        public virtual bool IfActual()
        {
            DateOnly actualDate = new DateOnly(2010, 1, 1);
            if (actualDate.Year > dateMade.Year)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public virtual void Buy(string customerName)
        {
            Console.WriteLine($"{customerName} has successfully bought product {name}!");
        }

        public virtual void ShutDown(bool Flag)
        {
            if (Flag)
            {
                Console.WriteLine("The device has successfully shut down");
            }
            else
            {
                Console.WriteLine("Failed to shut up the device");
            }
        }

        public virtual void GetStarted(bool Flag)
        {
            if (Flag)
            {
                Console.WriteLine("The device has successfully got started");
            }
            else
            {
                Console.WriteLine("Filed to start the device");
            }
        }
    }
}
