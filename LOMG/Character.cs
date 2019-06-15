using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOMG
{
    abstract class Character
    {
        public Character()
        {
            hp = 100;
        }


        private int maxHp;

        public int GSmaxHp
        {
            get { return maxHp; }
            set { maxHp = value; }
        }


        private static int hp;

        public int GShp
        {
            get { return hp; }
            set { hp = value; }
        }

        private static int exp = 0;

        public int GSexp
        {
            get { return exp; }
            set { exp = value; }
        }

        private static bool dead = false;

        public bool GSdead
        {
            get { return dead; }
            set { dead = value; }
        }

        private static int level = 1;

        public int GSlevel
        {
            get { return level; }
            set { level = value; }
        }

        public void CheckLevel()
        {
            if(exp >= 0 && exp <= 99)
            {
                level = 1;
                GSmaxHp = 100;
            }
            else if(exp >= 100 && exp <= 219)
            {
                level = 2;
                GSmaxHp = 100 + (10 * (level - 1));
            }
            else if (exp >= 220 && exp <= 369)
            {
                level = 3;
                GSmaxHp = 100 + (10 * (level - 1));
            }
            else if (exp >= 370 && exp <= 539)
            {
                level = 4;
                GSmaxHp = 100 + (10 * (level - 1));
            }
            else if (exp >= 540 && exp <= 729)
            {
                level = 5;
                GSmaxHp = 100 + (10 * (level - 1));
            }
            else if (exp >= 730 && exp <= 939)
            {
                level = 6;
                GSmaxHp = 100 + (10 * (level - 1));
            }
            else if (exp >= 940 && exp <= 1169)
            {
                level = 7;
                GSmaxHp = 100 + (10 * (level - 1));
            }
            else if (exp >= 1170 && exp <= 1419)
            {
                level = 8;
                GSmaxHp = 100 + (10 * (level - 1));
            }
            else if (exp >= 1420 && exp <= 1689)
            {
                level = 9;
                GSmaxHp = 100 + (10 * (level - 1));
            }
            else if (exp >= 1690)
            {
                level = 10;
                GSmaxHp = 100 + (10 * (level - 1));
            }
        }

        public abstract int Q_attack();

        

    }
}
