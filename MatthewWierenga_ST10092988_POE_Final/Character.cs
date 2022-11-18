using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_ST10092988_POE_Final
{

    public abstract class Character : Tile
    {
        protected int hp;
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        protected int maxhp;
        public int MAXHP
        {
            get { return maxhp; }
            set { maxhp = value; }
        }

        protected int damage;
        public int DAMAGE
        {
            get { return damage; }
            set { damage = value; }
        }

        protected List<Tile> vision;
        public List<Tile> VISION
        {
            get { return vision; }
            set { vision = value; }
        }

        protected int movement;
        public int MOVEMENT
        {
            get { return movement; }
            set { movement = value; }
        }

        protected List<Item> goldpurse;
        public List<Item> GOLDPURSE
        {
            get { return goldpurse; }
            set { goldpurse = value; }

            
        }

        protected string weapon;
        public string WEAPON
        {
            get { return weapon; }
            set { weapon = value; }
        }
        protected Character(int _X, int _Y, TileType _TYPEOFTILE, string _SYMBOL, int _HP, int _MAXHP, int _DAMAGE) : base(_X, _Y, _SYMBOL, _TYPEOFTILE)
        {
            SYMBOL = _SYMBOL;
            HP = _HP;
            MAXHP = _MAXHP;
            DAMAGE = _DAMAGE;
            GOLDPURSE = new List<Item>();

            VISION = new List<Tile>();

            //WEAPON = _WEAPON;
        }

        public virtual void Attack(Character Target)
        {
            Target.HP -= DAMAGE;
        }

        public bool IsDead()
        {
            if (HP <= 0)
            {
                return true;
            }
            else return false;
        }

        public virtual bool CheckRange(Character Target)
        {
            int ReachableDistance = 1;
            if (DistanceTo(Target) <= ReachableDistance)
            {
                return true;
            }
            else return false;
        }

        private int DistanceTo(Character Target)
        {
            return Math.Abs(X - Target.X) + Math.Abs(Y - Target.Y);
        }

        public void Move(MovementDirection CharacterMove)
        {
            switch (CharacterMove)
            {
                case MovementDirection.Up:
                    Y--;

                    if (Y == 0)
                    {
                        Y = 1;
                    }

                    break;
                case MovementDirection.Down:
                    Y++;


                    break;
                case MovementDirection.Left:
                    X--;

                    if (X == 0)
                    {
                        X = 1;
                    }
                    break;
                case MovementDirection.Right:
                    X++;
                    break;
            }
        }

        public void PickUp(Item i)
        {
            if (i.SYMBOL == "$")
            {
                GOLDPURSE.Add(i);
            }
        }

        public abstract MovementDirection ReturnMove(MovementDirection CharacterMove = 0);
        public abstract override string ToString();
    }


}
