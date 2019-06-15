using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOMG
{
    abstract class Bandit : Character
    {

        public override int Q_attack()
        {
            return 4 + (GSlevel);
        }
        public abstract dynamic W_SKill();

        public abstract dynamic E_Skill();
    }
}
