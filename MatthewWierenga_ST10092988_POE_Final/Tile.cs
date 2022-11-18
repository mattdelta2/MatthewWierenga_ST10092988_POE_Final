using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_ST10092988_POE_Final
{
        
    public abstract class Tile
    {
        protected int x;
        public int X
        {
            get { return x; }
            set { x = value;  }
        }

        protected int y;
        public int Y
        {
            get { return y; }
            set { y = value; }

        }

        private TileType typeoftile;
        public TileType TYPEOFTILE
        {
            get { return typeoftile; }
            set { typeoftile = value; }
        }

        protected string symbol;
        public string SYMBOL
        {
            get { return symbol; }
            set { symbol = value; }
        }

        protected string weapon;
        public string WEAPON
        {
            get { return weapon; }
            set { weapon = value; }
        }

        

        public Tile(int _X, int _Y, string _SYMBOL, TileType _TYPEOFTILE,string _WEAPON)
        {
            X = _X;
            Y = _Y;
            SYMBOL = _SYMBOL;
            TYPEOFTILE = _TYPEOFTILE;
            WEAPON = _WEAPON;

        }
    }
}
