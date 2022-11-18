using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_ST10092988_POE_Final
{
    class EmptyTile: Tile
    {
        private string v;



        public EmptyTile(int _X, int _Y, string _SYMBOL, TileType _TYPEOFTILE) : base(_X, _Y, _SYMBOL, _TYPEOFTILE)
        {

        }
    }
}
