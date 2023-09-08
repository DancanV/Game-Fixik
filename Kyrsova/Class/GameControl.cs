using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsova.Class
{
    internal class GameControl
    {
         int bonus = 0;

        public void Sum(int bon)
        {
            bonus += bon;
        }

        public void Dif(int bon)
        {
            if (bonus >= 0)
                bonus -= bon;   
            if(bonus < 0)
                bonus = 0;
        }

        public int PrintBonus()
        {
            return bonus;
        }
        public void SetBonus(int bon)
        {
            bonus = bon;
        }

        public bool Time(int sec1)
        {
            if(sec1 == 0)
                return true;
                return false;
        }
    }
}
