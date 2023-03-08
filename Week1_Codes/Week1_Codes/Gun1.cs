using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Codes
{
    internal class Gun1 : IGun
    {
        public void Shoot(Character character)
        {
            character.health -= 10;
        }
    }
}
