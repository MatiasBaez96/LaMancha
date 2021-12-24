using System.Collections.Generic;
using LaMancha.Casting;
using LaMancha.Services;

namespace LaMancha.Scripting
{
    /// <summary>
    /// An action to control the horizontal direction of the hero.
    /// </summary>
    public class ControlActorsActionP1 : Action
    {
        InputServiceP1 _inputServiceP1;

        public ControlActorsActionP1(InputServiceP1 inputServiceP1)
        {
            _inputServiceP1 = inputServiceP1;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            int directionP1 = _inputServiceP1.GetDirection();
            
            Actor player = cast["player"][0];
            Player player1 = (Player)player;
            Point vel = player1.GetVelocity();
            int y = vel.GetY();
            player1.SetVelocity(new Point(directionP1, y));
            if (_inputServiceP1.IsUpPressed())
            {
                player1.Jump();
            }
            player1.ActivateGravity();
        }
    }
}