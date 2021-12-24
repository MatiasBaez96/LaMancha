using System;
using Raylib_cs;

using LaMancha.Casting;

namespace LaMancha.Services
{
    /// <summary>
    /// Handles all the interaction with the user input library.
    /// </summary>
    public class InputServiceP2
    {
        public InputServiceP2()
        {

        }

        public bool IsLeftPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_LEFT);
        }

        public bool IsRightPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_RIGHT);
        }
        public bool IsUpPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_UP);
        }
        public bool IsDownPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_DOWN);
        }

        /// <summary>
        /// Gets the direction asked for by the current key presses
        /// </summary>
        /// <returns></returns>
        public int GetDirection()
        {
            int x = 0;
            //int y = 0;

            if (IsLeftPressed())
            {
                x = -Constants.PLAYER_SPEED;
            }

            if (IsRightPressed())
            {
                x = Constants.PLAYER_SPEED;
            }
            
            // if (IsUpPressed())
            // {
            //     y = -1;
            // }
            
            // if (IsDownPressed())
            // {
            //     y = 1;
            // }
            
            return x;
        }

        /// <summary>
        /// Returns true if the user has attempted to close the window.
        /// </summary>
        /// <returns></returns>
        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }
    }

}