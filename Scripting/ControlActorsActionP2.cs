using System.Collections.Generic;
using LaMancha.Casting;
using LaMancha.Services;

namespace LaMancha.Scripting
{
    /// <summary>
    /// An action to control the horizontal direction of the hero.
    /// </summary>
    public class ControlActorsActionP2 : Action
    {
        InputServiceP2 _inputServiceP2;

        public ControlActorsActionP2(InputServiceP2 inputServiceP2)
        {
            _inputServiceP2 = inputServiceP2;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            int directionP2 = _inputServiceP2.GetDirection();
            
            Actor player = cast["player2"][0];
            Player player2 = (Player)player;
            Point vel = player2.GetVelocity();
            int y = vel.GetY();
            player2.SetVelocity(new Point(directionP2, y));
            if (_inputServiceP2.IsUpPressed())
            {
                player2.Jump();
            }
            player2.ActivateGravity();
        }
    }
}