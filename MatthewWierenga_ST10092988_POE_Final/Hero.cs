using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_ST10092988_POE_Final
{
    public class Hero : Character
    {
        public Hero(int _X, int _Y, TileType _TYPEOFTILE, string _SYMBOL, int _HP, int _MAXHP, int _DAMAGE) : base(_X, _Y, _TYPEOFTILE, _SYMBOL, _HP, _MAXHP, _DAMAGE)
        {

        }

        public override MovementDirection ReturnMove(MovementDirection CharacterMove = MovementDirection.NoMovement)
        {
            if (CheckForValidMove(CharacterMove))
            {
                return CharacterMove;
            }
            else return MovementDirection.NoMovement;
        }

        public override string ToString()
        {
            string Info = "Player Stats: \n";
            Info += "HP: " + HP.ToString() + "/" + MAXHP.ToString() + "\n";
            Info += "Damage: " + DAMAGE.ToString() + "\n";
            Info += "[" + X.ToString() + "," + Y.ToString() + "] \n";
            Info += " Amount of gold: " + GOLDPURSE.Count + "\n";
            return Info;
        }

        bool CheckForValidMove(MovementDirection CharacterMove)
        {
            bool IsValid = false;

            switch (CharacterMove)
            {
                case MovementDirection.Right:
                    foreach (Tile T in VISION)
                    {
                        if (T.X == X + 1)
                        {
                            if (T.TYPEOFTILE == TileType.Empty)
                            {
                                IsValid = true;
                                break;
                            }
                        }
                    }

                    break;

                case MovementDirection.Left:
                    foreach (Tile T in VISION)
                    {
                        if (T.X == X - 1)
                        {
                            if (T.TYPEOFTILE == TileType.Empty)
                            {
                                IsValid = true;
                                break;
                            }
                        }
                    }

                    break;

                case MovementDirection.Up:
                    foreach (Tile T in VISION)
                    {
                        if (T.Y == Y - 1)
                        {
                            if (T.TYPEOFTILE == TileType.Empty)
                            {
                                IsValid = true;
                                break;
                            }
                        }
                    }

                    break;

                case MovementDirection.Down:
                    foreach (Tile T in VISION)
                    {
                        if (T.Y == Y + 1)
                        {
                            if (T.TYPEOFTILE == TileType.Empty)
                            {
                                IsValid = true;
                                break;
                            }
                        }
                    }

                    break;
            }

            return IsValid;
        }
    }
}
