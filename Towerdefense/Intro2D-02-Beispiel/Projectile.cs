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


        public Projectile(Vector2f _position, string texturePath)
        {
            projectilePos = _position;

            Texture tex = new Texture(texturePath);
            pewpew = new Sprite(tex);
          

        }


    }
}
