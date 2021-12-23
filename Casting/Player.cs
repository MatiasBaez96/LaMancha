using Raylib_cs;
namespace LaMancha.Casting
{
    public class Player : Actor
    {
        public Player(int height, int width, int x, int y)
        {
            _height = height;
            _width = width;

            _position = new Point(x, y);
            _velocity = new Point(1,-1);
        }
    }
}