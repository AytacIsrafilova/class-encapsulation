using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_encapsulation
{
    internal class Product
    {
        public string Name;
        public byte No;
        private double _price;
        private byte _count;

            public double Price
        {
            get {  return _price; }
            set {  _price = value; }
        }
        
        public byte Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public Product(string name,byte no,double price,byte count)
        {
            Name = name;
            No = no;
            _price = price;
            _count = count;

            
        }
        public void ShowFullData()
        {
            Console.WriteLine(GetFullData());

        }
        public string GetFullData()
        {
            return $"{this.Name}\n{this.No}\n{this._price}\n{this._count}";
        }
    }
}
