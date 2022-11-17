using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_ST10092988_POE_Final
{
    public class GameEngine
    {
        private Map gamemap;
        public Map GAMEMAP
        {
            get { return gamemap; }
            set { gamemap = value; }
        }

        Random RANDOM_NUMBER_GENERATOR = new Random();

        public GameEngine()
        {
            GAMEMAP = new Map(10, 10, 10, 10, 5, 5);
        }

        public void Save()
        {

        }

        public void Load()
        {

        }

        public bool MovePlayer(MovementDirection Direction)
        {
            if (GAMEMAP.PLAYERCHARACTER.ReturnMove(Direction) == Direction)
            {
                GAMEMAP.Create(TileType.Empty, GAMEMAP.PLAYERCHARACTER.X, GAMEMAP.PLAYERCHARACTER.Y);

                GAMEMAP.PLAYERCHARACTER.Move(Direction);
                GAMEMAP.MAPCONTAINER[GAMEMAP.PLAYERCHARACTER.X, GAMEMAP.PLAYERCHARACTER.Y] = GAMEMAP.PLAYERCHARACTER;

                // foreach (Item i in GAMEMAP.ITEMS)
                //if (i.X == GAMEMAP.PLAYERCHARACTER.X && i.Y == GAMEMAP.PLAYERCHARACTER.Y)
                //{
                //GAMEMAP.PLAYERCHARACTER.PickUp(i);
                //}

                return true;
            }

            return false;
        }

        public string PlayerAttack(int EnemyIndex)
        {
            bool EnemyInRange = false;

            foreach (Tile T in GAMEMAP.PLAYERCHARACTER.VISION)
            {
                if (T.X == GAMEMAP.ENEMIES[EnemyIndex].X && (T.Y == GAMEMAP.ENEMIES[EnemyIndex].Y))
                {
                    EnemyInRange = true;
                    break;
                }
            }

            if (EnemyInRange)
            {
                GAMEMAP.PLAYERCHARACTER.Attack(GAMEMAP.ENEMIES[EnemyIndex]);
                return "You did " + GAMEMAP.PLAYERCHARACTER.DAMAGE.ToString() + " damage to a " + GAMEMAP.ENEMIES[EnemyIndex].TYPEOFTILE.ToString() + " leaving them on " + GAMEMAP.ENEMIES[EnemyIndex].HP.ToString() + "HP";
            }
            else
            {
                return "Target was not in range...";
            }
        }

        public void MoveEnemies()
        {
            int amount;
            for (int i = 0; i < GAMEMAP.ENEMIES.Count; i++)
            {
                amount = RANDOM_NUMBER_GENERATOR.Next(1, 4);
                if (GAMEMAP.ENEMIES[i].SYMBOL == "G")
                {
                    MovementDirection move;
                    move = GAMEMAP.ENEMIES[i].ReturnMove();
                    GAMEMAP.MAPCONTAINER[GAMEMAP.ENEMIES[i].X, GAMEMAP.ENEMIES[i].Y] = new EmptyTile(GAMEMAP.ENEMIES[i].X, GAMEMAP.ENEMIES[i].Y, " ", TileType.Empty);
                    GAMEMAP.ENEMIES[i].Move(move);
                    GAMEMAP.MAPCONTAINER[GAMEMAP.ENEMIES[i].X, GAMEMAP.ENEMIES[i].Y] = GAMEMAP.ENEMIES[i];
                }
            }
        }

        public void enemyAttack(int attackDamage)
        {
            foreach (Enemy e in GAMEMAP.ENEMIES)
            {
                if (e.SYMBOL == "G")
                {
                    if (e.VISION[1].TYPEOFTILE == TileType.Hero)
                    {
                        GAMEMAP.PLAYERCHARACTER.HP -= attackDamage;
                    }
                    else if (e.VISION[3].TYPEOFTILE == TileType.Hero)
                    {
                        GAMEMAP.PLAYERCHARACTER.HP -= attackDamage;
                    }
                    else if (e.VISION[4].TYPEOFTILE == TileType.Hero)
                    {
                        GAMEMAP.PLAYERCHARACTER.HP -= attackDamage;
                    }
                    else if (e.VISION[6].TYPEOFTILE == TileType.Hero)
                    {
                        GAMEMAP.PLAYERCHARACTER.HP -= attackDamage;
                    }
                }
                else
                {
                    foreach (Tile tile in e.VISION)
                    {
                        if (tile.TYPEOFTILE == TileType.Enemy)
                        {
                            GAMEMAP.PLAYERCHARACTER.HP -= attackDamage;
                        }
                    }

                    if (e.VISION[0].TYPEOFTILE == TileType.Enemy)
                    {
                        foreach (Enemy en in GAMEMAP.ENEMIES)
                        {
                            if (en.X == en.VISION[0].X && en.Y == en.VISION[0].Y)
                            {
                                en.HP -= attackDamage;
                            }
                        }
                    }
                    if (e.VISION[1].TYPEOFTILE == TileType.Enemy)
                    {
                        foreach (Enemy en in GAMEMAP.ENEMIES)
                        {
                            if (en.X == en.VISION[1].X && en.Y == en.VISION[1].Y)
                            {
                                en.HP -= attackDamage;
                            }
                        }
                    }
                    if (e.VISION[2].TYPEOFTILE == TileType.Enemy)
                    {
                        foreach (Enemy en in GAMEMAP.ENEMIES)
                        {
                            if (en.X == en.VISION[2].X && en.Y == en.VISION[2].Y)
                            {
                                en.HP -= attackDamage;
                            }
                        }
                    }

                    if (e.VISION[3].TYPEOFTILE == TileType.Enemy)
                    {
                        foreach (Enemy en in GAMEMAP.ENEMIES)
                        {
                            if (en.X == en.VISION[3].X && en.Y == en.VISION[3].Y)
                            {
                                en.HP -= attackDamage;
                            }
                        }
                    }

                    if (e.VISION[4].TYPEOFTILE == TileType.Enemy)
                    {
                        foreach (Enemy en in GAMEMAP.ENEMIES)
                        {
                            if (en.X == en.VISION[4].X && en.Y == en.VISION[4].Y)
                            {
                                en.HP -= attackDamage;
                            }
                        }
                    }

                    if (e.VISION[5].TYPEOFTILE == TileType.Enemy)
                    {
                        foreach (Enemy en in GAMEMAP.ENEMIES)
                        {
                            if (en.X == en.VISION[5].X && en.Y == en.VISION[5].Y)
                            {
                                en.HP -= attackDamage;
                            }
                        }
                    }

                    if (e.VISION[6].TYPEOFTILE == TileType.Enemy)
                    {
                        foreach (Enemy en in GAMEMAP.ENEMIES)
                        {
                            if (en.X == en.VISION[6].X && en.Y == en.VISION[6].Y)
                            {
                                en.HP -= attackDamage;
                            }
                        }
                    }

                    if (e.VISION[7].TYPEOFTILE == TileType.Enemy)
                    {
                        foreach (Enemy en in GAMEMAP.ENEMIES)
                        {
                            if (en.X == en.VISION[1].X && en.Y == en.VISION[1].Y)
                            {
                                en.HP -= attackDamage;
                            }
                        }
                    }
                }
            }
        }
    }
}
