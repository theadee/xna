using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdeeGame.adee
{
    public static enum ScreenState
    {
        LoadingScreen,
        MenuScreen,
        GameScreen,
        GameOverScreen
    }
    class Assets
    {

        public static ScreenState state;
        public static int screenw;
        public static int screenh;

        public static void load()
        {
            state = ScreenState.LoadingScreen;

            screenw = 550;
            screenh = 400;
        }
    }
}
