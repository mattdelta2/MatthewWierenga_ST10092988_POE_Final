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

        public Enemy(int _X, int _Y, TileType _TYPEOFTILE, string _SYMBOL, int _HP, int _MAXHP, int _DAMAGE, string _WEAPON) : base(_X, _Y, _TYPEOFTILE, _SYMBOL, _HP, _MAXHP, _DAMAGE, _WEAPON)
        {
        }

        protected Enemy( int _X, int _Y, TileType _TYPEOFTILE, int _DAMAGE, int _STARTINGHP, int _MAXHP, string _SYMBOL, string _WEAPON) : base (_X,_Y,_TYPEOFTILE, _SYMBOL, _DAMAGE, _STARTINGHP, _MAXHP, _WEAPON)
        {
            DAMAGE = _DAMAGE;
            HP = _STARTINGHP;
            MAXHP = _MAXHP;
            GOLDPURSE = new List<Item>();
            WEAPON = _WEAPON;
        }

        public override string ToString()
        {
            string Info = GetType().Name + "";
            Info += "at [" + X.ToString() + "," + Y.ToString() + "]] \n";
            Info += HP.ToString() + " HP \n";
            Info += "{ " + DAMAGE.ToString() + "}\n";
            Info += "Amount of Gold: " + goldpurse.Count();
            
            return Info;
        }
    }
}
