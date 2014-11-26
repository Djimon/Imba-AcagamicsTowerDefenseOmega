using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2D_02_Beispiel
{
    class GlobalHitter
    {
        Vector2f goalpoint;
        Sprite goalSprite;

        public Vector2f getPosition()
        {
            return this.goalpoint;
        }

        public float getHeight()
        {
            return goalSprite.Texture.Size.X;
        }

        public float getWidth()
        {
            return goalSprite.Texture.Size.Y;
        }


        public GlobalHitter() 
        {
            Texture goalTex = new Texture("Pictures\tile2.png");
            goalpoint = new Vector2f(700, 250);
            goalSprite = new Sprite(goalTex);
            goalSprite.Position = goalpoint;
        
        }

        public void draw(RenderWindow win)
        {
            win.Draw(goalSprite);
        }


    }
}
