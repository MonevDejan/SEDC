using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapInetrfaceAndClasses.Interfaces
{
    public interface IDiscont
    {
        void SetDiscount(double discount);
        double GetPriceWithDiscount();
    }
}
