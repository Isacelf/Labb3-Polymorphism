using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Polymorphism
{
    internal class Geometry // Allmän klass
    {
        public virtual double Area() // Virutell metod som retunerar 0 och kan överskridas
        {
            return 0;
        }
    }
}
