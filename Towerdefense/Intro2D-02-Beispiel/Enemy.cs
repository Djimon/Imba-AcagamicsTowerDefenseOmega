using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2D_02_Beispiel
{
    class Enemy
    {
        Vector2f position;
        Sprite sprite;

        public Vector2f getPosition()
        {
            return this.position;
        }

        public float getHeight()
        {
            return sprite.Texture.Size.X; 
        }

        public float getWidth()
        {
            return sprite.Texture.Size.Y;
        }

        public int getX()
        {
            return (int)(this.position.X / 50);
        }
        public int getY()
        {
            return (int)(this.position.Y / 50);
        }

        public Enemy(Vector2f _position, string texturePath)
        {
            position = _position;

            Texture tex = new Texture(texturePath);
            sprite = new Sprite(tex);
            sprite.Scale = new Vector2f(0.8f, 0.8f); //skallierung angepast, damit sie besser durchs gelände laufen können

        }

        public void draw(RenderWindow win)
        {
            sprite.Position = position;
            win.Draw(sprite);
        }

        public void _move3(Single x, Single y)
        {
            position.X += x;
            position.Y += y;
            //int[] tmp = new int[2];
            
        }

        //KI - move test //aufruf in Game.cs (siehe: update()>> tobi.move3(..)
        public void move3(Vector2f playerPosition, bool walkableRight, bool walkableLeft, bool walkableTop, bool walkableBot)
        {
            int x = 0;
            int y = 0;

            /* nicht ganz präzise aber haut hin
            if (walkableRight && Keyboard.IsKeyPressed(Keyboard.Key.D)) { x = 1; y = 0;}  //das geht
            if (walkableTop && Keyboard.IsKeyPressed(Keyboard.Key.W)) { x = 0; y = -1;} //scheint zu klapen
            if (walkableLeft && Keyboard.IsKeyPressed(Keyboard.Key.A)) { x = -1; y = 0; } // scheint auch zu klappen
            if (walkableBot && Keyboard.IsKeyPressed(Keyboard.Key.S)) { x = 0; y = 1; }
            */
            
            

            int tmp = check(playerPosition, walkableRight, walkableLeft, walkableTop, walkableBot);

            if (tmp == 0) { x = 1; y = 0; }
            if (tmp == 1) { x = -1; y = 0; }
            if (tmp == 2) { x = 0; y = -1; }
            if (tmp == 3) { x = 0; y = 1; }

            _move3(x, y);
        }

        public int check(Vector2f playerPosition,bool walkableRight, bool walkableLeft, bool walkableTop, bool walkableBot)
        {          
            /*
             * 0 only walkable right
             * 1 only walkable left
             * 2 only walkable top
             * 3 only walkable bot
             */
            if (!walkableTop && !walkableBot && walkableRight && !walkableLeft)
            { return 0; }
            if (!walkableTop && !walkableBot && !walkableRight && walkableLeft)
            { return 1; }
            if (walkableTop && !walkableBot && !walkableRight && !walkableLeft)
            { return 2; }
            if (!walkableTop && walkableBot && !walkableRight && !walkableLeft)
            { return 3; }

            int getxEnemy = (int)playerPosition.X / 50;
            int getyEnemy = (int)playerPosition.Y / 50;

            /*
             * tobi.getX()+1 ,tobi.getY()+1),  //movableRight  0
             * tobi.getX() , tobi.getY()+1),   //movableLeft   1
             * tobi.getX(), tobi.getY()),    //movableTop      2
             * tobi.getX(), tobi.getY()+1));     //movableBot  3
             */
            

            return -1;       
        }

        public double dist(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        public void move(Vector2f playerposition)
        {
            if (position.X < 210) position.X += 0.1f;
            if (position.X >= 210 && position.X < 300 && position.Y >150) position.Y -= 0.1f;
            if (position.Y <= 150 && position.X < 360) position.X += 0.1f;
            if (position.X >= 360 && position.Y<410 &&position.X<400) position.Y += 0.1f;
            if (position.X >= 360 && position.X < 510 && position.Y >= 410) position.X += 0.1f;
            if (position.X >= 510 && position.X < 600 && position.Y >100) position.Y -= 0.1f;
            if (position.X >= 510 && position.X < 700 && position.Y <= 100) position.X += 0.1f;
            if (position.X < 750 && position.X >= 700 && position.Y < 510) position.Y += 0.1f;
            if (position.X < 810 && position.X >= 700 && position.Y >= 510) position.X += 0.1f;
            if(position.X > 800)
            {
               // position.X = position.X % 800;
                position.X = 0;
                position.Y = 265;
            }

            //Vector2f direction = playerposition - position;
            //float length = (float)Math.Sqrt(direction.X * direction.X + direction.Y * direction.Y);
            //position += direction/(length* 5);
        }

        public void move2 ()
        {
            position.X += 0.1f;
            if (position.X > 800)
            {
                position.X = position.X % 800;
            }
        }

    }
}
