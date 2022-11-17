using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_ST10092988_POE_Final
{
    class Mage : Enemy
    {
        public Mage(int _X, int _Y, TileType _TYPEOFTILE, string _SYMBOL = "M", int _DAMAGE = 5, int _STARTINGHP = 5, int _MAXHP = 5) : base(_X, _Y, _TYPEOFTILE, _SYMBOL, _DAMAGE, _STARTINGHP, _MAXHP)
        {

        }

        public override MovementDirection ReturnMove(MovementDirection CharacterMove = MovementDirection.NoMovement)
        {
            return MovementDirection.NoMovement;
        }

        public override bool CheckRange(Character Target)
        {
            int ReachableDistance = 1;
            if ((Math.Abs(X - Target.X) + Math.Abs(Y - Target.Y)) <= ReachableDistance)
            {

                return true;
            }
            else if (Target.X == X - 1 && Target.Y == Y - 1)
            {
                return true;
            }
            else if (Target.X == X + 1 && Target.Y == Y + 1)
            {
                return true;
            }
            else if (Target.X == X - 1 && Target.Y == Y + 1)
            {
                return true;
            }
            else if (Target.X == X + 1 && Target.Y == Y - 1)
            {
                return true;
            }
            else return false;
        }
    }
}
