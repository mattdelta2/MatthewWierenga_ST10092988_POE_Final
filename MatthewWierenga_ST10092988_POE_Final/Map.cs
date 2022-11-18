using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewWierenga_ST10092988_POE_Final
{
    public class Map
    {
        private Tile[,] mapcontainer;
        public Tile[,] MAPCONTAINER
        {
            get { return mapcontainer; }
            set { mapcontainer = value; }
        }

        private Hero playercharacter;
        public Hero PLAYERCHARACTER
        {
            get { return playercharacter; }
            set { playercharacter = value; }
        }

        private List<Enemy> enemies;
        public List<Enemy> ENEMIES
        {
            get { return enemies; }
            set { enemies = value; }
        }

        private int mapwidth;
        public int MAPWIDTH
        {
            get { return mapwidth; }
            set { mapwidth = value; }
        }

        private int mapheight;
        public int MAPHEIGHT
        {
            get { return mapheight; }
            set { mapheight = value; }
        }

        private Item[] items;

        public Item[] ITEMS
        {
            get { return items; }
            set { items = value; }
        }

        int hX;
        int hY;
        int totalItems;

        protected Random RANDOM_NUMBER_GENERATOR = new Random();

        public Map(int _MINWIDTH, int _MAXWIDTH, int _MINHEIGHT, int _MAXHEIGHT, int _NUMBEROFENEMIES, int _NUMBEROFITEMS)
        {
            MAPWIDTH = RANDOM_NUMBER_GENERATOR.Next(_MINWIDTH, _MAXWIDTH);
            MAPHEIGHT = RANDOM_NUMBER_GENERATOR.Next(_MINHEIGHT, _MAXHEIGHT);

            MAPCONTAINER = new Tile[MAPWIDTH, MAPHEIGHT];

            ENEMIES = new List<Enemy>();

            ITEMS = new Item[_NUMBEROFITEMS];

            GenerateInitialMap(_NUMBEROFENEMIES, _NUMBEROFITEMS);

            UpdateVision();

            totalItems = _NUMBEROFITEMS;
        }

        public void UpdateVision()
        {
            foreach (Enemy E in ENEMIES)
            {
                E.VISION.Clear();

                if (E.X > 0)
                {
                    E.VISION.Add(MAPCONTAINER[E.X - 1, E.Y]);
                }

                if (E.X < MAPWIDTH - 1)
                {
                    E.VISION.Add(MAPCONTAINER[E.X + 1, E.Y]);
                }

                if (E.Y > 0)
                {
                    E.VISION.Add(MAPCONTAINER[E.X, E.Y - 1]);
                }

                if (E.Y < MAPHEIGHT - 1)
                {
                    E.VISION.Add(MAPCONTAINER[E.X, E.Y + 1]);
                }
            }

            PLAYERCHARACTER.VISION.Clear();

            if (PLAYERCHARACTER.X > 0)
            {
                PLAYERCHARACTER.VISION.Add(MAPCONTAINER[PLAYERCHARACTER.X - 1, PLAYERCHARACTER.Y]);
            }

            if (PLAYERCHARACTER.X < MAPWIDTH - 1)
            {
                PLAYERCHARACTER.VISION.Add(MAPCONTAINER[PLAYERCHARACTER.X + 1, PLAYERCHARACTER.Y]);
            }

            if (PLAYERCHARACTER.Y > 0)
            {
                PLAYERCHARACTER.VISION.Add(MAPCONTAINER[PLAYERCHARACTER.X, PLAYERCHARACTER.Y - 1]);
            }

            if (PLAYERCHARACTER.Y < MAPHEIGHT - 1)
            {
                PLAYERCHARACTER.VISION.Add(MAPCONTAINER[PLAYERCHARACTER.X, PLAYERCHARACTER.Y + 1]);
            }

            int t = 0;
        }

        void GenerateInitialMap(int _NUMBEROFENEMIES, int _NUMBEROFITEMS)
        {
            for (int y = 0; y < MAPWIDTH; y++)
            {
                for (int x = 0; x < MAPHEIGHT; x++)
                {
                    if (x == 0 || x == MAPWIDTH - 1 || y == 0 || y == MAPHEIGHT - 1)
                    {
                        Create(TileType.Barrier, x, y);
                    }
                    else
                    {
                        Create(TileType.Empty, x, y);
                    }
                }
            }

            Create(TileType.Hero);

            for (int e = 0; e < _NUMBEROFENEMIES; e++)
            {
                Create(TileType.Enemy);
            }

            for (int e = 0; e < _NUMBEROFITEMS; e++)
            {
                Create(TileType.Gold);
            }
        }

        public void Create(TileType TypeOfTile, int X = 0, int Y = 0)
        {
            switch (TypeOfTile)
            {
                case TileType.Barrier:
                    Obstacle NewBarrier = new Obstacle(X, Y, "#", TypeOfTile);
                    MAPCONTAINER[X, Y] = NewBarrier;
                    break;
                case TileType.Empty:
                    EmptyTile NewEmptyTile = new EmptyTile(X, Y, " ", TypeOfTile);
                    MAPCONTAINER[X, Y] = NewEmptyTile;
                    break;
                case TileType.Hero:
                    int HeroX = RANDOM_NUMBER_GENERATOR.Next(0, MAPWIDTH);
                    int HeroY = RANDOM_NUMBER_GENERATOR.Next(0, MAPHEIGHT);

                    while (MAPCONTAINER[HeroX, HeroY].TYPEOFTILE != TileType.Empty)
                    {
                        HeroX = RANDOM_NUMBER_GENERATOR.Next(0, MAPWIDTH);
                        HeroY = RANDOM_NUMBER_GENERATOR.Next(0, MAPHEIGHT);
                    }

                    Hero NewHero = new Hero(HeroX, HeroY, TypeOfTile, "H", 100, 100, 10, "W" );
                    PLAYERCHARACTER = NewHero;
                    MAPCONTAINER[HeroX, HeroY] = NewHero;
                    hX = HeroX;
                    hY = HeroY;
                    break;
                case TileType.Enemy:
                    int EnemyX = RANDOM_NUMBER_GENERATOR.Next(0, MAPWIDTH);
                    int EnemyY = RANDOM_NUMBER_GENERATOR.Next(0, MAPHEIGHT);

                    while (MAPCONTAINER[EnemyX, EnemyY].TYPEOFTILE != TileType.Empty)
                    {
                        EnemyX = RANDOM_NUMBER_GENERATOR.Next(0, MAPWIDTH);
                        EnemyY = RANDOM_NUMBER_GENERATOR.Next(0, MAPHEIGHT);
                    }

                    if (RANDOM_NUMBER_GENERATOR.Next(1, 3) == 1)
                    {
                        SwampCreature NewEnemy = new SwampCreature(EnemyX, EnemyY, TypeOfTile, "S", 100, 100, 10);
                        ENEMIES.Add(NewEnemy);
                        MAPCONTAINER[EnemyX, EnemyY] = NewEnemy;
                    }
                    else if (RANDOM_NUMBER_GENERATOR.Next(1, 3) == 2)
                    {
                        Mage NewEnemy = new Mage(EnemyX, EnemyY, TypeOfTile, "M", 100, 100, 10);
                        ENEMIES.Add(NewEnemy);
                        MAPCONTAINER[EnemyX, EnemyY] = NewEnemy;
                    }

                    break;
                case TileType.Gold:
                    int GoldX = RANDOM_NUMBER_GENERATOR.Next(0, MAPWIDTH);
                    int GoldY = RANDOM_NUMBER_GENERATOR.Next(0, MAPHEIGHT);

                    while (MAPCONTAINER[GoldX, GoldY].TYPEOFTILE != TileType.Empty)
                    {
                        GoldX = RANDOM_NUMBER_GENERATOR.Next(0, MAPWIDTH);
                        GoldY = RANDOM_NUMBER_GENERATOR.Next(0, MAPHEIGHT);
                    }

                    ITEMS[totalItems] = new Gold(GoldX, GoldY, "$", TileType.Gold);
                    MAPCONTAINER[GoldX, GoldY] = ITEMS[totalItems];

                    break;
            }
        }

        public override string ToString()
        {
            string MapString = "";

            for (int y = 0; y < MAPWIDTH; y++)
            {
                for (int x = 0; x < MAPHEIGHT; x++)
                {
                    MapString += MAPCONTAINER[x, y].SYMBOL;
                }
                MapString += "\n";
            }
            return MapString;
        }

        public Item GetItemAtPosition(int x, int y)
        {
            Item artifact = null;

            for (int i = 0; i < ITEMS.Length; i++)
            {
                if (ITEMS[i].X == x && ITEMS[i].Y == y)
                {
                    artifact = ITEMS[i];
                    ITEMS[i] = null;
                }
            }

            if (artifact == null)
            {
                return null;
            }
            else
            {
                return artifact;
            }
        }
    }
}
