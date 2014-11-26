using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2D_02_Beispiel
{
    
    public enum EGameStates
    {
        none,
        mainMenu,
        inGame,
        credits,
        gameWon,
        controls,
    }

    interface GameStates
    {
        void initialize();

        void loadContent();

        EGameStates update(GameTime time);

        void draw(RenderWindow win);
    }
    
}
