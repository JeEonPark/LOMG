using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOMG
{
    class GameInformation
    {
        private static int Champion = 0;

        public int GSChampion
        {
            get { return Champion; }
            set { Champion = value; }
        }

        private static int Enemy_Champion = 0;

        public int GSEnemy_Champion
        {
            get { return Enemy_Champion; }
            set { Enemy_Champion = value; }
        }

    }
}
