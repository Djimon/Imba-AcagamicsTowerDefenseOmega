using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2D_02_Beispiel
{
        class Player
        {
            Vector2f playerPosition;
            Sprite playerSprite;
            bool IsPressed;

            public Vector2f getPosition()
            {
                return playerPosition;
            }

            public float getHeight()
            {
                return playerSprite.Texture.Size.Y * playerSprite.Scale.Y;
            }

            public float getWidth()
            {
                return playerSprite.Texture.Size.X * playerSprite.Scale.X;
            }

            


            public Player()
            {
                Texture playerTexture = new Texture("tdtextures/Player_model.png");
                playerSprite = new Sprite(playerTexture);

                playerPosition = new Vector2f(700, 250);
                playerSprite.Position = playerPosition;

                playerSprite.Scale = new Vector2f(1f, 1f);
            }

            public void move(Map map)
            {

                //springr 50 pixel (1sprite)
                // fehlt if isPressed -abfrage, sonst rast er unendlicc uas dem bild
                //bleibt am Rand stehen, bleibt also im Bild, move-delay fehlt noch
                if (Keyboard.IsKeyPressed(Keyboard.Key.A) && !(playerPosition.X < 50)) { 
                    if (IsPressed){
                    }
                    else {
                        playerPosition = new Vector2f(playerPosition.X - 50f, playerPosition.Y); 
                    }
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.D) && !(playerPosition.X > 749)){
                    if (IsPressed){
                    }
                    else {
                        playerPosition = new Vector2f(playerPosition.X + 50f, playerPosition.Y);
                    }
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.W) && !(playerPosition.Y < 50)){
                    if (IsPressed){
                        }
                    else {playerPosition = new Vector2f(playerPosition.X, playerPosition.Y - 50f);
                    }
                }
                if (Keyboard.IsKeyPressed(Keyboard.Key.S) && !(playerPosition.Y > 549)){
                    if (IsPressed)
                    {
                    }
                    else
                    {
                        playerPosition = new Vector2f(playerPosition.X, playerPosition.Y + 50f);
                    }
                }

                playerSprite.Position = playerPosition;


            }

            public void draw(RenderWindow win)
            {
                win.Draw(playerSprite);
            }

        }
    }

