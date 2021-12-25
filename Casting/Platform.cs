namespace LaMancha.Casting
{
    public class Platform : Actor
    {
        public Platform(int height, int width, Point position)
        {
            _height = height;
            _width = width;
            
            _position = position;
            _velocity = new Point(0,0);
        }
    }
}