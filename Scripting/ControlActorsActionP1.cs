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
            Point directionP1 = _inputServiceP1.GetDirection();
            
            Actor player1 = cast["player"][0];

            Point velocityP1 = directionP1.Scale(Constants.PLAYER_SPEED);
            player1.SetVelocity(velocityP1);
        }
    }
}