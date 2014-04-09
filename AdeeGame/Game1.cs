#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
using AdeeGame.screen;
using AdeeGame.adee;
#endregion

namespace AdeeGame
{
    public class Game1 : Game
    {
        // NOTE: I removed the predefined comments from the monogame template so you can see what I added :)

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // This is the game screen
        GameScreen gameScreen;
        // other screens to be added here..... (Loading screen, Game Over screen, Menu Screen, Score screen... etc)

        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // Load public static variables check Assets.cs
            Assets.load();
            
            graphics.PreferredBackBufferWidth = Assets.screenw;
            graphics.PreferredBackBufferHeight = Assets.screenh;
            
            gameScreen = new GameScreen(this);
        }

        protected override void Initialize()
        {
            gameScreen.initialize();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            gameScreen.loadContent(this.Content);
        }

        protected override void UnloadContent()
        {
            gameScreen.unloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // I'm so used to delta time.... so I just pass delta time so every screen have same value
            float delta = (float)gameTime.ElapsedGameTime.TotalSeconds;


            // states
            if (Assets.state == ScreenState.GameScreen)
            {
                gameScreen.update(delta);
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            
            // where draw begins
            if (Assets.state == ScreenState.GameScreen)
            {
                gameScreen.draw(spriteBatch);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
