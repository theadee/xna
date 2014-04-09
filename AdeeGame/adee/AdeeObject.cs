using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace AdeeGame.adee
{
    interface AdeeObject
    {
        void initialize();
        void loadContent(ContentManager content);
        void dispose();
        void update(float delta);
        void draw(SpriteBatch batch);
        void postUpdate();
    }
}
