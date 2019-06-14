using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOMG
{
    class bools
    {
        private static bool igOn = false;

        public bool GSigOn
        {
            get { return igOn; }
            set { igOn = value; }
        }

        private static bool amIServer;

        public bool GSamIServer
        {
            get { return amIServer; }
            set { amIServer = value; }
        }


    }
}
