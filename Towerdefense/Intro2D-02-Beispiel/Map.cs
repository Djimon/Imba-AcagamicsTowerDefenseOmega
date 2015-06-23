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
                return false;
            else
                return true;
        }
        public bool isWalckable2(int i, int j)
        {
            if (i < 0 || i > 600) { i = 0; }
            if (j < 0 || j > 600) { j = 0; }
            if (mapInt[i, j] == 2)
                return true;
            else
                return false;
        }

        public Map()
        {
            // 0= gras
            // 1= blocked
            // 2= walkable(gehweg)
            // 3 = blocked
            mapInt = new int[,]{
                 {0,0,0,0,0,1,2,1,0,0,0,0},
				 {0,0,0,0,0,1,2,1,0,0,0,0},
				 {0,0,0,0,0,1,2,1,0,0,0,0},
				 {0,0,0,0,0,0,2,0,0,0,0,0},
				 {0,2,2,2,2,2,2,2,2,2,2,0},
				 {0,2,0,0,2,0,0,0,0,0,2,0},
				 {0,2,0,0,2,2,0,0,0,0,2,0},
				 {0,2,0,0,0,2,0,0,2,0,2,0},
				 {0,2,0,0,0,2,0,0,2,0,2,0},
				 {0,2,2,2,2,2,2,2,2,2,2,0},
				 {0,0,2,0,0,0,2,0,0,0,2,0},
				 {0,0,2,0,0,0,2,0,0,0,2,0},
				 {0,0,2,0,0,0,2,0,0,0,2,0},
				 {0,0,2,0,0,0,2,1,1,1,2,1},
				 {0,0,2,2,2,2,2,2,2,2,2,1},
				 {0,0,0,0,0,0,0,1,1,1,2,1}};  
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
