using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_ST10092988_POE_Final
{
   public class SwampCreature:Enemy
    {

        public SwampCreature(int _X, int _Y, TileType _TYPEOFTILE, string _SYMBOL = "S", int _DAMAGE = 1, int _STARTINGHP = 10, int _MAXHP = 10) : base(_X, _Y, _TYPEOFTILE, _SYMBOL, _DAMAGE, _STARTINGHP, _MAXHP)
        {

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

        public override MovementDirection ReturnMove(MovementDirection CharacterMove = MovementDirection.NoMovement)
        {
            int RandomTileIndex = RANDOM_NUMBER_GENERATOR.Next(0, VISION.Count);
            while (VISION[RandomTileIndex].TYPEOFTILE.Equals(typeof(EmptyTile)))
            {
                RandomTileIndex = RANDOM_NUMBER_GENERATOR.Next(0, VISION.Count);
            }
            MovementDirection move = MovementDirection.NoMovement;
            if (VISION[RandomTileIndex].X > X)
            {

                move = MovementDirection.Right;
            }
            else if (VISION[RandomTileIndex].X < X)
            {
                move = MovementDirection.Left;
            }
            else if (VISION[RandomTileIndex].Y > Y)
            {
                move = MovementDirection.Down;
            }
            else if (VISION[RandomTileIndex].Y < Y)
            {
                move = MovementDirection.Up;
            }

            if (CheckForValidMove(move))
            {
                return move;
            }
            else return MovementDirection.NoMovement;
        }

    }
}
