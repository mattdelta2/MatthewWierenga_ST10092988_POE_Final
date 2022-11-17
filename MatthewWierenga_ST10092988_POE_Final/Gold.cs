using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_ST10092988_POE_Final
{
    class Gold : Item
    {
        private int golddrops;
        public int GOLDDROPS
        {
            get { return golddrops; }
            set { golddrops = value; }
        }

        private Random RANDOM_NUMBER_GENERATOR = new Random();

        public Gold(int _X, int _Y, string _SYMBOL, TileType _TYPEOFTILE) : base(_X, _Y, _SYMBOL, _TYPEOFTILE)
        {
            GOLDDROPS = RANDOM_NUMBER_GENERATOR.Next(1, 6);
        }
    }
}
