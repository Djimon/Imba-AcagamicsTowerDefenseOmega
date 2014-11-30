using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2D_02_Beispiel
{
    class Projectile
    {
         Vector2f projectilePos;
        Sprite pewpew;

        public Vector2f getPosition()
        {
            return this.projectilePos;
        }

        public float getHeight()
        {
            return pewpew.Texture.Size.X; 
        }

        public float getWidth()
        {
            return pewpew.Texture.Size.Y;
        }


        public Projectile(Vector2f _position)
        {
            projectilePos = _position;
            Texture tex = new Texture("tdtextures/projektile.png");
            pewpew = new Sprite(tex);
           // pewpew.Position = projectilePos;
          

        }

        public void shoot(Vector2f enemypos)       {
    
            Vector2f direction = enemypos - projectilePos;
            float length = (float)Math.Sqrt(direction.X * direction.X + direction.Y * direction.Y);
            if (projectilePos.X - enemypos.X <= 200) 
            {
                
            projectilePos += direction/(length* 5);
            }

        }

        public void draw(RenderWindow win)
        {
           pewpew.Position = projectilePos;
           win.Draw(pewpew);

        }

    }
}
