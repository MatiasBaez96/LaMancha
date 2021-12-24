using Raylib_cs;
namespace LaMancha.Casting
{
    public class Player : Actor
    {
        private int _lastJump;
        
        public Player(int height, int width, int x, int y, string playerName)
        {
            _height = height;
            _width = width;
            _name = playerName;

            _position = new Point(x, 400);
            _velocity = new Point(0,9);
            // bool canJump = true;
        }

        public void StopGravity()
        {
            _velocity = new Point(0,0);
        }

        public void Jump()
        {
            _velocity = new Point(0,-9);
            _lastJump = GetY();
        }

    public void ActivateGravity()
    {
        if (GetY() <= _lastJump - 190)
        {
           _velocity = new Point(0,9);
        }
    }
    }
}