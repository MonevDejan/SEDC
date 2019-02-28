using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_array
{
    class cats
    {

        int age;
        int health;
        int catLegs;
        bool hsaTail;
        bool IsAlive;

        public int MyProperty { get; set; }

        public void Eat(int calories)
        {
            health += calories / 10;
        }
    }
}
