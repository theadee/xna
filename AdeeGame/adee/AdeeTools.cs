using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace AdeeGame.adee
{
    class AdeeTools
    {
        // some tools

        // collision detection
        public static bool colliding(Rectangle a, Rectangle b)
        {
            if (a.Y + a.Height <= b.Y) return false;
            if (a.Y >= b.Y + b.Height) return false;

            if (a.X + a.Width <= b.X) return false;
            if (a.X >= b.X + b.Width) return false;

            return true;
        }


        // to figure out


        // function that reads text and converts to array
        // if we have these, we're awesomely ready!!

        // function that saves a text file
        // for game saving 
    }
}
