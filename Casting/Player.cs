using Raylib_cs;
namespace LaMancha.Casting
{
    public class Player : Actor
    {
        
        public Player(int height, int width, int x, int y, string playerName)
        {
            _height = height;
            _width = width;
            _name = playerName;

            _position = new Point(x, y);
            _velocity = new Point(0,0);
        }
    }
}