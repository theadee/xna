using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using AdeeGame.model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AdeeGame.controller
{
    class World : adee.AdeeObject
    {

        // This is where all the object's behavior takes place :)
        // Also, this class and the objects class implements the AdeeObject interface rather than AdeeScreen..... 
        // It doesn't differ much, but I like it that way :)

        // the objects class
        Player player;
        Score score;


        public World()
        {
            // initialization only to be used to declare new class and stuffs that ONLY needs to be called once in the life of the whole game
            player = new Player();
            score = new Score();
        }

        public void initialize()
        {
            // I dunno why I stil separated this xD
            // but I use this like a reset all variable declaration takes place here. But reall it's just useless.... hahaha!
            // because there's this one game where I need to call reset (because game is over) but need to preserve some variables. :)

            player.initialize();
            score.initialize();
        }

        public void loadContent(ContentManager content)
        {
            // mostly, loading assets.....
            // In libgdx this goes under initialize

            player.loadContent(content);
            score.loadContent(content);
        }

        public void dispose()
        {
            // libgdx have dispose that clears saved images and prevents garbage collection :P I think same thing here
            player.dispose();
            score.dispose();
        }

        public void update(float delta)
        {
            // you can set collision detection here
            // example

            /****
             * 
             * if(AdeeTools.colliding(player.rect, score.rect))
             * {
             *      player.doSomethingFunction();
             * }
             * ****/



            // meh
            player.update(delta);
            score.update(delta);
        }

        public void draw(SpriteBatch batch)
        {
            // You can check inside these classes to see what it does 
            // mostly self explanatory
            player.draw(batch);
            score.draw(batch);
        }

        public void postUpdate()
        {
            // this is called every after update, draw and we showed the player what needs to be showed
            // it's like the "behind the scenes" part
            // this clears every variables (e.g. isColliding, isRunning) 
            // don't worry, this is called after the update() where everything is checked if "true" again
            // Logic: We show the player, then reset. I know you know what I mean xD

            player.postUpdate();
            score.postUpdate();
        }


        // to figure out
        // my favorite function T_____T debug mode...
        // function that just shows the rect. 
    }
}
