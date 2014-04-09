using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using AdeeGame.controller;
using Microsoft.Xna.Framework.Content;

namespace AdeeGame.screen
{
    class GameScreen : adee.AdeeScreen
    {
        

        Game1 game;

        // world. This class is for ease of use. Also to separate, the controller (world) and the view (GameScreen) MVC :)
        World world;
        
        public GameScreen(Game1 game)
        {
            this.game = game;
            world = new World();
        }

        public void initialize()
        {
            world.initialize();
        }

        public void loadContent(ContentManager content)
        {
            world.loadContent(content);
        }

        public void unloadContent()
        {
            world.dispose();
        }

        public void update(float delta)
        {
            world.update(delta);
        }

        public void draw(SpriteBatch batch)
        {
            world.draw(batch);
            world.postUpdate();

        }
    }
}
