using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_ST10092988_POE_Final
{
    public abstract class Item : Tile
    {
        public Item(int _X, int _Y, string _SYMBOL, TileType _TYPEOFTILE) : base(_X, _Y, _SYMBOL, _TYPEOFTILE)
        {

        }

        public override string ToString()
        {
            string TypeOfItem = "Item: " + TYPEOFTILE;
            return TypeOfItem;
        }
    }
}
