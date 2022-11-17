using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_ST10092988_POE_Final
{
    public abstract class Enemy: Character
    {
        protected Random RANDOM_NUMBER_GENERATOR = new Random();

        protected Enemy( int _X, int _Y, TileType _TYPEOFTILE, int _DAMAGE, int _STARTINGHP, int _MAXHP) : base (_X,_Y,_TYPEOFTILE, _DAMAGE, _STARTINGHP, _MAXHP)
        {
            DAMAGE = _DAMAGE;
            HP = _STARTINGHP;
            MAXHP = _MAXHP;
        }

        public override string ToString()
        {
            string Info = GetType().Name + "";
            Info += "at [" + X.ToString() + "," + Y.ToString() + "]] \n";
            Info += HP.ToString() + " HP \n";
            Info += "{ " + DAMAGE.ToString() + "}";
            return Info;
        }
    }
}
