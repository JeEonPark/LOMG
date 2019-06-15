using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOMG
{
    class Bandit1 : Bandit
    {
        public override dynamic W_SKill()
        {
            return "1";
        }

        public override dynamic E_Skill()
        {
            return "1";
        }
    }
}
