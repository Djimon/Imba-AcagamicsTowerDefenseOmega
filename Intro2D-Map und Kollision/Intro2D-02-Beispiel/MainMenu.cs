using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2D_02_Beispiel
{
    class MainMenu : GameStates
    {
        int x;
        bool isPressed;

        Texture CreditsNotSelected;
        Texture CreditsSelected;
        Texture ExitNotSelected;
        Texture ExitSelected;
        Texture StartNotSelected;
        Texture StartSelected;


        Sprite Start;
        Sprite Credits;
        Sprite Exit;


        Texture backGroundTex;
        Sprite backGround;

        protected uint joystickNumber;
        public void initialize()
        {
            x = 0;
            isPressed = false;
            Start = new Sprite(StartNotSelected);
            Start.Scale = new Vector2f(0.75f, 0.75f);
            Start.Position = new Vector2f(200, 400);
            Credits = new Sprite(CreditsNotSelected);
            Credits.Position = new Vector2f(840, 550);
            Credits.Scale = new Vector2f(0.75f, 0.75f);
            Exit = new Sprite(ExitNotSelected);
            Exit.Position = new Vector2f(840, 400);
            Exit.Scale = new Vector2f(0.75f, 0.75f);
           

            backGround = new Sprite(backGroundTex);
            backGround.Position = new Vector2f(0, 0);
        }

        public void loadContent()
        {
            CreditsNotSelected = new Texture("");
            CreditsSelected = new Texture("");
            ExitNotSelected = new Texture("");
            ExitSelected = new Texture("");
            StartNotSelected = new Texture("");
            StartSelected = new Texture("");


            backGroundTex = new Texture("");
        }

        public EGameStates update(GameTime time)
        {
            //Keyboard Steuerung
           if (Keyboard.IsKeyPressed(Keyboard.Key.Up) && !isPressed)
            {
                x = (x + 1) % 3;
                isPressed = true;
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Down) && !isPressed)
            {
                x = (x - 1) % 3;
                isPressed = true;
            }
                       //if (!Keyboard.IsKeyPressed(Keyboard.Key.Down) && !Keyboard.IsKeyPressed(Keyboard.Key.Up))
                isPressed = false;

 



            if (x == 0)
            {
                Start.Texture = StartSelected;
                Credits.Texture = CreditsNotSelected;
                Exit.Texture = ExitNotSelected;
            }
            if (x == 1)
            {
                Start.Texture = StartNotSelected;
                Credits.Texture = CreditsSelected;
                Exit.Texture = ExitNotSelected;
            }
            if (x == 2)
            {
                Start.Texture = StartNotSelected;
                Credits.Texture = CreditsNotSelected;
                Exit.Texture = ExitSelected;
            }

            
    
            }

            if (x == 0 && Keyboard.IsKeyPressed(Keyboard.Key.Space))
                return EGameStates.inGame;
            if (x == 1 && Keyboard.IsKeyPressed(Keyboard.Key.Space))
                return EGameStates.credits;
            if (x == 2 && Keyboard.IsKeyPressed(Keyboard.Key.Space))
                return EGameStates.none;
            if (x == 3 && Keyboard.IsKeyPressed(Keyboard.Key.Space))
                return EGameStates.controls;

            return EGameStates.mainMenu;
        }

        public void draw(RenderWindow window)
        {
            window.Draw(backGround);
            window.Draw(Start);
            window.Draw(Credits);
            window.Draw(Exit);
            window.Draw(Controls);
        }
    }
}
