using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2D_02_Beispiel
{
    class Tower
    {
        Vector2f towerPosition;
        Sprite towerSprite;
         public Tower(Vector2f position)
            {
                Texture towerTexture = new Texture("tdtextures/tower1.png");
                towerSprite = new Sprite(towerTexture);

                towerPosition = new Vector2f(position.X, position.Y);
                towerSprite.Position = towerPosition;

                towerSprite.Scale = new Vector2f(1f, 1f);
            }
    }
}
