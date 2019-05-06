using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ObjectProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            // testing all of the objects methods and property
            #region object methodes   
            object dejan = new  { Name = "Dejan", LastName = "Monev" };
            object dejan1 = dejan;
            object tony = new { Name = "Tony", LastName = "Stark" };

            Console.WriteLine(dejan.Equals(dejan1));
            Console.WriteLine(dejan.GetHashCode());
            Console.WriteLine(dejan.ToString());
            Console.WriteLine(dejan.GetType().Name);
            bool IsSameReference1 = ReferenceEquals(dejan, dejan1);
            bool IsSameReference2 = ReferenceEquals(dejan, tony);
            Console.WriteLine(IsSameReference1);
            Console.WriteLine(IsSameReference2);
            #endregion
            Console.ReadLine();
        }
    }
}
