﻿using SFML.Graphics;
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
        public void move3(Vector2f plaxerPosition, bool walkableRight, bool walkableLeft, bool walkableTop, bool walkableBot)
        {
            //if (walkableBot) { position.Y += 1; }
            int x = 0;
            int y = 0;

            if (walkableRight) { x = 1; y = 0;}  //das geht
            //if (walkableTop) { x = 0; y = -1;} //scheint zu klapen
            if (!walkableRight) { x = 0; y = 1; }

            _move3(x, y);
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
