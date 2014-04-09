using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using AdeeGame.adee;
using System.Diagnostics;

namespace AdeeGame.model
{
    class Score : adee.AdeeObject
    {

        public Rectangle rect;
        public float x, y;

        Vector2 position = new Vector2(0, 0);
        Texture2D texture;

        int dirX, dirY;

        public Score()
        {
            rect = new Rectangle();
        }

        public void initialize()
        {
            dirX = 1;
            dirY = 0;

            x = 0;
            y = 0;
        }

        public void loadContent(Microsoft.Xna.Framework.Content.ContentManager content)
        {
            texture = content.Load<Texture2D>("score");

            rect.X = (int)x;
            rect.Y = (int)y;
            rect.Width = texture.Width;
            rect.Height = texture.Height;
        }

        public void dispose()
        {
        }

        public void update(float delta)
        {

            if (x < 0)
            {
                dirX = 1;
            }
            else if (x > 550)
            {
                dirX = 3;
            }
            
            if (y > 400)
            {
                dirY = 2;
            }
            else if (y < 0)
            {
                dirY = 0;
            }


            if (dirY == 0) y += 200 * delta;
            if (dirX == 1) x += 200 * delta;
            if (dirY == 2) y -= 200 * delta;
            if (dirX == 3) x -= 200 * delta;


            // now we set the collision and position
            rect.X = (int)x;
            rect.Y = (int)y;

            // we use the collision rect position because collision...  xD
            position.X = rect.X;
            position.Y = rect.Y;
        }

        public void draw(Microsoft.Xna.Framework.Graphics.SpriteBatch batch)
        {
            batch.Draw(texture, position, Color.White);
        }

        public void postUpdate()
        {
        }
    }
}
