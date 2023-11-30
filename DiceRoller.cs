using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace dnd
{
    class DiceRoller
    {
        public int Roll(int dice)
        {
            Random random = new Random();
            int result = random.Next(1, dice);
            return result;
        }
    }
}
