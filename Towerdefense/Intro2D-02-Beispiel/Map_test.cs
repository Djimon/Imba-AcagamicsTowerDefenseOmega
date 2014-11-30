using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2D_02_Beispiel
{
    class Map
    {
        Tile[,] mapTiles;
        int[,] mapInt;

        public bool isWalckable(int i, int j)
        {
            if (mapInt[i, j] == 2)
                return true;
            else
                return false;
        }

        public Map()
        {
            mapInt = new int[,]{{0,0,0,0,1,2,2,1,0,0,0,0},
				 {0,0,0,0,1,2,2,1,0,0,0,0},
				 {0,0,3,3,1,2,2,1,0,0,0,0},
				 {0,0,3,2,2,2,2,3,0,0,0,0},
				 {0,0,3,2,2,2,2,3,0,0,0,0},
				 {0,0,3,2,2,3,3,3,3,3,0,0},
				 {0,0,3,2,2,2,2,2,2,3,0,0},
				 {0,0,3,2,2,2,2,2,2,3,0,0},
				 {0,3,3,3,3,3,3,2,2,3,0,0},
				 {0,3,2,2,2,2,2,2,2,3,0,0},
				 {0,3,2,2,2,2,2,2,2,3,0,0},
				 {0,3,2,2,3,3,3,3,3,3,0,0},
				 {0,3,2,2,3,0,0,0,0,0,0,0},
				 {0,3,2,3,3,3,3,1,1,1,1,1},
				 {0,3,2,2,2,2,2,2,2,2,2,1},
				 {0,3,3,3,3,3,3,1,1,1,2,1}};  
            mapTiles = new Tile[mapInt.GetLength(0), mapInt.GetLength(1)];
            for (int i = 0; i < mapInt.GetLength(0); i++)
            {
                for (int j = 0; j < mapInt.GetLength(1); j++)
                {
                    if (mapInt[i, j] == 0)
                    {
                        mapTiles[i, j] = new Tile(true, "tdtextures/texture1.png", new Vector2f((float)(50 * i), (float)(50 * j)));
                    }
                    else if (mapInt[i, j] == 1)
                    {
                        mapTiles[i, j] = new Tile(false, "tdtextures/texture4.png", new Vector2f((float)(50 * i), (float)(50 * j)));
                    }
                    else if (mapInt[i, j] == 2)
                    {
                        mapTiles[i, j] = new Tile(false, "tdtextures/texture3.png", new Vector2f((float)(50 * i), (float)(50 * j)));
                    }
                    else
                    {
                        mapTiles[i, j] = new Tile(false, "tdtextures/texture2.png", new Vector2f((float)(50 * i), (float)(50 * j)));
                    }
                }
            }
        }

       

        public void draw(RenderWindow win)
        {
            for (int i = 0; i < mapInt.GetLength(0); i++)
            {
                for (int j = 0; j < mapInt.GetLength(1); j++)
                {
                    mapTiles[i, j].draw(win);
                }
            }

        }
    }
}
