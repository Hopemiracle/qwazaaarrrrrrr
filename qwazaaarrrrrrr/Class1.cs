using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qwazaaarrrrrrr
{
    class Heroo
    {
        public int hp = 250;
        public int attack = 50;
        public int damage = 10;
        public int superdamage = 250;
        public int notdamage = 0;
        public int supersupersuperattack = 100000;
        public void Remaininghealth()
        {
            hp = hp - damage;
            
        }
        public void Remaininghealth2()
        {
            hp = hp - superdamage;
        }



    }
}
