using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_DoHuuCong
{
    class Book : Product
    {
        public Book(int id, string name, double price, string producer) : base(id, name, price, producer)
        {
        }

        public override double ComputeTax()
        {

            return Price * 8 / 100;
        }
    }
}
