namespace LaMancha.Casting
{
    public class Platform : Actor
    {
        public Platform()
        {
            _height = 24;
            _width = Constants.MAX_X;
            
            _position = new Point(0, Constants.MAX_Y - 100);
            _velocity = new Point(0,0);
        }
    }
}