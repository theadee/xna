using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace AdeeGame.model
{
    class Player : adee.AdeeObject
    {

        public Rectangle rect;
        public float x, y;

        Vector2 position = new Vector2(0, 0);
        Texture2D texture;

        public Player()
        {
            rect = new Rectangle();
        }

        public void initialize()
        {
            x = 0;
            y = 0;
        }

        public void loadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("square");

            // rectangle is for collision detection
            rect.X = (int) x;
            rect.Y = (int) y;
            rect.Width = texture.Width;
            rect.Height = texture.Height;
        }

        public void dispose()
        {
        }

        public void update(float delta)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                x -= 300 * delta;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                x += 300 * delta;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                y -= 300 * delta;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                y += 300 * delta;
            }


            // now we set the collision and position
            rect.X = (int)x;
            rect.Y = (int)y;

            // we use the collision rect position because collision...  xD
            position.X = rect.X;
            position.Y = rect.Y;
        }

        public void draw(Microsoft.Xna.Framework.Graphics.SpriteBatch batch)
        {
            // this is probably what it contains xD
            batch.Draw(texture, position, Color.White);
        }

        public void postUpdate()
        {
        }
    }
}
