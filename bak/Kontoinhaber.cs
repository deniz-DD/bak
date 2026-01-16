using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bak
{
    //public decimal Price
    //{
    //    get => _price;
    //    set
    //    {
    //        if (value < 0) throw new ArgumentOutOfRangeException(nameof(value));
    //        _price = value;
    //    }
    //}
    internal class Kontoinhaber
    {
       private string _name; 
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
       private decimal _kontostand;  
        public decimal Kontostand
        {
            get { return _kontostand; } 
            set 
            { 
                if (value < 0) 
                    throw new ArgumentOutOfRangeException(nameof(value), "Kontostand darf nicht negativ sein."); 
                _kontostand = value; 
            }

        }



        public Kontoinhaber(string name, decimal kontostand)
         {
              this.Name = name;
              this.Kontostand = kontostand;

        }   

        public  void Ausagabe() 
        {
            Console.WriteLine("Kontostand: {0}",this._kontostand);
        }

    }
}
