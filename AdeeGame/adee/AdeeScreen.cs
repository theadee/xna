using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace AdeeGame.adee
{
    interface AdeeScreen
    {
        // this is mostly for ease of use xD
        void initialize();
        void loadContent(ContentManager content);
        void unloadContent();
        void update(float delta);
        void draw(SpriteBatch batch);
    }
}
